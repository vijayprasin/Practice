using StockReport.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using System.Reflection;
using System.Text;
using StockReport.Server.RequestModels;
using System.Diagnostics;
using StockReport.Server.ResponseModels;
using System;

namespace StockReport.Server.Repositories
{
    public class StockReportRepository : IStockReportRepository
    {
        private readonly MyAppDbContext _dbContext;

        public StockReportRepository(MyAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UploadFileResponseModel> GetDistinctSymbolsAsync(DataLoaderReqModel request)
        {

            if (request.UploadedFile == null || request.UploadedFile.Length == 0)
            {
                throw new Exception("No file uploaded.");
            }

            // Define the path to save the uploaded file
            var filePath = Path.Combine(Path.GetTempPath(), request.UploadedFile.FileName);

            // Save the file to the specified path
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await request.UploadedFile.CopyToAsync(stream);
            }

            // Define the path to the Python interpreter
            //string pythonInterpreter = @"C:\Users\swarn\AppData\Local\Programs\Python\Python312\python.exe";
            //string pythonInterpreter = @"C:\Users\Admin\AppData\Local\Programs\Python\Python313\python.exe";
            string pythonInterpreter = @"/usr/local/bin/python3";

            // Update this to the correct path
            //string scriptPath = @"C:\Users\swarn\OneDrive\Desktop\CodeTest\swarna\DataLoader\Loader.py";
            //string scriptPath = @"C:\Users\Admin\Downloads\DataLoader\DataLoader\Loader.py";
            string scriptPath= @"/Users/vijay/Desktop/Vijay/DataLoader/Loader.py";
            
            var start = new ProcessStartInfo
            {
                FileName = pythonInterpreter, // Use the Python executable
                Arguments = $"{scriptPath} \"{filePath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            try
            {
                using (var process = Process.Start(start))
                {
                    using (var reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        // You can also read standard error if needed
                        string error = process.StandardError.ReadToEnd();

                        // Check if the process exited successfully
                        process.WaitForExit();
                        if (process.ExitCode != 0)
                        {
                            // Handle error scenario, perhaps log the error message
                            throw new Exception($"Error running script: {error}");
                        }

                        // Delete the file after successful processing
                        if (System.IO.File.Exists(filePath))
                        {
                            System.IO.File.Delete(filePath);
                        }
                        var reportSelection = await _dbContext.StocksUsas.Where(x => x != null).Select(x => x.Symbol).Distinct().ToListAsync();
                        var columns = typeof(StocksUsa).GetProperties().Select(x => x.Name).ToList();
                        var data = new UploadFileResponseModel
                        {
                            ReportSelections = reportSelection.ToList(),
                            Columns = columns.ToList(),
                            Message="File uploaded successfully!"
                        };
                        return data;
                    }
                }
            }
            catch (Exception ex)
            {
                // If there's an exception, make sure to delete the file
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }
                throw ex;
            }
        }

        public async Task<List<dynamic>> GetReportsAsync(List<string> reportSelection, DateTime? fromDate, DateTime? toDate, List<string> columns)
        {
            try
            {
                // Start with the base SQL query
                var sqlQuery = new StringBuilder("SELECT * FROM StocksUSARowBased");

                // Initialize a list to hold conditions
                var conditions = new List<string>();

                // Add report selection condition if provided
                if (reportSelection != null && reportSelection.Count > 0)
                {
                    conditions.Add($"Symbol IN ({string.Join(", ", reportSelection.Select(item => $"'{item}'"))})");
                }

                // Add date conditions if provided
                if (fromDate.HasValue)
                {
                    conditions.Add($"DATE >= '{fromDate.Value.ToString("yyyy-MM-dd")}'");
                }

                if (toDate.HasValue)
                {
                    conditions.Add($"DATE <= '{toDate.Value.ToString("yyyy-MM-dd")}'");
                }

                // Append WHERE clause if there are any conditions
                if (conditions.Count > 0)
                {
                    sqlQuery.Append(" WHERE " + string.Join(" AND ", conditions));
                }

                // Execute the raw SQL query
                var data = _dbContext.StocksUsas
                    .FromSqlRaw(sqlQuery.ToString())
                    .AsEnumerable() // Load data into memory to allow dynamic property selection
                    .Select(s =>
                    {
                        dynamic expando = new ExpandoObject();
                        var expandoDict = (IDictionary<string, object>)expando;

                        // Get the properties of the StocksUsa entity
                        var properties = typeof(StocksUsa).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                        // Loop through the properties and add only requested columns
                        foreach (var column in (columns != null && columns.Any() ? columns : properties.Select(p => p.Name))) // If columns is null, return all columns
                        {
                            var property = properties.FirstOrDefault(p => p.Name.Equals(column, StringComparison.OrdinalIgnoreCase));
                            if (property != null)
                            {
                                expandoDict[column.ToLower()] = property.GetValue(s);
                            }
                        }

                        return expando;
                    })
                    .ToList();

                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
