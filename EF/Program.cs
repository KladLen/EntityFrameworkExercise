using Pizza.Data;
using Pizza.Models;

using EFContext context = new EFContext();

Product pepperoni = new Product()
{
    Name = "Pepperoni",
    Price = 9.25M
};
context.Products.Add(pepperoni);
context.SaveChanges();