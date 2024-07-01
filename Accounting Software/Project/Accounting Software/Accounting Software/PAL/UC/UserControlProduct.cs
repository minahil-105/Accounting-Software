using System;
using System.Drawing;
using System.Windows.Forms;
using Accounting_Software.BAL;
using Accounting_Software.DAL;

namespace Accounting_Software.PAL.UC
{
    public partial class UserControlProduct : UserControl
    {
        private string Id = "";

        public UserControlProduct()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            tcProduct.SelectedTab = tpAddProduct;
            txtName.Clear();
            txtQuantity.Clear();
            txtRate.Clear();
            txtDescription.Clear();
        }

        private void EmptyBox1()
        {
            txtName1.Clear();
            txtQuantity1.Clear();
            txtRate1.Clear();
            txtDescription1.Clear();
            Id = "";
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtQuantity1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
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
            else if (txtQuantity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter quantity.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtRate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter rate.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtDescription.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter description.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Product product = new Product(txtName.Text.Trim(), txtQuantity.Text.Trim(), txtRate.Text.Trim(), txtDescription.Text.Trim());
                AccountingDb.AddProduct(product);
                EmptyBox();
            }
        }

        private void tpAddProduct_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageProduct_Enter(object sender, EventArgs e)
        {
            txtSearchName.Clear();
            AccountingDb.DisplayAndSearch("SELECT * FROM Products;", dgvProducts);
            lblTotal.Text = dgvProducts.Rows.Count.ToString();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            AccountingDb.DisplayAndSearch("SELECT * FROM Products WHERE Product_Name LIKE '%" + txtSearchName.Text + "%';", dgvProducts);
            lblTotal.Text = dgvProducts.Rows.Count.ToString();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                Id = row.Cells[0].Value.ToString();
                txtName1.Text = row.Cells[1].Value.ToString();
                txtQuantity1.Text = row.Cells[2].Value.ToString();
                txtRate1.Text = row.Cells[3].Value.ToString();
                txtDescription1.Text = row.Cells[4].Value.ToString();
                tcProduct.SelectedTab = tpUpdateAndDeleteProduct;
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
            else if (txtQuantity1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter quantity.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtRate1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter rate.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtDescription1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter description.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Product product = new Product(txtName1.Text.Trim(), txtQuantity1.Text.Trim(), txtRate1.Text.Trim(), txtDescription1.Text.Trim());
                AccountingDb.UpdateProduct(product, Id);
                EmptyBox1();
                tcProduct.SelectedTab = tpManageProduct;
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
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this product?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    AccountingDb.DeleteProduct(Id);
                    EmptyBox1();
                    tcProduct.SelectedTab = tpManageProduct;
                }
            }
        }

        private void tpEditAndDeleteProduct_Enter(object sender, EventArgs e)
        {
            if (Id == "")
                tcProduct.SelectedTab = tpManageProduct;
        }

        private void tpEditAndDeleteProduct_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (Convert.ToInt32(row.Cells["Column3"].Value) > 50)
                    row.Cells["Column3"].Style.ForeColor = Color.Green;
                else
                    row.Cells["Column3"].Style.ForeColor = Color.DarkOrange;
            }
        }
    }
}
