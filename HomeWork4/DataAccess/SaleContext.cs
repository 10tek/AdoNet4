using HomeWork4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.DataAccess
{
    public class SaleContext : IDisposable
    {
        public Repository<Customer> Customers { get; set; }
        public Repository<Sale> Sales { get; set; }
        public Repository<Seller> Sellers { get; set; }

        public SaleContext(string connectionString, string providerInvariantName)
        {
            Customers = new Repository<Customer>(connectionString, providerInvariantName);
            Sales = new Repository<Sale>(connectionString, providerInvariantName);
            Sellers = new Repository<Seller>(connectionString, providerInvariantName);
        }

        public void Add(Customer customer)
        {
            Customers.Add(customer);
        }
        public void Add(Seller seller)
        {
            Sellers.Add(seller);
        }
        public void Add(Sale sale)
        {
            Sales.Add(sale);
        }

        public void Dispose()
        {
            Customers.Dispose();
            Sales.Dispose();
            Sellers.Dispose();
        }
    }
}