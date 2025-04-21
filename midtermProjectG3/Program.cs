using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagementSystem
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static List<Product> productList = new List<Product>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                
                bannerHead();
                mainMenu();

                // For selection option
                Console.Write("\nEnter your option: ");
                char Option = Convert.ToChar(Console.ReadLine());

                switch (Option)
                {
                    case '1': // Add a new product
                        Console.Clear();
                        bannerHead();
                        AddProduct();
                        Thread.Sleep(1000);
                        Console.WriteLine( "\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case '2': // Display all products
                        Console.Clear();
                        bannerHead();
                        Thread.Sleep(1000);
                        DisplayProducts();
                        Console.WriteLine( "\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case '3': // Search for a product by Product ID
                        Console.Clear();
                        bannerHead();
                        Thread.Sleep(1000);
                        SearchProduct();
                        Console.WriteLine( "\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case '4': // Update product information
                        Console.Clear();
                        bannerHead();
                        Thread.Sleep(1000);
                        UpdateProduct();
                        Console.WriteLine( "\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case '5': // Delete a product
                        Console.Clear();
                        bannerHead();
                        Thread.Sleep(1000);
                        DeleteProduct();
                        Console.WriteLine( "\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case '6': // Exit the system
                        Console.Clear();
                        bannerHead();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Thanks for using S.I.M.S!");
                        running = false;
                        break;
                    default:
                        Console.Clear();
                        bannerHead();
                        Console.WriteLine(@"Invalid option. Try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void mainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string[] menuItems = new string[]
            {
                "1. Add a new product",
                "2. Display all products",
                "3. Search for a product by Product ID",
                "4. Update product information",
                "5. Delete a product",
                "6. Exit the system"
            };
            for (int i = 0; i < menuItems.Length; i += 2)
            {
                string LeftColumn = menuItems[i];
                string RightColumn = (i + 1 < menuItems.Length) ? menuItems[i + 1] : "";

                Console.WriteLine("{0,-40} {1}", LeftColumn, RightColumn);
            }
        }

        public static void bannerHead()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
                              ____               
  .--.--.      ,---,        ,'  , `.  .--.--.    
 /  /    '. ,`--.' |     ,-+-,.' _ | /  /    '.  
|  :  /`. / |   :  :  ,-+-. ;   , |||  :  /`. /  
;  |  |--`  :   |  ' ,--.'|'   |  ;|;  |  |--`   
|  :  ;_    |   :  ||   |  ,', |  ':|  :  ;_     
 \  \    `. '   '  ;|   | /  | |  || \  \    `.  
  `----.   \|   |  |'   | :  | :  |,  `----.   \ 
  __ \  \  |'   :  ;;   . |  ; |--'   __ \  \  | 
 /  /`--'  /|   |  '|   : |  | ,     /  /`--'  / 
'--'.     / '   :  ||   : '  |/     '--'.     /  
  `--'---'  ;   |.' ;   | |`-'        `--'---'   
            '---'   |   ;/                       
                    '---'                        
------------------------------------------------                                                 
Simple Inventory Management System
");
            Console.ResetColor();
        }

        public static void AddProduct()
        {
            Product product = new Product();

            Console.Write("Enter Product ID: ");
            product.ProductID = Convert.ToInt32(Console.ReadLine());

            // Check if ID already exists
            if (productList.Any(p => p.ProductID == product.ProductID))
            {
                Console.WriteLine("Product with this ID already exists!");
                return;
            }

            Console.Write("Enter Product Name: ");
            product.ProductName = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            product.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price: ");
            product.Price = Convert.ToDecimal(Console.ReadLine());

            productList.Add(product);
            Console.WriteLine("Product added successfully!");
        }

        public static void DisplayProducts()
        {
            if (productList.Count == 0)
            {
                Console.WriteLine("No products to display.");
                return;
            }

            Console.WriteLine("\n--- Product List ---");
            foreach (var product in productList)
            {
                Console.WriteLine($"ID: {product.ProductID}, Name: {product.ProductName}, Quantity: {product.Quantity}, Price: {product.Price:C}");
            }
        }

        public static void SearchProduct()
        {
            Console.Write("Enter Product ID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var product = productList.FirstOrDefault(p => p.ProductID == id);

            if (product != null)
            {
                Console.WriteLine($"Found: ID: {product.ProductID}, Name: {product.ProductName}, Quantity: {product.Quantity}, Price: {product.Price:C}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public static void UpdateProduct()
        {
            Console.Write("Enter Product ID to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var product = productList.FirstOrDefault(p => p.ProductID == id);

            if (product != null)
            {
                Console.Write("Enter new Product Name: ");
                product.ProductName = Console.ReadLine();

                Console.Write("Enter new Quantity: ");
                product.Quantity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter new Price: ");
                product.Price = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public static void DeleteProduct()
        {
            Console.Write("Enter Product ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var product = productList.FirstOrDefault(p => p.ProductID == id);

            if (product != null)
            {
                productList.Remove(product);
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}
