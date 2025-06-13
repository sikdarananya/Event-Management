using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagement.Models
{
    [Table("user_accounts")]
    public class UserAccounts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("user_name")]
        [MaxLength(1000)]
        public string UserName { get; set; }

        [Column("password")]
        [MaxLength(100)]

        public string Password { get; set; }

        [Column("role")]
        [MaxLength(100)]

        public string Role { get; set; }


    }
}
