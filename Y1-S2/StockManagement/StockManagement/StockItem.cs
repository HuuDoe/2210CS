using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StockManagement
{
    public class StockItem
    {
        private int code;
        private string name;
        private int quantityInStock;
        public int Code { get { return code;} set { code = value; } }
        public string Name { get { return name; }set { name = value; } }
        public int QuantityInStock { get { return quantityInStock; } set { quantityInStock = value; } }

        
        public StockItem(int code, string name,int qtyInStock) {
            var exceptions = new List<Exception>();
            var ex= string.Empty;
            //code exceptions
            if (code < 0)
            {
                exceptions.Add(new Exception("Item code must be a positive integer. "));
                //throw new Exception("Item code must be a positive integer. ");
            }
            else
            {
                this.code = code;
            }

            //name exceptions
            if ((name.Length == 0) == true)
            {
                exceptions.Add(new Exception("Item name cannot be blank. "));
                //throw new Exception("Item name cannot be blank. ");
            }
            else if ((string.IsNullOrWhiteSpace(name)) && (name.Length > 0) == true)
            {
                exceptions.Add(new Exception("Item name cannot be just spaces. "));
                //throw new Exception("Item name cannot be just spaces. ");
            }
            else
            {
                this.name = name;
            }

            //qty exceptions
            if (qtyInStock <= 0)
            {
                exceptions.Add(new Exception("Quantity cannot be zero or negative. "));
                //throw new Exception("Quantity cannot be zero or negative. ");
            }
            else
            { 
                quantityInStock = qtyInStock;
            }
           
            
            if (exceptions.Count > 0)
            {
                foreach (Exception e in exceptions)
                {
                    ex += (e.Message);
                }
                throw new Exception(ex);

            }

        }
        public void AddQuantity(int qty) {
            if (qty < 0)
            {
                throw new Exception("Quantity cannot be negative");
            }
            else
            {
                quantityInStock += qty;
            }
            
        }

        public void SubtractQuantity (int qty) {
            if (qty < 0)
            {
                throw new Exception("Quantity cannot be negative");
            }
            else if (quantityInStock - qty<0)
            {
                throw new Exception("Insufficient quantity in stock");
            }
            else
            {
                quantityInStock -= qty;
            }

        }
    }
}
