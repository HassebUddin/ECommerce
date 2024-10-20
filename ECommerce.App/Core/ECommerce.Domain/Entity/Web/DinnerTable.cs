

using ECommerce.Domain.BaseEntities;

namespace ECommerce.Domain.Entity.Web
{
    public class DinnerTable:BaseEntity
    {
     
        public string? TableName { get; set; }
        public int Capacity { get; set; }


        public string RestaurantBranchId { get; set; } = null!;
        public virtual RestaurantBranch Branch { get; set; } = null!;


        public  ICollection<TimeSlot> TimeSlots { get; set; } = new List<TimeSlot>();
    }
}
