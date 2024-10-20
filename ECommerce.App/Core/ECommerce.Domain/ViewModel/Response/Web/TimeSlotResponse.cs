
using ECommerce.Domain.Entity.Web;

namespace ECommerce.Domain.ViewModel.Response.Web
{
    public class TimeSlotResponse
    {
        public string Id { get; set; } = null!;
        public DateTime ReservationDay { get; set; }
        public string MealType { get; set; } = null!;
        public string TableStatus { get; set; } = null!;



        public string? DinnerTableId { get; set; }
    
    }
}
