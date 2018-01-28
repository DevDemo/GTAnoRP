using System.ComponentModel.DataAnnotations;

namespace GTAnoRP.WEB.Models.AccountViewModel
{
    public class RegisterViewModel
    {
        [Display(Name = "Email")]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }

        [Display(Name = "Repeat your password")]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

    }
}
