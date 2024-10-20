

using ECommerce.Domain.BaseEntities;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entity.Web
{
    public class TimeSlot:BaseEntity
    {
 
   
        public DateTime ReservationDay { get; set; }
        public string MealType { get; set; } = null!;
        public string TableStatus { get; set; } = null!;



        public string? DinnerTableId { get; set; }
        public  DinnerTable DinnerTable { get; set; } = null!;

        public  ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
