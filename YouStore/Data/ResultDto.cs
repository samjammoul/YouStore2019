namespace Data
{
    public class ResultDto<TObject>
    {
        public TObject Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
