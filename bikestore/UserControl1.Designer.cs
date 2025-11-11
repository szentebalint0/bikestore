namespace bikestore
{
    partial class UserControl1
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
            listBox1 = new ListBox();
            productBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            listBox2 = new ListBox();
            storeBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockPerStoreBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockPerStoreBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.DataSource = productBindingSource;
            listBox1.DisplayMember = "ProductName";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(558, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(189, 394);
            listBox1.TabIndex = 0;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(558, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox2.DataSource = storeBindingSource;
            listBox2.DisplayMember = "StoreName";
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(12, 98);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(199, 394);
            listBox2.TabIndex = 2;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // storeBindingSource
            // 
            storeBindingSource.DataSource = typeof(Models.Store);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            dataGridView1.DataSource = stockPerStoreBindingSource;
            dataGridView1.Location = new Point(217, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(335, 394);
            dataGridView1.TabIndex = 4;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // stockPerStoreBindingSource
            // 
            stockPerStoreBindingSource.DataSource = typeof(Models.StockPerStore);
            // 
            // button1
            // 
            button1.Location = new Point(242, 40);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "hozzáadás";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(394, 63);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "törlés";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(231, 69);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(listBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "UserControl1";
            Size = new Size(750, 495);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockPerStoreBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private BindingSource productBindingSource;
        private ListBox listBox2;
        private BindingSource storeBindingSource;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private BindingSource stockPerStoreBindingSource;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
    }
}
