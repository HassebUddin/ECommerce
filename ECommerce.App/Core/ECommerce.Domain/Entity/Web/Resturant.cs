

using ECommerce.Domain.BaseEntities;
namespace ECommerce.Domain.Entity.Web
{
    public class Resturant:BaseEntity
    {
        

        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? ImageUrl { get; set; }



        public  ICollection<RestaurantBranch> RestaurantBranches { get; set; } = new List<RestaurantBranch>();
    }
}
