using POS.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace POS.Shared.DTOs
{
    public class RegisterRequest
    {
        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MinLength(6)]
        public string Password { get; set; } = string.Empty;

        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = string.Empty;

        public Role Role { get; set; } = Role.Admin;
    }
}