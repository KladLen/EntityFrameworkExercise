using Pizza.Data;
using Pizza.Models;

using EFContext context = new EFContext();

Product pizza = new Product();
//pizza.addProduct("Diavola", 20M);

pizza.updatePrice("Funghi", 9.99M);
//updatePrice("Pepperoni", 8.99M);

//var products = context.Products.Where(p => p.Price < 9M).OrderBy(p => p.Price);
var products = from product in context.Products
               where product.Price > 9M
               orderby product.Name
               select product;

foreach (var p in products)
{
    Console.WriteLine(p.Name + " - " + p.Price.ToString());
}

/*
static void addProduct(string name, decimal price)
{
    using EFContext context = new EFContext();
    Product product = new Product()
    {
        Name = name,
        Price = price
    };
    context.Products.Add(product);
    context.SaveChanges();
}

static void deleteProductById(int id)
{
    using EFContext contex = new EFContext();
    Product product = new Product()
    { Id = id };
    contex.Products.Attach(product);
    contex.Products.Remove(product);
    contex.SaveChanges();
}

static void updatePrice(string name, decimal price)
{
    using EFContext context = new EFContext();
    var pizza = context.Products.Where(p => p.Name == name).FirstOrDefault();
    if (pizza is Product)
    {
        pizza.Price = price;
    }
    else
    {
        Console.WriteLine($"Pizza with name {name} doesn't exist in database.");
    }
    context.SaveChanges();
}*/