using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting_Software.DAL;

namespace Accounting_Software.PAL.UC
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
            Count();
        }

        public void Count()
        {
            labelVendor.Text = AccountingDb.Count("SELECT COUNT(*) FROM Vendors;").ToString();
            labelCustomer.Text = AccountingDb.Count("SELECT COUNT(*) FROM Customers;").ToString();
            labelUser.Text = AccountingDb.Count("SELECT COUNT(*) FROM Users;").ToString();
            labelProduct.Text = AccountingDb.Count("SELECT COUNT(*) FROM Products;").ToString();
        }
    }
}
