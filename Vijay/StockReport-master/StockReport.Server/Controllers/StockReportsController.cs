using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using StockReport.Server.Models;
using StockReport.Server.Repositories;
using StockReport.Server.RequestModels;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockReport.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockReportsController : ControllerBase
    {
        private readonly MyAppDbContext _dbContext;
        private readonly IStockReportRepository _stockReportRepository;

        public StockReportsController(MyAppDbContext context, IStockReportRepository stockReportRepository)
        {
            _dbContext = context;
            _stockReportRepository = stockReportRepository;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadStockReport([FromForm] DataLoaderReqModel request)
        {
            try
            {
                var uploadFileResponse= await _stockReportRepository.GetDistinctSymbolsAsync(request);
                return Ok(uploadFileResponse);
            }
            catch (Exception ex)
            {
                // Return the error message
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpGet("reports")]
        public async Task<ActionResult<IEnumerable<object>>> GetReports(
                        [FromQuery] List<string> reportSelection,
                        [FromQuery] DateTime? fromDate,
                        [FromQuery] DateTime? toDate,
                        [FromQuery] List<string> columns)
        {
            try
            {
                var reports= await _stockReportRepository.GetReportsAsync(reportSelection, fromDate, toDate, columns);
                return Ok(reports);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
