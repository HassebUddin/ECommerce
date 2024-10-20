namespace ECommerce.Domain.ViewModel.Request.Web
{
    public class ActionRequest
    {
        public string Code { get; set; } = null!;
        public string HttpType { get; set; } = null!;
        public string ActionType { get; set; } = null!;
        public string Definition { get; set; } = null!;

    }
}
