

using ECommerce.Domain.Entity.Web;

namespace ECommerce.Domain.ViewModel.Response.Web
{
    public class DinnerTableResponse
    {


        public string BranchId { get; set; }
        public DateTime ReservationDay { get; set; }
        public string? TableName { get; set; }
        public int Capacity { get; set; }
        public string MealType { get; set; } = null!;
        public string TableStatus { get; set; } = null!;
        public string TimeSlotId { get; set; }
        public string? UserEmailId { get; set; }
    }
}
