using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Software.BAL
{
    class Product
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Rate { get; set; }
        public string Description { get; set; }

        public Product(string name, string quantity, string rate, string discription)
        {
            Name = name;
            Quantity = quantity;
            Rate = rate;
            Description = discription;
        }

        public Product(string name, string quantity, string rate)
        {
            Name = name;
            Quantity = quantity;
            Rate = rate;
        }
    }
}
