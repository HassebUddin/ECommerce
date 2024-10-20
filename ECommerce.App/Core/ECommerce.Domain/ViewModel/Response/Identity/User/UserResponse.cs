
namespace ECommerce.Domain.ViewModel.Response.Identity.User
{
    public class UserResponse
    {
        public string Id { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public bool Status { get; set; } = true;
        public string Address { get; set; } = null!;
        public string Image { get; set; } = null!;


        public string Profession { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;


        public string Email { get; set; } = null!;
    
    }
}
