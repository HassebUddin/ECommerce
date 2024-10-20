

namespace ECommerce.Domain.Model
{
    public class ApiExceptionModel
    {
        public ApiExceptionModel(string message, int Status, string stackTrace = null!)
        {
            this.Message = message;
            this.StackTrace = stackTrace;
            this.Status = Status;

        }

        public string Message { get; set; } = null!;
        public int Status { get; set; }
        public string StackTrace { get; set; } = null!;
    }
}
