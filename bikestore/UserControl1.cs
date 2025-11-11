using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bikestore.Models;
using System.Net.Mime;
using Microsoft.EntityFrameworkCore;

namespace bikestore
{
    public partial class UserControl1 : UserControl
    {
        SeBikestoreContext context;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            context = new();

            productBindingSource.DataSource = context.Products.ToList();
            storeBindingSource.DataSource = context.Stores.ToList();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = from x in context.Products
                        where x.ProductName.Contains(textBox1.Text)
                        select x;

            productBindingSource.DataSource = query.ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var query2 = from x in context.Stores
                         where x.StoreName.Contains(textBox2.Text)
                         select x;

            storeBindingSource.DataSource = query2.ToList();

        }

        private void QuantityCheck()
        {
            var currentStore = storeBindingSource.Current as Store;

            if (currentStore == null) return;

            var query = from x in context.Stocks
                        where currentStore.StoreSk == x.StoreSk
                        select new StockPerStore()
                        {
                            productName = x.ProductFkNavigation.ProductName,
                            quantity = x.Quantity
                        };
            stockPerStoreBindingSource.DataSource = query.ToList();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuantityCheck();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentStore = storeBindingSource.Current as Store;

            var currentProduct = productBindingSource.Current as Product;

            if (currentStore == null || currentProduct == null) return;


            //var addProduct = (from x in context.Stocks
            //                 where x.StoreSk == currentStore.StoreSk && x.ProductFk == currentProduct.ProductSk
            //                 select new Stock()
            //                 {
            //                     StoreSk = currentStore.StoreSk,
            //                     ProductFk = currentProduct.ProductSk,
            //                     Quantity = int.Parse(textBox3.Text)
            //                 }).FirstOrDefault();

            var add = (from x in context.Stocks
                       where x.StoreSk == currentStore.StoreSk && x.ProductFk == currentProduct.ProductSk
                       select x).FirstOrDefault();

            if (add != null)
            {
                add.Quantity = add.Quantity + int.Parse(textBox3.Text);
            }
            else
            {
                Stock stock = new()
                {
                    StoreSk = currentStore.StoreSk,
                    ProductFk = currentProduct.ProductSk,
                    Quantity = int.Parse(textBox3.Text)
                };

                context.Stocks.Add(stock);
            }


            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            QuantityCheck();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var currentStore = storeBindingSource.Current as Store;

            var currentProduct = productBindingSource.Current as Product;

            if (currentStore == null || currentProduct == null) return;

            var delete = (from x in context.Stocks
                       where x.StoreSk == currentStore.StoreSk && x.ProductFk == currentProduct.ProductSk
                       select x).FirstOrDefault();

            if (delete != null && (delete.Quantity - int.Parse(textBox3.Text)) >= 0)
            {
                delete.Quantity = delete.Quantity - int.Parse(textBox3.Text);
            }

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            QuantityCheck();
        }
    }
}
