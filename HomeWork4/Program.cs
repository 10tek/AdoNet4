using HomeWork4.DataAccess;
using HomeWork4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Заполнение
            //using (var context = new SaleContext(Constants.ConnectionString, Constants.ProviderName))
            //{
            //    var firstCustomer = new Customer
            //    {
            //        FirstName = "Азат",
            //        LastName = "Сагалбаев"
            //    };

            //    var secondCustomer = new Customer
            //    {
            //        FirstName = "Галым",
            //        LastName = "Оралбаев"
            //    };

            //    var firstSeller = new Seller
            //    {
            //        FirstName = "Петя",
            //        LastName = "Петров"
            //    };

            //    var secondSeller = new Seller
            //    {
            //        FirstName = "Вася",
            //        LastName = "Ким",
            //    };

            //    var firstSale = new Sale
            //    {
            //        CustomerId = firstCustomer.Id,
            //        SellerId = firstSeller.Id,
            //        Price = 11.5
            //    };

            //    var secondSale = new Sale
            //    {
            //        CustomerId = secondCustomer.Id,
            //        SellerId = secondSeller.Id,
            //        Price = 20.7
            //    };

            //    context.Customers.Add(firstCustomer);
            //    context.Customers.Add(secondCustomer);
            //    context.Sellers.Add(firstSeller);
            //    context.Sellers.Add(secondSeller);
            //    context.Sales.Add(firstSale);
            //    context.Sales.Add(secondSale);
            //}
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
