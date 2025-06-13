using System.ComponentModel.DataAnnotations;

namespace EventManagement.Models
{
    public class Events
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public string Location { get; set; } = string.Empty;

        // Link to the organizer who created the event
        //[Required]
        //public string OrganizerUserId { get; set; } = string.Empty;

        // Optional navigation property for the organizer (if you have a User class)
        // public ApplicationUser? Organizer { get; set; }

        public bool IsCancelled { get; set; } = false; // new property for cancellation
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();

     
    }
}
