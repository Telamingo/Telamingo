﻿namespace Telamingo.Domain.Dtos.User;

public class UserDto
{
    public int Id { get; set; }
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
