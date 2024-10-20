

using ECommerce.Domain.Entity.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ECommerce.Persistence.Configuration.Webs
{
    public class RestaurantConfiguration : IEntityTypeConfiguration<Resturant>
    {
        public void Configure(EntityTypeBuilder<Resturant> builder)
        {
            builder.HasData(
            new Resturant { Id = "1a2b3c4d-5e6f-7g8h-9i0j-k1l2m3n4o5p6", Name = "Restaurant A", Address = "123 Main St, City, Country", Phone = "123-456-7890", Email = "info@restaurantA.com", ImageUrl = "https://images.unsplash.com/photo-1509021436668-719bce81c2d5" },
            new Resturant { Id = "2b3c4d5e-6f7g-8h9i-0j1k-2l3m4n5o6p7q", Name = "Restaurant B", Address = "456 Another St, City, Country", Phone = "987-654-3210", Email = "info@restaurantB.com", ImageUrl = "https://images.unsplash.com/photo-1609001743548-0c2028d6b8d2" },
            new Resturant { Id = "3c4d5e6f-7g8h-9i0j-k1l2-m3n4o5p6q7r", Name = "Restaurant C", Address = "789 Food St, City, Country", Phone = "555-0123-4567", Email = "info@restaurantC.com", ImageUrl = "https://images.unsplash.com/photo-1506794778163-1e31b24c0c66" },
            new Resturant { Id = "4d5e6f7g-8h9i-0j1k-2l3m-4n5o6p7q8r9", Name = "Restaurant D", Address = "101 Eatery Rd, City, Country", Phone = "654-321-0987", Email = "info@restaurantD.com", ImageUrl = "https://images.unsplash.com/photo-1604901400781-67d71e7b7248" },
            new Resturant { Id = "5e6f7g8h-9i0j-k1l2-m3n4-5o6p7q8r9s0", Name = "Restaurant E", Address = "202 Cuisine Ave, City, Country", Phone = "321-654-9870", Email = "info@restaurantE.com", ImageUrl = "https://images.unsplash.com/photo-1568673228748-bb43f3a5ebaf" },
            new Resturant { Id = "6f7g8h9i-0j1k-2l3m-4n5o-6p7q8r9s0t1", Name = "Restaurant F", Address = "303 Taste St, City, Country", Phone = "456-789-0123", Email = "info@restaurantF.com", ImageUrl = "https://images.unsplash.com/photo-1589927986089-3581237894a4" },
            new Resturant { Id = "7g8h9i0j-k1l2-m3n4-5o6p-7q8r9s0t1u2", Name = "Restaurant G", Address = "404 Flavor St, City, Country", Phone = "789-012-3456", Email = "info@restaurantG.com", ImageUrl = "https://images.unsplash.com/photo-1543353071-6e0ffebc1b68" },
            new Resturant { Id = "8h9i0j1k-2l3m-4n5o-6p7q-8r9s0t1u2v3", Name = "Restaurant H", Address = "505 Dish St, City, Country", Phone = "321-987-6543", Email = "info@restaurantH.com", ImageUrl = "https://images.unsplash.com/photo-1601758167934-ec10e43c9c16" }
        );
        }
    }
}
