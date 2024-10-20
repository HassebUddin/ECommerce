using ECommerce.Domain.Entity.Identity;

namespace ECommerce.Domain.Entity.File
{
    public class UserImage : Image
    {
        public bool ShowCase { get; set; } = false;


        public string UserId { get; set; } = null!;
        public AppUser User { get; set; } = null!;
    }
}
