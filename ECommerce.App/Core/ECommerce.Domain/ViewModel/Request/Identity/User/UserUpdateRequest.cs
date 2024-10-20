namespace ECommerce.Domain.ViewModel.Request.Identity.User
{
    public class UserUpdateRequest
    {
        public string Id { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public bool Status { get; set; } = true;
        public string Address { get; set; } = null!;
        public string Image { get; set; } = null!;
        public bool TwoFactorEnabled { get; set; } = true;



        public string Profession { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;




        public string Email { get; set; } = null!;
    }
}
