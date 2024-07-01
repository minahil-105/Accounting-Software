using System;
using System.Windows.Forms;
using Accounting_Software.BAL;
using Accounting_Software.DAL;

namespace Accounting_Software.PAL.UC
{
    public partial class UserControlCustomer : UserControl
    {
        private string Id = "";

        public UserControlCustomer()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            tcCustomer.SelectedTab = tpAddCustomer;
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
            else if (txtPhone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter phone.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter address.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Customer customer = new Customer(txtName.Text.Trim(), txtPhone.Text.Trim(), txtAddress.Text.Trim());
                AccountingDb.AddCustomer(customer);
                EmptyBox();
            }
        }

        private void tpAddCustomer_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageCustomer_Enter(object sender, EventArgs e)
        {
            txtSearchName.Clear();
            AccountingDb.DisplayAndSearch("SELECT * FROM Customers;", dgvCustomers);
            lblTotal.Text = dgvCustomers.Rows.Count.ToString();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            AccountingDb.DisplayAndSearch("SELECT * FROM Customers WHERE Customer_Name LIKE '%" + txtSearchName.Text + "%';", dgvCustomers);
            lblTotal.Text = dgvCustomers.Rows.Count.ToString();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                Id = row.Cells[0].Value.ToString();
                txtName1.Text = row.Cells[1].Value.ToString();
                txtPhone1.Text = row.Cells[2].Value.ToString();
                txtAddress1.Text = row.Cells[3].Value.ToString();
                tcCustomer.SelectedTab = tpUpdateAndDeleteCustomer;
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
            else if (txtPhone1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter phone.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtAddress1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter address.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Customer customer = new Customer(txtName1.Text.Trim(), txtPhone1.Text.Trim(), txtAddress1.Text.Trim());
                AccountingDb.UpdateCustomer(customer, Id);
                EmptyBox1();
                tcCustomer.SelectedTab = tpManageCustomer;
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
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this customer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    AccountingDb.DeleteCustomer(Id);
                    EmptyBox1();
                    tcCustomer.SelectedTab = tpManageCustomer;
                }
            }
        }

        private void tpEditAndDeleteCustomer_Enter(object sender, EventArgs e)
        {
            if (Id == "")
                tcCustomer.SelectedTab = tpManageCustomer;
        }

        private void tpEditAndDeleteCustomer_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void txtOpeningBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
