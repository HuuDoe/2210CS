using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Program
    {
        private static StockManager stckManager = new StockManager();
        private static TransactionManager transManager = new TransactionManager();
        private static AdminUI adminUI = new AdminUI(stckManager, transManager);

        private static void DisplayMenu()
        {
            
        }

        private static void DisplayResults( string[] results)
        {
            
            // Code to display the results
        }

        private static int ReadInteger(string prompt)
        {
            return int.Parse(prompt);
        }

        private static string ReadString(string prompt)
        {
           return prompt;
        }
    
        
        private static void AddANewItemOfStock()
        {
            // Code to add a new item of stock
            
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

        }

        private static void ViewTransactionLog()
        {
          
        }
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new stockManagementGUI());
        }
    }
}
