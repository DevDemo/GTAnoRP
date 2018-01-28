using System.ComponentModel.DataAnnotations;

namespace GTAnoRP.WEB.Models.AccountViewModel
{
    public class LoginViewModel
    {
        [Display(Name = "Email")]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }

        [Required]
        public bool RememberMe { get; set; }

    }
}
