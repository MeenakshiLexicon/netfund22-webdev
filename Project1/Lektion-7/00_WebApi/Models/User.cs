using System.ComponentModel.DataAnnotations;

namespace _00_WebApi.Models
{
    public class User
    { 
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; } = null!;
        [Required]
        public string Email{ get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
