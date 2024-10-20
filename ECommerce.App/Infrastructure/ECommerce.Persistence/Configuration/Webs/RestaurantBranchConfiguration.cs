

using ECommerce.Domain.Entity.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Persistence.Configuration.Webs
{
    public class RestaurantBranchConfiguration : IEntityTypeConfiguration<RestaurantBranch>
    {
        public void Configure(EntityTypeBuilder<RestaurantBranch> builder)
        {
            builder.HasData(
            new RestaurantBranch { Id = "1a1b1c1d-1e1f-1g1h-1i1j-1k1l1m1n1o1", Name = "Branch A1", Address = "111 Branch St, City, Country", Phone = "321-654-9870", Email = "branchA1@restaurantA.com", ImageUrl = "https://images.unsplash.com/photo-1589927986089-3581237894a4", RestaurantId = "1a2b3c4d-5e6f-7g8h-9i0j-k1l2m3n4o5p6" },
            new RestaurantBranch { Id = "2a2b2c2d-2e2f-2g2h-2i2j-2k2l2m2n2o2", Name = "Branch A2", Address = "112 Branch St, City, Country", Phone = "321-654-9871", Email = "branchA2@restaurantA.com", ImageUrl = "https://images.unsplash.com/photo-1610515162442-19625d0548c7", RestaurantId = "1a2b3c4d-5e6f-7g8h-9i0j-k1l2m3n4o5p6" },
            new RestaurantBranch { Id = "3a3b3c3d-3e3f-3g3h-3i3j-3k3l3m3n3o3", Name = "Branch B1", Address = "222 Branch St, City, Country", Phone = "654-321-9870", Email = "branchB1@restaurantB.com", ImageUrl = "https://images.unsplash.com/photo-1543353071-6e0ffebc1b68", RestaurantId = "2b3c4d5e-6f7g-8h9i-0j1k-2l3m4n5o6p7q" },
            new RestaurantBranch { Id = "4a4b4c4d-4e4f-4g4h-4i4j-4k4l4m4n4o4", Name = "Branch B2", Address = "223 Branch St, City, Country", Phone = "654-321-9871", Email = "branchB2@restaurantB.com", ImageUrl = "https://images.unsplash.com/photo-1610515162442-19625d0548c7", RestaurantId = "2b3c4d5e-6f7g-8h9i-0j1k-2l3m4n5o6p7q" },
            new RestaurantBranch { Id = "5a5b5c5d-5e5f-5g5h-5i5j-5k5l5m5n5o5", Name = "Branch C1", Address = "333 Branch St, City, Country", Phone = "987-123-4560", Email = "branchC1@restaurantC.com", ImageUrl = "https://images.unsplash.com/photo-1610515162442-19625d0548c7", RestaurantId = "3c4d5e6f-7g8h-9i0j-k1l2-m3n4o5p6q7r" },
            new RestaurantBranch { Id = "6a6b6c6d-6e6f-6g6h-6i6j-6k6l6m6n6o6", Name = "Branch C2", Address = "334 Branch St, City, Country", Phone = "987-123-4561", Email = "branchC2@restaurantC.com", ImageUrl = "https://images.unsplash.com/photo-1610515162442-19625d0548c7", RestaurantId = "3c4d5e6f-7g8h-9i0j-k1l2-m3n4o5p6q7r" },
            new RestaurantBranch { Id = "7a7b7c7d-7e7f-7g7h-7i7j-7k7l7m7n7o7", Name = "Branch D1", Address = "444 Branch St, City, Country", Phone = "789-456-1230", Email = "branchD1@restaurantD.com", ImageUrl = "https://images.unsplash.com/photo-1601758167934-ec10e43c9c16", RestaurantId = "4d5e6f7g-8h9i-0j1k-2l3m-4n5o6p7q8r9" },
            new RestaurantBranch { Id = "8a8b8c8d-8e8f-8g8h-8i8j-8k8l8m8n8o8", Name = "Branch D2", Address = "445 Branch St, City, Country", Phone = "789-456-1231", Email = "branchD2@restaurantD.com", ImageUrl = "https://images.unsplash.com/photo-1601758167934-ec10e43c9c16", RestaurantId = "4d5e6f7g-8h9i-0j1k-2l3m-4n5o6p7q8r9" }
        );
        }
    }
}
