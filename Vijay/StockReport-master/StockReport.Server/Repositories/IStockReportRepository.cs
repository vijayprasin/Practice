using StockReport.Server.Models;
using StockReport.Server.RequestModels;
using StockReport.Server.ResponseModels;

namespace StockReport.Server.Repositories
{
    public interface IStockReportRepository
    {
        Task<UploadFileResponseModel> GetDistinctSymbolsAsync(DataLoaderReqModel request);
        Task<List<dynamic>> GetReportsAsync(List<string> reportSelection, DateTime? fromDate, DateTime? toDate, List<string> columns);
    }
}
