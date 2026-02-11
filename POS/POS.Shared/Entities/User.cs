using POS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Shared.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        public Role Role { get; set; }
        public bool IsActive { get; set; } = true;
    }
}