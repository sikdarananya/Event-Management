using System.ComponentModel.DataAnnotations;

namespace EventManagement.Models.ViewModels
{
    public class RegisterViewModel
    {
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide User")]
        public string UserName { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide Password")]
        public string Password { get; set; } = string.Empty;

       
        public string Role { get; set; } = "User";
    }
}

