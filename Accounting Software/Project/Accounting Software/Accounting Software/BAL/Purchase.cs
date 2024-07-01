using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Software.BAL
{
    class Purchase
    {
        public string Vendor_Name { get; set; }
        public string Date { get; set; }
        public string Total_Product { get; set; }
        public string Grand_Total { get; set; }
        public string Status { get; set; }

        public Purchase(string vendor_Name, string date, string total_Product, string grand_Total, string status)
        {
            Vendor_Name = vendor_Name;
            Date = date;
            Total_Product = total_Product;
            Grand_Total = grand_Total;
            Status = status;
        }

        public Purchase(string total_Product, string grand_Total)
        {
            Total_Product = total_Product;
            Grand_Total = grand_Total;
        }
    }
}
