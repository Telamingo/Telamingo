﻿namespace BusinessLogic.Login.Dto
{
    public class LoginDto
    {
        public LoginDto(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}