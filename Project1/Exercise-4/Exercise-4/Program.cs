using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice_4.Models
{
    internal class Product
    {
        public Product()
        {
            Id = Guid.NewGuid();
        }

        public Product(string name, string description, decimal price, int quantityInStock)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

        public string ShortDescription => (Description.Length > 30) ? $"{Description.Substring(0, 30)}..." : Description;
    }
}

/*  
    1020673, Andersson ARC 1.5 - Andersson ARC 1.5 hjälper dig hålla en ...
 
*/ 