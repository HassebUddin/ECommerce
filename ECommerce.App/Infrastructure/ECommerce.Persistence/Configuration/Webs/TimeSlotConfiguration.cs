
using ECommerce.Domain.Entity.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ECommerce.Persistence.Configuration.Webs
{
    public class TimeSlotConfiguration : IEntityTypeConfiguration<TimeSlot>
    {
        public void Configure(EntityTypeBuilder<TimeSlot> builder)
        {
            builder.HasData(
           new TimeSlot { Id = "1g1h1i1j-1k1l-1m1n-1o1p-1q1r1s1t1u1", ReservationDay = DateTime.Today, MealType = "Dinner", TableStatus = "Available", DinnerTableId = "1e1f1g1h-1i1j-1k1l-1m1n-1o1p1q1r1s1" },
           new TimeSlot { Id = "2g2h2i2j-2k2l-2m2n-2o2p-2q2r2s2t2u2", ReservationDay = DateTime.Today.AddDays(1), MealType = "Lunch", TableStatus = "Reserved", DinnerTableId = "2e2f2g2h-2i2j-2k2l-2m2n-2o2p2q2r2s2" },
           new TimeSlot { Id = "3g3h3i3j-3k3l-3m3n-3o3p-3q3r3s3t3u3", ReservationDay = DateTime.Today, MealType = "Brunch", TableStatus = "Available", DinnerTableId = "3e3f3g3h-3i3j-3k3l-3m3n-3o3p3q3r3s3" },
           new TimeSlot { Id = "4g4h4i4j-4k4l-4m4n-4o4p-4q4r4s4t4u4", ReservationDay = DateTime.Today.AddDays(1), MealType = "Dinner", TableStatus = "Reserved", DinnerTableId = "4e4f4g4h-4i4j-4k4l-4m4n-4o4p4q4r4s4" },
           new TimeSlot { Id = "5g5h5i5j-5k5l-5m5n-5o5p-5q5r5s5t5u5", ReservationDay = DateTime.Today.AddDays(2), MealType = "Breakfast", TableStatus = "Available", DinnerTableId = "5e5f5g5h-5i5j-5k5l-5m5n-5o5p5q5r5s5" },
           new TimeSlot { Id = "6g6h6i6j-6k6l-6m6n-6o6p-6q6r6s6t6u6", ReservationDay = DateTime.Today.AddDays(2), MealType = "Lunch", TableStatus = "Reserved", DinnerTableId = "6e6f6g6h-6i6j-6k6l-6m6n-6o6p6q6r6s6" },
           new TimeSlot { Id = "7g7h7i7j-7k7l-7m7n-7o7p-7q7r7s7t7u7", ReservationDay = DateTime.Today.AddDays(3), MealType = "Dinner", TableStatus = "Available", DinnerTableId = "7e7f7g7h-7i7j-7k7l-7m7n-7o7p7q7r7s7" },
           new TimeSlot { Id = "8g8h8i8j-8k8l-8m8n-8o8p-8q8r8s8t8u8", ReservationDay = DateTime.Today.AddDays(3), MealType = "Brunch", TableStatus = "Reserved", DinnerTableId = "8e8f8g8h-8i8j-8k8l-8m8n-8o8p8q8r8s8" }
       );

        }
    }
}
