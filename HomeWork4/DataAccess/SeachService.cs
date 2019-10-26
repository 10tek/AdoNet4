using HomeWork4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.DataAccess
{
    public class SeachService
    {
        public static string GetSellerName(List<Seller> sellers, Guid id)
        {
            foreach(var seller in sellers)
            {
                if(seller.Id == id)
                {
                    return seller.FirstName;
                }
            }
            return "";
        }

        public static string GetCustomerName(List<Customer> customers, Guid id)
        {
            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {
                    return customer.FirstName;
                }
            }
            return "";
        }
    }
}
