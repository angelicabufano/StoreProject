using System.Drawing;

namespace StoreProject;

internal class Program {
    static void Main(string[] args) {

        List<IProduct> products = new List<IProduct> {

        new Lipstick { ProductName = "Pink Lipstick", ProductPrice = 9.99m },
        new Lipstick { ProductName = "Red Lipstick", ProductPrice = 10.99m },
        new Blush { ProductName = "Pink Blush" , ProductPrice = 5.99m },
        new Blush { ProductName = "Red Blush", ProductPrice = 6.99m }
        };

        foreach(var product in products) {
            Console.WriteLine($"The price of {product.ProductName} is {product.ProductPrice:C}");
            
        }

    }
}
