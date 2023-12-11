namespace WindowsFormsApp1
{
    partial class stockManagementGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addNewItembutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemNametextBox = new System.Windows.Forms.TextBox();
            this.itemQuantitytextBox = new System.Windows.Forms.TextBox();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.itemCodetextBox = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.Clearbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewItembutton
            // 
            this.addNewItembutton.Location = new System.Drawing.Point(12, 74);
            this.addNewItembutton.Name = "addNewItembutton";
            this.addNewItembutton.Size = new System.Drawing.Size(129, 23);
            this.addNewItembutton.TabIndex = 2;
            this.addNewItembutton.Text = "Add New Item";
            this.addNewItembutton.UseVisualStyleBackColor = true;
            this.addNewItembutton.Click += new System.EventHandler(this.addnewItembutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(810, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(807, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Quantity";
            // 
            // itemNametextBox
            // 
            this.itemNametextBox.Location = new System.Drawing.Point(336, 46);
            this.itemNametextBox.Name = "itemNametextBox";
            this.itemNametextBox.Size = new System.Drawing.Size(271, 22);
            this.itemNametextBox.TabIndex = 8;
            // 
            // itemQuantitytextBox
            // 
            this.itemQuantitytextBox.Location = new System.Drawing.Point(810, 46);
            this.itemQuantitytextBox.Name = "itemQuantitytextBox";
            this.itemQuantitytextBox.Size = new System.Drawing.Size(232, 22);
            this.itemQuantitytextBox.TabIndex = 9;
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Location = new System.Drawing.Point(6, 107);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.RowHeadersWidth = 51;
            this.inventoryGridView.RowTemplate.Height = 24;
            this.inventoryGridView.Size = new System.Drawing.Size(1200, 444);
            this.inventoryGridView.TabIndex = 10;
            // 
            // itemCodetextBox
            // 
            this.itemCodetextBox.Location = new System.Drawing.Point(12, 46);
            this.itemCodetextBox.Name = "itemCodetextBox";
            this.itemCodetextBox.Size = new System.Drawing.Size(271, 22);
            this.itemCodetextBox.TabIndex = 11;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(481, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(137, 29);
            this.title.TabIndex = 12;
            this.title.Text = "Admin GUI";
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(1131, 45);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(75, 23);
            this.Clearbutton.TabIndex = 13;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // stockManagementGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 563);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.title);
            this.Controls.Add(this.itemCodetextBox);
            this.Controls.Add(this.inventoryGridView);
            this.Controls.Add(this.itemQuantitytextBox);
            this.Controls.Add(this.itemNametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addNewItembutton);
            this.Name = "stockManagementGUI";
            this.Text = "Stock Management GUI";
            this.Load += new System.EventHandler(this.stockManagementGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNewItembutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemNametextBox;
        private System.Windows.Forms.TextBox itemQuantitytextBox;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.TextBox itemCodetextBox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button Clearbutton;
    }
}

