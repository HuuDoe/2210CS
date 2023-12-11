using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AdminUI
    {
        private StockManager stockMgr;
        private TransactionManager transactionMgr;
        public AdminUI(StockManager stkMgr, TransactionManager trMgr)
        {

            this.stockMgr = stkMgr;
            this.transactionMgr = trMgr;
        }

        public AdminUI()
        {
        }

        public List<string> AddANewItemOfStock(int code, string name, int quantityInStock)
        {
            List<string> addItemList = new List<string>();
            StockManager stockManager = this.stockMgr;
            TransactionManager transactionManager = this.transactionMgr;

            SortedDictionary<int, StockItem> stockItems = stockManager.GetAllStockItems();
            if (stockItems.ContainsKey(code))
            {
                addItemList.Add($"Item code {code} already exists. Item not added.");
            }
            else if (stockItems.ContainsKey(code) == false)
            {
                StockItem newItemToAdd = new StockItem(code, name, quantityInStock);
                stockManager.CreateStockItem(code, name, quantityInStock);
                transactionManager.RecordItemAdded(newItemToAdd);
                addItemList.Add($"Item added. Item code: {code}");
            }
            return addItemList;
        }
        public List<string> AddQuantityToAStockItem(int code, int quantityToAdd)
        {
            List<string> addQtyList = new List<string>();
            StockManager stockManager = this.stockMgr;
            TransactionManager transactionManager = this.transactionMgr;
            SortedDictionary<int, StockItem> stockItems = stockManager.GetAllStockItems();

            if (stockItems.ContainsKey(code) == false)
            {
                addQtyList.Add($"Stock item {code} not found. Quantity not added.");
            }
            else if (stockItems.ContainsKey(code) == true)
            {

                StockItem itemToAdd = stockManager.FindStockItem(code);
                stockManager.AddQuantityToStockItem(code, quantityToAdd);
                int newQtyInStock = itemToAdd.QuantityInStock;
                transactionManager.RecordQuantityAdded(itemToAdd, quantityToAdd);
                addQtyList.Add($"Quantity added to item: {code}. New quantity in stock: {newQtyInStock}");
            }

            return addQtyList;

        }
        public List<string> RemoveQuantityFromAStockItem(int code, int quantityToRemove)
        {
            List<string> removeQtyList = new List<string>();
            StockManager stockManager = this.stockMgr;
            TransactionManager transactionManager = this.transactionMgr;
            SortedDictionary<int, StockItem> stockItems = stockManager.GetAllStockItems();

            if (stockItems.ContainsKey(code) == false)
            {
                removeQtyList.Add($"Stock item {code} not found. Quantity not removed.");
            }
            else if (stockItems.ContainsKey(code) == true)
            {
                StockItem itemToRemove = stockManager.FindStockItem(code);
                stockManager.RemoveQuantityFromStockItem(code, quantityToRemove);

                int newQtyInStock = itemToRemove.QuantityInStock;
                transactionManager.RecordQuantityRemoved(itemToRemove, quantityToRemove);
                removeQtyList.Add($"Quantity removed from item: {code}. New quantity in stock: {newQtyInStock}");
            }
            return removeQtyList;
        }
        public List<string> DeleteAStockItem(int code)
        {
            List<string> deleteItemList = new List<string>();
            StockManager stockManager = this.stockMgr;
            TransactionManager transactionManager = this.transactionMgr;

            SortedDictionary<int, StockItem> stockItems = stockManager.GetAllStockItems();
            if (stockItems.ContainsKey(code) == false)
            {
                deleteItemList.Add("Item has not been deleted because it cannot be found");
            }
            else if (stockItems.ContainsKey(code))
            {
                StockItem itemToDelete = stockManager.FindStockItem(code);
                stockManager.DeleteStockItem(code);
                transactionManager.RecordItemDeleted(itemToDelete);
                deleteItemList.Add($"Item {code} deleted.");
            }
            return deleteItemList;
        }
        public List<string> ViewStockLevels()
        {
            List<string> viewStockLevels = new List<string>();
            StockManager stockManager = this.stockMgr;            
            SortedDictionary<int, StockItem> stockItems = stockManager.GetAllStockItems();
            viewStockLevels.Add("\nStock Levels");
            viewStockLevels.Add("============");
            if (stockItems.Count>0) {
                viewStockLevels.Add("\tItem code\tItem name           \tQuantity in stock");
                foreach (int item in stockItems.Keys)
                {
                    int code = stockItems[item].Code;
                    string name = stockItems[item].Name;
                    int qty = stockItems[item].QuantityInStock;
                    viewStockLevels.Add($"\t{code,-9}\t{name,-20}\t{qty}");
                }
            }
            else {
                viewStockLevels.Add("No stock items");
            }
            return viewStockLevels;
        }
        public List<string> ViewTransactionLog()
        {
            List<string> viewTransactionLog = new List<string>();
            TransactionManager transactionManager = this.transactionMgr;
            List<Transaction> transLog = transactionManager.GetAllTransactions();
            viewTransactionLog.Add("\nTransaction log");
            viewTransactionLog.Add("===============");
            if (transLog.Count > 0)
            {
                foreach (var log in transLog)
                {
                    viewTransactionLog.Add($"{log}");
                }
            }
            else
            {
                viewTransactionLog.Add("No transactions");
            }
            return viewTransactionLog;
        }
    }
}
