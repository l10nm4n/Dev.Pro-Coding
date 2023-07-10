using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Mouse", Price = 20, Stock = 25 },
            new Product { Name = "Keyboard", Price = 80, Stock = 10 },
            new Product { Name = "Monitor", Price = 300, Stock = 20 },
            new Product { Name = "Pen drive", Price = 16, Stock = 30 },
        };

        string sortKey = "price";
        bool ascending = false;

        IEnumerable<Product> sortedProducts;

        switch (sortKey)
        {
            case "name":
                sortedProducts = ascending ? products.OrderBy(p => p.Name) : products.OrderByDescending(p => p.Name);
                break;
            case "price":
                sortedProducts = ascending ? products.OrderBy(p => p.Price) : products.OrderByDescending(p => p.Price);
                break;
            case "stock":
                sortedProducts = ascending ? products.OrderBy(p => p.Stock) : products.OrderByDescending(p => p.Stock);
                break;
            default:
                throw new ArgumentException("Invalid sort key.");
        }

        foreach (Product product in sortedProducts)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
    }
}
