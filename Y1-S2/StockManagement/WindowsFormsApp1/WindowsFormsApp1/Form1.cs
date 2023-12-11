using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class stockManagementGUI : Form
    {
        public stockManagementGUI()
        {
            InitializeComponent();
        }
        DataTable inventory = new DataTable();
        private void stockManagementGUI_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("Code");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Quantity");
            inventoryGridView.DataSource = inventory;

        }


        private void addnewItembutton_Click(object sender, EventArgs e)
        {
            try {
                int code = Int32.Parse(itemCodetextBox.Text);
                string name = itemNametextBox.Text;
                int quantity = Int32.Parse(itemQuantitytextBox.Text);
                inventory.Rows.Add(code, name, quantity);
            }
            catch { 
            
            }
            Clearbutton_Click(sender, e);
            
        }

       

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            itemCodetextBox.Text = "";
            itemNametextBox.Text = "";
            itemQuantitytextBox.Text = "";
        }
    }
}
