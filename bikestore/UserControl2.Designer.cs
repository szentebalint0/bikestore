namespace bikestore
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            customerBindingSource = new BindingSource(components);
            listBox2 = new ListBox();
            orderBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            currentOrderBindingSource = new BindingSource(components);
            orderFkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productFkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            listPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentOrderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.DataSource = customerBindingSource;
            listBox1.DisplayMember = "LastName";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(35, 124);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(205, 379);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Models.Customer);
            // 
            // listBox2
            // 
            listBox2.DataSource = orderBindingSource;
            listBox2.DisplayMember = "OrderSk";
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(271, 124);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(171, 379);
            listBox2.TabIndex = 2;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Models.Order);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderFkDataGridViewTextBoxColumn, productFkDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, listPriceDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn });
            dataGridView1.DataSource = currentOrderBindingSource;
            dataGridView1.Location = new Point(481, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(329, 376);
            dataGridView1.TabIndex = 3;
            // 
            // currentOrderBindingSource
            // 
            currentOrderBindingSource.DataSource = typeof(Models.CurrentOrder);
            // 
            // orderFkDataGridViewTextBoxColumn
            // 
            orderFkDataGridViewTextBoxColumn.DataPropertyName = "OrderFk";
            orderFkDataGridViewTextBoxColumn.HeaderText = "OrderFk";
            orderFkDataGridViewTextBoxColumn.Name = "orderFkDataGridViewTextBoxColumn";
            // 
            // productFkDataGridViewTextBoxColumn
            // 
            productFkDataGridViewTextBoxColumn.DataPropertyName = "ProductFk";
            productFkDataGridViewTextBoxColumn.HeaderText = "ProductFk";
            productFkDataGridViewTextBoxColumn.Name = "productFkDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // listPriceDataGridViewTextBoxColumn
            // 
            listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
            listPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice";
            listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "UserControl2";
            Size = new Size(825, 532);
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentOrderBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private BindingSource customerBindingSource;
        private ListBox listBox2;
        private BindingSource orderBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn orderFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private BindingSource currentOrderBindingSource;
    }
}
