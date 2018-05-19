using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace BethanyPieShop.Models
{
    public class Feedback
    {
        [BindNever]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Email address can not be more than 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Your Email address is required")]
        [StringLength(100, ErrorMessage = "Email address can not be more than 100 characters")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "The email address is not entered in a correct format")]
        public string Email { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Email address can not be more than 500 characters")]
        public string Message { get; set; }

        public bool AllowContactMe { get; set; }
    }
}
