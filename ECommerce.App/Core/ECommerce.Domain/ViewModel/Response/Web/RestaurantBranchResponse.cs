namespace ECommerce.Domain.ViewModel.Response.Web
{
    public class RestaurantBranchResponse
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? ImageUrl { get; set; }


        public string RestaurantId { get; set; } = null!;


    }
}
