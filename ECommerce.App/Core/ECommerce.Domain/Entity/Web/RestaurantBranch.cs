
using ECommerce.Domain.BaseEntities;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entity.Web
{
    public class RestaurantBranch:BaseEntity
    { 
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? ImageUrl { get; set; }

        
        public string RestaurantId { get; set; } = null!;
        public  Resturant Restaurant { get; set; } = null!;


        public ICollection<DinnerTable> DinnerTables { get; set; } = null!;// new List<DinnerTable>();


    }
}
