using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace midtermProjG3
{
    public class Program
    {

        public class Product
        {
            public int productId { get; set;}
            public string? productName { get; set;}
            public int Quantity { get; set;}
            public decimal Price { get; set;}

        }

        static List<Product> products = new List<Product>();


        public static void Main(string[] args)
        {
            Console.Title = "Simple Inventory Management System";


            while (true)
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

                        break;
                    case '2': // Display all products
                    
                        break;
                    case '3': // Search for a product by Product ID
                    
                        break;
                    case '4': // Update product information
                    
                        break;
                    case '5': // Delete a product
                    
                        break;

                    case '6': // Exit the system
                        Console.Clear();
                        System.Console.WriteLine("Thanks for using S.I.M.S!");
                        return;
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
            System.Console.WriteLine(@"
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

        public static void addNewProduct()
        {

        }
    }
}