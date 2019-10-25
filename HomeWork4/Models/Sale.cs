using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Models
{
    public class Sale : Entity
    {
        public Guid SellerId { get; set; }
        public Guid CustomerId { get; set; }
    }
}
