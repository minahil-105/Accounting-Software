using System;
using System.Windows.Forms;
using Accounting_Software.BAL;
using Accounting_Software.DAL;

namespace Accounting_Software.PAL.UC
{
    public partial class UserControlVendor : UserControl
    {
        private string Id = "";

        public UserControlVendor()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            tcVendor.SelectedTab = tpAddVendor;
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private void EmptyBox1()
        {
            txtName1.Clear();
            txtPhone1.Clear();
            txtAddress1.Clear();
            Id = "";
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picSearch, "Search");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter name.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Vendor vendor = new Vendor(txtName.Text.Trim(), txtPhone.Text.Trim(), txtAddress.Text.Trim());
                AccountingDb.AddVendor(vendor);
                EmptyBox();
            }
        }

        private void tpAddVendor_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageVendor_Enter(object sender, EventArgs e)
        {
            txtSearchName.Clear();
            AccountingDb.DisplayAndSearch("SELECT * FROM Vendors;", dgvVendors);
            lblTotal.Text = dgvVendors.Rows.Count.ToString();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            AccountingDb.DisplayAndSearch("SELECT * FROM Vendors WHERE Vendor_Name LIKE '%" + txtSearchName.Text + "%';", dgvVendors);
            lblTotal.Text = dgvVendors.Rows.Count.ToString();
        }

        private void dgvVendors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvVendors.Rows[e.RowIndex];
                Id = row.Cells[0].Value.ToString();
                txtName1.Text = row.Cells[1].Value.ToString();
                txtPhone1.Text = row.Cells[2].Value.ToString();
                txtAddress1.Text = row.Cells[3].Value.ToString();
                tcVendor.SelectedTab = tpUpdateAndDeleteVendor;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Id == "")
            {
                MessageBox.Show("Please select row from table.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter name.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Vendor vendor = new Vendor(txtName1.Text.Trim(), txtPhone1.Text.Trim(), txtAddress1.Text.Trim());
                AccountingDb.UpdateVendor(vendor, Id);
                EmptyBox1();
                tcVendor.SelectedTab = tpManageVendor;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Id == "")
            {
                MessageBox.Show("Please select row from table.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this vendor?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    AccountingDb.DeleteVendor(Id);
                    EmptyBox1();
                    tcVendor.SelectedTab = tpManageVendor;
                }
            }
        }

        private void tpEditAndDeleteVendor_Enter(object sender, EventArgs e)
        {
            if (Id == "")
                tcVendor.SelectedTab = tpManageVendor;
        }

        private void tpEditAndDeleteVendor_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void txtOpeningBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
                e.Handled = true;

            // only allow minus sign at the beginning
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                e.Handled = true;
        }

        private void txtOpeningBalance1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            // only allow minus sign at the beginning
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                e.Handled = true;
        }
    }
}
