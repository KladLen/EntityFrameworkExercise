using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Pizza.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizza.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        public void addProduct(string name, decimal price)
        {
            using EFContext context = new EFContext();
            Name = name;
            Price = price;

            context.Products.Add(this);
            context.SaveChanges();
        }
    }
    
}
