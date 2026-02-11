using System.ComponentModel.DataAnnotations;

namespace POS.Shared.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Code { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        [Display(Name = "Description")]
        [MaxLength(50, ErrorMessage = "Field {0} can not exceed {1} characters")]
        [Required(ErrorMessage = "{0} is required.")]
        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }
        public int CurrentStock { get; set; }
        public int StockMinimun { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
        public bool IsActive { get; set; } = true;

        public string ImageUrl { get; set; } = string.Empty;
    }
}