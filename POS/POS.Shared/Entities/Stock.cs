using POS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Text;

namespace POS.Shared.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public DateTime MovementDate { get; set; }
        public MovementType MovementType { get; set; }
        public int Quantity { get; set; }

        [MaxLength(50, ErrorMessage = "Field {0} can not exceed {1} characters")]
        public string? Notes { get; set; }

        public User User { get; set; } = null!;
        public int UserId { get; set; }
    }
}