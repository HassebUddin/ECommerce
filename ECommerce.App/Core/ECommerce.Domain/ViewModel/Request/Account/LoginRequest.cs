﻿namespace ECommerce.Domain.ViewModel.Request.Account
{
    public class LoginRequest
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool RememberMe { get; set; } = false;
    }
}
