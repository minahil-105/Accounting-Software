using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Software.BAL
{
    class Sale
    {
        public string Customer_Name { get; set; }
        public string Date { get; set; }
        public string Total_Product { get; set; }
        public string Grand_Total { get; set; }
        public string Status { get; set; }

        public Sale(string customer_Name, string date, string total_Product, string grand_Total, string status)
        {
            Customer_Name = customer_Name;
            Date = date;
            Total_Product = total_Product;
            Grand_Total = grand_Total;
            Status = status;
        }

        public Sale(string total_Product, string grand_Total)
        {
            Total_Product = total_Product;
            Grand_Total = grand_Total;
        }
    }
}
