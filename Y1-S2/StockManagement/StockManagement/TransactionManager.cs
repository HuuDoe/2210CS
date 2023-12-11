using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    public class TransactionManager
    {
        private List<Transaction> transactions;
        public TransactionManager() 
        {
            transactions = new List<Transaction>();
        }

        public List<Transaction> GetAllTransactions()
        {
            return transactions;
        }
        public void RecordItemAdded(StockItem stockitem) {
            //this prolly not the optimal way to do it but it works so idc
            Transaction thistransaction = new ItemAddedTransaction(DateTime.Now,stockitem.Code,stockitem.Name,stockitem.QuantityInStock);
            transactions.Add(thistransaction);
        }
        public void RecordItemDeleted(StockItem stockitem)
        {
            //this prolly not the optimal way to do it but it works so idc
            Transaction thistransaction = new ItemDeletedTransaction(DateTime.Now, stockitem.Code, stockitem.Name);
            transactions.Add(thistransaction);
        }
        public void RecordQuantityAdded(StockItem stockitem,int quantityAdded)
        {   //problem here???
            int newquantity=stockitem.QuantityInStock;
 
            Transaction thistransaction = new QuantityAddedTransaction(DateTime.Now, stockitem.Code, stockitem.Name, quantityAdded, newquantity);
            transactions.Add(thistransaction);
        }
        public void RecordQuantityRemoved(StockItem stockitem, int quantityRemoved)
        {
            int newquantity = stockitem.QuantityInStock ;

            Transaction thistransaction = new QuantityRemovedTransaction(DateTime.Now, stockitem.Code, stockitem.Name, quantityRemoved, newquantity);
            transactions.Add(thistransaction);
        }
    }
}
