namespace ECommerce.Domain.ViewModel.Request.Web
{
    public class MenuRequest
    {
        public string Name { get; set; } = null!;

        public List<ActionRequest> Actions { get; set; } = null!;
    }
}
