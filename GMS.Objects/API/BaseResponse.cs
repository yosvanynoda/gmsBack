namespace GMS.Objects.API
{
    public class BaseResponse
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public int StatusCode { get; set; }

        public object? Data { get; set; }

        public BaseResponse()
        {
            Success = false;
            Message = string.Empty;
            StatusCode = 0;
        }
    }
}
