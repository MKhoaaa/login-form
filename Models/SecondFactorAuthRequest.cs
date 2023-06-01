﻿using System.ComponentModel.DataAnnotations;

namespace LoginForm.Models
{
    public class SecondFactorAuthRequest
    {
        public string? UserName { get; set; }

        public string? QrCode { get; set; }

        [Required]
        public string Totp { get; set; } = null!;
    }
}
