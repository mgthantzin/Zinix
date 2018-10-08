using System.ComponentModel.DataAnnotations;

namespace Zinix.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}