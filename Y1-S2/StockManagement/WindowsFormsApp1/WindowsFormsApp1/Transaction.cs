using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Transaction
    {
        
        private DateTime transactionDatetime;
        private string transactionName ;
        public DateTime TransactionDatetime { get { return transactionDatetime; }set { transactionDatetime = value; } }
        public string TransactionName { get { return transactionName; }set { transactionName = value; } }
        public Transaction(string name , DateTime dt)
        {

            this.transactionName = name;
            this.transactionDatetime = dt;
            
        }

        

        public DateTime GetTransactionDatetime()
        {
            return transactionDatetime;
        }

        public string GetTransactionName()
        {
            return transactionName;
        }

        public override string ToString()
        {
            return $"{TransactionDatetime:dd/MM/yyyy HH:mm} {TransactionName,-17}- Item ";
        }
    
    }
    public class ItemAddedTransaction : Transaction
    {

        private int stockItemCode;
        private string stockItemName;
        private int quantityAdded;
        


        public ItemAddedTransaction(DateTime transactionDatetime, int stockItemCode, string stockItemName, int quantityAdded)
            : base("Item added", transactionDatetime)
        {
            TransactionDatetime = transactionDatetime;

            this.stockItemCode = stockItemCode;
            this.stockItemName = stockItemName;
            this.quantityAdded = quantityAdded;
            
        }

        public override string ToString()
        {
            
            return $"{base.ToString()}{stockItemCode}: {stockItemName} added. Quantity in stock: {quantityAdded}";
        }
    }
    public class ItemDeletedTransaction : Transaction
    {

        private int stockItemCode;
        private string stockItemName;

        public ItemDeletedTransaction(DateTime transactionDatetime, int stockItemCode, string stockItemName)
            : base("Item deleted", transactionDatetime)
        {
            TransactionDatetime = transactionDatetime;

            this.stockItemCode = stockItemCode;
            this.stockItemName = stockItemName;
            

        }

        public override string ToString()
        {

            return $"{base.ToString()}{stockItemCode}: {stockItemName} deleted.";
        }
    }
    public class QuantityAddedTransaction : Transaction
    {
        private int stockItemCode;
        private string stockItemName;
        private int quantityAdded;
        private int newQuantityInStock;

        public QuantityAddedTransaction(DateTime transactionDatetime, int stockItemCode, string stockItemName, int quantityAdded, int newQuantityInStock)
            : base("Quantity added", transactionDatetime)
        {
            this.stockItemCode = stockItemCode;
            this.stockItemName = stockItemName;
            this.quantityAdded = quantityAdded;
            this.newQuantityInStock = newQuantityInStock;
        }
        public override string ToString()
        {
            
            return $"{base.ToString()}{stockItemCode}: {stockItemName}. {TransactionName}: {quantityAdded}. New quantity in stock: {newQuantityInStock}";
        }
    }
    public class QuantityRemovedTransaction : Transaction
    {
        private int stockItemCode;
        private string stockItemName;
        private int quantityRemoved;
        private int newQuantityInStock;

        public QuantityRemovedTransaction(DateTime transactionDatetime, int stockItemCode, string stockItemName, int quantityRemoved, int newQuantityInStock)
            : base("Quantity removed", transactionDatetime)
        {
            this.stockItemCode = stockItemCode;
            this.stockItemName = stockItemName;
            this.quantityRemoved = quantityRemoved;
            this.newQuantityInStock = newQuantityInStock;
        }
        public override string ToString()
        {

            return $"{base.ToString()}{stockItemCode}: {stockItemName}. {TransactionName}: {quantityRemoved}. New quantity in stock: {newQuantityInStock}";
        }
    }
}

