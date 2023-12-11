using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace StockManagement
{
    class Program
    {
        private static StockManager stckManager= new StockManager();
        private static  TransactionManager transManager= new TransactionManager();
        private static  AdminUI adminUI = new AdminUI(stckManager,transManager);

        private const int VIEW_ALL_STOCKITEMS = 1;
        private const int VIEW_ALL_TRANSACTIONS = 2;
        private const int EXIT = 0;


        public static void Main(string[] args) {
            DisplayMenu();
            AddANewItemOfStock();
            int choice = ReadInteger("Option: > ");

            while (choice != EXIT)
            {
                switch (choice)
                {
                    case VIEW_ALL_STOCKITEMS:
                        ViewStockLevels();
                        break;
                    case VIEW_ALL_TRANSACTIONS:
                        ViewTransactionLog();
                        break;

                    default:
                        Console.WriteLine("\nERROR: Option not recognised. Please try again.");
                        break;
                }
                DisplayMenu();
                choice = ReadInteger("Option: > ");
            }

        }

        
        private static void DisplayMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine(VIEW_ALL_STOCKITEMS + " .View all stock items");
            Console.WriteLine(VIEW_ALL_TRANSACTIONS + " .View all transaction");
           
            Console.WriteLine(EXIT + " .Exit");
            Console.WriteLine("\n");
            
        }

        public static void DisplayResults( string[] results)
        {
            
            // Code to display the results
        }

        public static int ReadInteger(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }

        public string ReadString(string prompt)
        {
           return prompt;
        }
    
        
        private static void AddANewItemOfStock()
        {
            // Code to add a new item of stock
            adminUI.AddANewItemOfStock(1, "pen", 3);
        }

        private static void AddQuantityToAStockItem()
        {
            // Code to add quantity to a stock item
        }

        private static void DeleteAStockItem()
        {
            // Code to delete a stock item
        }

        private static void RemoveQuantityFromAStockItem()
        {
            // Code to remove quantity from a stock item
        }

        private static void ViewStockLevels()
        {
//            adminUI.ViewStockLevels();
            List<string> listOfItem = adminUI.ViewStockLevels();
            foreach (var item in listOfItem)
            {
                Console.WriteLine(item);
            }
        }

        private static void ViewTransactionLog()
        {
            List<string> listOfTransac =adminUI.ViewTransactionLog();
            foreach (var transac in listOfTransac)
            {
                Console.WriteLine(transac);
            }
            
            // Code to view the transaction log
        }
    }
}
