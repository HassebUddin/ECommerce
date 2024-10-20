
using ECommerce.Domain.Entity.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ECommerce.Persistence.Configuration.Webs
{
    public class DinnerTableConfiguration : IEntityTypeConfiguration<DinnerTable>
    {
        public void Configure(EntityTypeBuilder<DinnerTable> builder)
        {
            builder.HasData(
            new DinnerTable { Id = "1e1f1g1h-1i1j-1k1l-1m1n-1o1p1q1r1s1", TableName = "Table 1", Capacity = 4, RestaurantBranchId = "1a1b1c1d-1e1f-1g1h-1i1j-1k1l1m1n1o1" },
            new DinnerTable { Id = "2e2f2g2h-2i2j-2k2l-2m2n-2o2p2q2r2s2", TableName = "Table 2", Capacity = 2, RestaurantBranchId = "2a2b2c2d-2e2f-2g2h-2i2j-2k2l2m2n2o2" },
            new DinnerTable { Id = "3e3f3g3h-3i3j-3k3l-3m3n-3o3p3q3r3s3", TableName = "Table 3", Capacity = 6, RestaurantBranchId = "3a3b3c3d-3e3f-3g3h-3i3j-3k3l3m3n3o3" },
            new DinnerTable { Id = "4e4f4g4h-4i4j-4k4l-4m4n-4o4p4q4r4s4", TableName = "Table 4", Capacity = 8, RestaurantBranchId = "4a4b4c4d-4e4f-4g4h-4i4j-4k4l4m4n4o4" },
            new DinnerTable { Id = "5e5f5g5h-5i5j-5k5l-5m5n-5o5p5q5r5s5", TableName = "Table 5", Capacity = 4, RestaurantBranchId = "5a5b5c5d-5e5f-5g5h-5i5j-5k5l5m5n5o5" },
            new DinnerTable { Id = "6e6f6g6h-6i6j-6k6l-6m6n-6o6p6q6r6s6", TableName = "Table 6", Capacity = 2, RestaurantBranchId = "6a6b6c6d-6e6f-6g6h-6i6j-6k6l6m6n6o6" },
            new DinnerTable { Id = "7e7f7g7h-7i7j-7k7l-7m7n-7o7p7q7r7s7", TableName = "Table 7", Capacity = 6, RestaurantBranchId = "7a7b7c7d-7e7f-7g7h-7i7j-7k7l7m7n7o7" },
            new DinnerTable { Id = "8e8f8g8h-8i8j-8k8l-8m8n-8o8p8q8r8s8", TableName = "Table 8", Capacity = 8, RestaurantBranchId = "8a8b8c8d-8e8f-8g8h-8i8j-8k8l8m8n8o8" }
        );
        }
    }
}
