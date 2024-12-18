namespace StockReport.Server.ResponseModels
{
    public class UploadFileResponseModel
    {
        public List<string> ReportSelections { get; set; }
        public List<string> Columns { get; set; }
        public string Message { get; set; }
    }
}
