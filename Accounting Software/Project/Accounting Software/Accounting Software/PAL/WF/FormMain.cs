using System;
using System.Drawing;
using System.Windows.Forms;

namespace Accounting_Software.PAL.WF
{
    public partial class FormMain : Form
    {
        public string Username;

        public FormMain()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void MoveSidePanel(Control button)
        {
            pnlSlide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 166);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Application.Exit();
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picClose, "Close");
        }

        private void picMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picMinimize, "Minimize");
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblDateAndTime.Text = now.ToString("F");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Username;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnDashboard);
            userControlSetting1.Visible = false;
            userControlSale1.Visible = false;
            userControlPurchase1.Visible = false;
            userControlProduct1.Visible = false;
            userControlVendor1.Visible = false;
            userControlCustomer1.Visible = false;
            userControlDashboard1.Count();
            userControlDashboard1.Visible = true;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnSetting);
            userControlDashboard1.Visible = false;
            userControlSale1.Visible = false;
            userControlPurchase1.Visible = false;
            userControlProduct1.Visible = false;
            userControlVendor1.Visible = false;
            userControlCustomer1.Visible = false;
            userControlSetting1.EmptyBox();
            userControlSetting1.Visible = true;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnCustomer);
            userControlDashboard1.Visible = false;
            userControlSale1.Visible = false;
            userControlPurchase1.Visible = false;
            userControlProduct1.Visible = false;
            userControlVendor1.Visible = false;
            userControlSetting1.Visible = false;
            userControlCustomer1.EmptyBox();
            userControlCustomer1.Visible = true;
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnVendor);
            userControlDashboard1.Visible = false;
            userControlSale1.Visible = false;
            userControlPurchase1.Visible = false;
            userControlProduct1.Visible = false;
            userControlSetting1.Visible = false;
            userControlCustomer1.Visible = false;
            userControlVendor1.EmptyBox();
            userControlVendor1.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnProduct);
            userControlDashboard1.Visible = false;
            userControlSale1.Visible = false;
            userControlPurchase1.Visible = false;
            userControlSetting1.Visible = false;
            userControlCustomer1.Visible = false;
            userControlVendor1.Visible = false;
            userControlProduct1.EmptyBox();
            userControlProduct1.Visible = true;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnPurchase);
            userControlDashboard1.Visible = false;
            userControlSale1.Visible = false;
            userControlSetting1.Visible = false;
            userControlCustomer1.Visible = false;
            userControlVendor1.Visible = false;
            userControlProduct1.Visible = false;
            userControlPurchase1.EmptyBox();
            userControlPurchase1.Visible = true;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnSale);
            userControlDashboard1.Visible = false;
            userControlPurchase1.Visible = false;
            userControlSetting1.Visible = false;
            userControlCustomer1.Visible = false;
            userControlVendor1.Visible = false;
            userControlProduct1.Visible = false;
            userControlSale1.EmptyBox();
            userControlSale1.Visible = true;
        }
    }
}
