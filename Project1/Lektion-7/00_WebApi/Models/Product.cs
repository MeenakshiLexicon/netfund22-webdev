using System.ComponentModel.DataAnnotations;

namespace _00_WebApi.Models
{
    public class Product
    {
       

        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string? Description{ get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
