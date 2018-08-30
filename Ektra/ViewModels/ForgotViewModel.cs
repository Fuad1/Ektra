using System.ComponentModel.DataAnnotations;

namespace Ektra.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}