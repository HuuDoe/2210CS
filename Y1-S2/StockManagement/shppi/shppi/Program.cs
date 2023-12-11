using System;
using System.Collections.Generic;
namespace shppi
{
    internal class Program
    {
        
        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        class ShoppingCartItem
        {
            public Product Product { get; set; }
            public int Quantity { get; set; }
        }

        class ShoppingCart
        {
            private List<ShoppingCartItem> items;

            public ShoppingCart()
            {
                items = new List<ShoppingCartItem>();
            }

            public void AddItem(Product product, int quantity)
            {
                ShoppingCartItem existingItem = items.Find(item => item.Product.Id == product.Id);

                if (existingItem != null)
                {
                    existingItem.Quantity += quantity;
                }
                else
                {
                    ShoppingCartItem newItem = new ShoppingCartItem
                    {
                        Product = product,
                        Quantity = quantity
                    };
                    items.Add(newItem);
                }

                Console.WriteLine("Item added to the shopping cart.");
            }

            public void RemoveItem(Product product)
            {
                ShoppingCartItem itemToRemove = items.Find(item => item.Product.Id == product.Id);

                if (itemToRemove != null)
                {
                    items.Remove(itemToRemove);
                    Console.WriteLine("Item removed from the shopping cart.");
                }
                else
                {
                    Console.WriteLine("Item not found in the shopping cart.");
                }
            }

            public void DisplayItems()
            {
                Console.WriteLine("Shopping Cart Items:");
                foreach (var item in items)
                {
                    Console.WriteLine($"Product: {item.Product.Name}, Quantity: {item.Quantity}, Price: {item.Product.Price}");
                }
            }

            public decimal CalculateTotal()
            {
                decimal total = 0;

                foreach (var item in items)
                {
                    total += item.Product.Price * item.Quantity;
                }

                return total;
            }
        }

        static void Main(string[] args)
        {
            // Create some products
            Product product1 = new Product { Id = 1, Name = "Product 1", Price = 10.99m };
            Product product2 = new Product { Id = 2, Name = "Product 2", Price = 5.99m };
            Product product3 = new Product { Id = 3, Name = "Product 3", Price = 7.49m };

            // Create a shopping cart
            ShoppingCart cart = new ShoppingCart();

            // Add items to the cart
            cart.AddItem(product1, 2);
            cart.AddItem(product2, 1);
            cart.AddItem(product3, 3);

            // Display the items in the cart
            cart.DisplayItems();

            // Calculate the total price
            decimal total = cart.CalculateTotal();
            Console.WriteLine($"Total: {total}");

            // Remove an item from the cart
            cart.RemoveItem(product2);

            // Display the updated items in the cart
            cart.DisplayItems();

            // Calculate the updated total price
            total = cart.CalculateTotal();
            Console.WriteLine($"Total: {total}");

            Console.ReadLine();
        }
    }

        
}