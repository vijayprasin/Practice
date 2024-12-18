namespace StockReport.Server.RequestModels
{
    public class DataLoaderReqModel
    {
        public string Country { get; set; }
        public string Database { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public string TableType { get; set; }
        public IFormFile UploadedFile { get; set; }
    }
}
