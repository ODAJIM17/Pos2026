using System.ComponentModel.DataAnnotations;

namespace POS.Shared.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        [MaxLength(30, ErrorMessage = "Field {0} can not exceed {1} characters")]
        [Required(ErrorMessage = "{0} is required.")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Description")]
        [MaxLength(50, ErrorMessage = "Field {0} can not exceed {1} characters")]
        [Required(ErrorMessage = "{0} is required.")]
        public string Description { get; set; } = string.Empty;
    }
}