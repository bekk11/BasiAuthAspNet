﻿namespace BasicAuthenticationApp.Domain.Entities;

public class User
{
    public long Id { get; set; }
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
}