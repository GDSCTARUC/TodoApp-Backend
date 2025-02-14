﻿using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Infrastructure.Requests;

public class UserLoginRequest
{
    [Required] public string Username { get; set; }

    [Required] public string Password { get; set; }

    public string ReturnUrl { get; set; }
}