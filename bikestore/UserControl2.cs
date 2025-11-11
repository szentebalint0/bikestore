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

namespace bikestore
{
    public partial class UserControl2 : UserControl
    {
        SeBikestoreContext context;
        public UserControl2()
        {
            InitializeComponent();
            context = new();

            customerBindingSource.DataSource = context.Customers.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = from x in context.Customers
                        where x.LastName.Contains(textBox1.Text)
                        select x;

            customerBindingSource.DataSource = query.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 

            if (customerBindingSource.Current == null) return;

            var currentCustomer = customerBindingSource.Current as Customer;

            var query = from x in context.Orders
                        where x.CustomerFk == currentCustomer.CustomerSk
                        select x;

            orderBindingSource.DataSource = query.ToList();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderBindingSource.Current == null) return;

            var current = orderBindingSource.Current as Order;

            var query = from x in context.OrderItems
                        where x.OrderFk == current.OrderSk
                        select new CurrentOrder()
                        {
                            OrderFk = x.OrderFk,
                            ProductFk = x.ProductFk,
                            ListPrice = x.ListPrice,
                            Discount = x.Discount,
                            Quantity = x.Quantity
                            
                        };

            currentOrderBindingSource.DataSource = query.ToList();
        }
    }
}
