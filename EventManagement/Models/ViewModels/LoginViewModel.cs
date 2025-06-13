using System.ComponentModel.DataAnnotations;

namespace EventManagement.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide User")]
        public string? UserName { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage = "Please provide password")]

        public string? Password { get; set; }

    }
}
