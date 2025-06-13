using System.ComponentModel.DataAnnotations;

namespace EventManagement.Models.ViewModels
{
    public class ContactViewModel
    {

        [Required(ErrorMessage = "Your email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage ="Subject is required")]
        [MinLength(5, ErrorMessage ="Subject must be atleast 5 characters")]
        public string Subject {get; set; } = string.Empty ;

        [Required(ErrorMessage = "Message is required")]
        [MinLength(5, ErrorMessage = "Message must be at least 5 characters")]
        public string Message { get; set; } = string.Empty;
    }
}
