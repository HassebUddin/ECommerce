using ECommerce.Domain.Entity.Identity;

namespace ECommerce.Domain.ViewModel.Request.Account
{
    public class RegisterRequest
    {

        public string FullName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public bool Status { get; set; } = true;
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        public bool TwoFactorEnabled { get; set; } = true;


        public string Profession { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;


     
    }
}
