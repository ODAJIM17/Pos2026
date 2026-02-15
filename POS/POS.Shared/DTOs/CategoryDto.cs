using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POS.Shared.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }

    public class CreateCategory
    {
        [Display(Name = "Category")]
        [MaxLength(30, ErrorMessage = "Field {0} can not exceed {1} characters")]
        [Required(ErrorMessage = "{0} is required.")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Description")]
        [MaxLength(50, ErrorMessage = "Field {0} can not exceed {1} characters")]
        [Required(ErrorMessage = "{0} is required.")]
        public string Description { get; set; } = string.Empty;
    }

    public class EditCatgory
    {
        [Display(Name = "Category")]
        [MaxLength(30, ErrorMessage = "Field {0} can not exceed {1} characters")]
        [Required(ErrorMessage = "{0} is required.")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Description")]
        [MaxLength(50, ErrorMessage = "Field {0} can not exceed {1} characters")]
        [Required(ErrorMessage = "{0} is required.")]
        public string Description { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}