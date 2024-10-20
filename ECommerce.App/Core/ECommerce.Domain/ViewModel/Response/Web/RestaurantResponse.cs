namespace ECommerce.Domain.ViewModel.Response.Web
{
    public class RestaurantResponse
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? ImageUrl { get; set; }

        public List<RestaurantBranchResponse> RestaurantBranches { get; set; } = new List<RestaurantBranchResponse>();
    }
}
