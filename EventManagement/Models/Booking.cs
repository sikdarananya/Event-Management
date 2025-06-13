using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;


namespace EventManagement.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public int EventId { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        public DateTime BookingTime { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime OriginalEventStartTime { get; set; }  

        public Events? Event { get; set; }
    }
}
