

using ECommerce.Domain.BaseEntities;
using ECommerce.Domain.Entity.Identity;

namespace ECommerce.Domain.Entity.Web
{
    public class Reservation:BaseEntity
    {


        public DateTime ReservationDate { get; set; }
        public string ReservationStatus { get; set; } = null!;
        public bool ReminderSent { get; set; } = false;


        public string TimeSlotId { get; set; } = null!;
        public  TimeSlot TimeSlot { get; set; } = null!;


        public string UserId { get; set; } = null!;
        public  AppUser User { get; set; } = null!;

    }
}
