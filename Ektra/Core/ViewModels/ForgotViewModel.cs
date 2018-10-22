using System.ComponentModel.DataAnnotations;

namespace Ektra.Core.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}