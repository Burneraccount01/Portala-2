using System.ComponentModel.DataAnnotations;

namespace PorTala.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; }

        public string Role { get; set; }
    }
}