using StockManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StockManagement
{
    public class StockManager
    {
        
        private SortedDictionary<int, StockItem> stockItems;
        public StockManager() {
        stockItems = new SortedDictionary<int, StockItem>();
        }
        public SortedDictionary<int, StockItem> GetAllStockItems()
        {
            return stockItems;
        }
       
        public StockItem CreateStockItem(int code, string name, int quantityInStock)
        {
            if (stockItems.ContainsKey(code))
            {
                throw new Exception($"Item code {code} already exists. Item not added.");
            }
            StockItem stockItem =new StockItem(code, name, quantityInStock);
            stockItems.Add(code, stockItem);
            return stockItem;

        }
        public StockItem FindStockItem(int code)
        {
            if (stockItems.ContainsKey(code))
            {
                return stockItems[code];
            }
            else
            {
                return null;
            }
        }
        public StockItem AddQuantityToStockItem(int code, int quantityToAdd)
        {
            if (stockItems.ContainsKey(code))
            {
                
                StockItem stockItem = stockItems[code];
                stockItem.QuantityInStock += quantityToAdd;
                return stockItem;
            }
            else
            {
                throw new Exception($"Stock item {code} not found. Quantity not added.");
            }
        }
        public StockItem RemoveQuantityFromStockItem(int code, int quantityToRemove)
        {
            if (stockItems.ContainsKey(code))
            {
                StockItem stockItem = stockItems[code];
                stockItem.QuantityInStock -= quantityToRemove;
                return stockItem;
            }
            else
            {
                throw new Exception($"Stock item {code} not found. Quantity not removed.");
            }
        }
        public StockItem DeleteStockItem(int code)
        {
            if (stockItems.ContainsKey(code))
            {
                
                StockItem stockItem = stockItems[code];
                if (stockItem.QuantityInStock == 0) {
                    stockItems.Remove(code);
                    return stockItem;
                }
                else
                {
                    throw new Exception("Item cannot be deleted because quantity in stock is not zero");
                }

            }
            else
            {
                throw new Exception("Item has not been deleted because it cannot be found");
            }

        }
    }

}
