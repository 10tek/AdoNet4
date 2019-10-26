using HomeWork4.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GetCustomers_Click(object sender, EventArgs e)
        {
            using(var context = new SaleContext(Constants.ConnectionString, Constants.ProviderName))  
            {
                var customers = context.Customers.GetAll();
                var stringBuilder = new StringBuilder();
                var i = 0;
                foreach(var customer in customers)
                {
                    stringBuilder.Append($"{++i}) Name: {customer.FirstName}\r\n   Surname: {customer.LastName}\r\n");
                }
                textBox.Text = stringBuilder.ToString();
            }
        }

        private void GetSellers_Click(object sender, EventArgs e)
        {
            using (var context = new SaleContext(Constants.ConnectionString, Constants.ProviderName))
            {
                var sellers = context.Sellers.GetAll();
                var stringBuilder = new StringBuilder();
                var i = 0;
                foreach (var seller in sellers)
                {
                    stringBuilder.Append($"{++i}) Name: {seller.FirstName}\r\n   Surname: {seller.LastName}\r\n");
                }
                textBox.Text = stringBuilder.ToString();
            }
        }

        private void GetSales_Click(object sender, EventArgs e)
        {
            using (var context = new SaleContext(Constants.ConnectionString, Constants.ProviderName))
            {
                var sales = context.Sales.GetAll().ToList();
                var sellers = context.Sellers.GetAll().ToList();
                var customers = context.Customers.GetAll().ToList();

                var stringBuilder = new StringBuilder();
                var i = 0;
                foreach (var sale in sales)
                {
                    stringBuilder.Append($"{++i}) Seller Name: {SeachService.GetSellerName(sellers, sale.SellerId)}\r\n   Customer Name: {SeachService.GetCustomerName(customers, sale.CustomerId)}\r\n   Price: {sale.Price}\r\n");
                    stringBuilder.Append($"   Sale time: {sale.CreationDate}\r\n");
                }
                textBox.Text = stringBuilder.ToString();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
