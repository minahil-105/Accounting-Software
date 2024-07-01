using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Accounting_Software.DAL;
using Accounting_Software.BAL;
using System.Data.SqlClient;
using Accounting_Software.Properties;

namespace Accounting_Software.PAL.UC
{
    public partial class UserControlSale : UserControl
    {
        private string Id = "", status;
        private bool already_have = true;
        private int grand_total = 0;
        private int i;
        private int grand;
        private SqlDataReader sdr;

        public UserControlSale()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            FillCustomerName();
            FillProduct();
            txtQuantity.Clear();
            txtRate.Clear();
            dgvProducts.Rows.Clear();
            lblProduct.Text = "0";
            lblGrandTotal.Text = "0";
            cbReceived.Checked = false;
        }

        private void EmptyBox1()
        {
            FillCustomerName1();
            FillProduct1();
            txtQuantity1.Clear();
            txtRate1.Clear();
            dgvProducts1.Rows.Clear();
            lblProduct1.Text = "0";
            lblGrandTotal1.Text = "0";
            cbReceived1.Checked = false;
            Id = "";
        }

        private void FillCustomerName()
        {
            cmbCustomerName.Items.Clear();
            cmbCustomerName.Items.Add("-- SELECT --");
            AccountingDb.FillComboBox("SELECT Customer_Name FROM Customers;", cmbCustomerName);
            cmbCustomerName.SelectedIndex = 0;
        }

        private void FillProduct()
        {
            cmbProduct.Items.Clear();
            cmbProduct.Items.Add("-- SELECT --");
            AccountingDb.FillComboBox("SELECT Product_Name FROM Products;", cmbProduct);
            cmbProduct.SelectedIndex = 0;
        }

        private void FillCustomerName1()
        {
            cmbCustomerName1.Items.Clear();
            cmbCustomerName1.Items.Add("-- SELECT --");
            AccountingDb.FillComboBox("SELECT Customer_Name FROM Customers;", cmbCustomerName1);
            cmbCustomerName1.SelectedIndex = 0;
        }

        private void FillProduct1()
        {
            cmbProduct1.Items.Clear();
            cmbProduct1.Items.Add("-- SELECT --");
            AccountingDb.FillComboBox("SELECT Product_Name FROM Products;", cmbProduct1);
            cmbProduct1.SelectedIndex = 0;
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picSearch, "Search");
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAdd, "Add Product");
        }

        private void btnAdd1_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAdd1, "Add Product");
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtQuantity1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtRate1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex == 0)
            {
                MessageBox.Show("Please select product.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtQuantity.Text == string.Empty || txtQuantity.Text == "0")
            {
                MessageBox.Show("Please enter quantity.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtRate.Text == string.Empty)
            {
                MessageBox.Show("Please enter price.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (dgvProducts.Rows.Count != 0)
                {
                    foreach (DataGridViewRow row in dgvProducts.Rows)
                    {
                        if (row.Cells["Product_Name"].Value.ToString() == cmbProduct.SelectedItem.ToString())
                        {
                            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
                            quantity += Convert.ToInt32(txtQuantity.Text);
                            row.Cells["Quantity"].Value = quantity;
                            row.Cells["Rate"].Value = txtRate.Text;
                            already_have = false;
                            break;
                        }
                    }
                    if(already_have)
                    {
                        string[] row =
                        {
                            cmbProduct.SelectedItem.ToString(), txtQuantity.Text, txtRate.Text
                        };
                        dgvProducts.Rows.Add(row);
                    }
                }
                else
                {
                    string[] row =
                    {
                        cmbProduct.SelectedItem.ToString(), txtQuantity.Text, txtRate.Text
                    };
                    dgvProducts.Rows.Add(row);
                }
                already_have = true;
                lblProduct.Text = dgvProducts.Rows.Count.ToString();
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    row.Cells["Total"].Value = Convert.ToInt32(row.Cells["Quantity"].Value.ToString()) * Convert.ToInt32(row.Cells["Rate"].Value.ToString());
                    grand_total += Convert.ToInt32(row.Cells["Total"].Value.ToString());
                    lblGrandTotal.Text = grand_total.ToString();
                }
                grand_total = 0;
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvProducts.Columns["Image"].Index && e.RowIndex != -1)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                grand_total = Convert.ToInt32(lblGrandTotal.Text);
                grand_total -= Convert.ToInt32(row.Cells["Total"].Value.ToString());
                lblGrandTotal.Text = grand_total.ToString();
                grand_total = 0;
                int rowIndex = dgvProducts.CurrentCell.RowIndex;
                dgvProducts.Rows.RemoveAt(rowIndex);
                lblProduct.Text = dgvProducts.Rows.Count.ToString();
            }
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if (cmbProduct1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select product.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtQuantity1.Text == string.Empty || txtQuantity1.Text == "0")
            {
                MessageBox.Show("Please enter quantity.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtRate1.Text == string.Empty)
            {
                MessageBox.Show("Please enter rate.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (dgvProducts1.Rows.Count != 0)
                {
                    foreach (DataGridViewRow row in dgvProducts1.Rows)
                    {
                        if (row.Cells["Product_Name1"].Value.ToString() == cmbProduct1.SelectedItem.ToString())
                        {
                            int quantity = Convert.ToInt32(row.Cells["Quantity1"].Value.ToString());
                            quantity += Convert.ToInt32(txtQuantity1.Text);
                            row.Cells["Quantity1"].Value = quantity;
                            row.Cells["Rate1"].Value = txtRate1.Text;
                            int oldQuantity = AccountingDb.GetQuantity("SELECT Product_Quantity FROM Products WHERE Product_Name = '" + row.Cells["Product_Name1"].Value.ToString() + "';");
                            int newQuantity = oldQuantity - Convert.ToInt32(txtQuantity1.Text);
                            AccountingDb.UpdateQuantity(newQuantity.ToString(), row.Cells["Product_Name1"].Value.ToString());
                            AccountingDb.UpdateSaleProductQuantity(row.Cells["Quantity1"].Value.ToString(), Id, cmbProduct1.SelectedItem.ToString());
                            already_have = false;
                            break;
                        }
                    }
                    if (already_have)
                    {
                        string[] row =
                        {
                            cmbProduct1.SelectedItem.ToString(), txtQuantity1.Text, txtRate1.Text
                        };
                        dgvProducts1.Rows.Add(row);
                        Product product = new Product(cmbProduct1.SelectedItem.ToString(), txtQuantity1.Text, txtRate1.Text);
                        AccountingDb.UpdateSaleProducts(product, Id);
                        int oldQuantity = AccountingDb.GetQuantity("SELECT Product_Quantity FROM Products WHERE Product_Name = '" + cmbProduct1.SelectedItem.ToString() + "';");
                        int newQuantity = oldQuantity - Convert.ToInt32(txtQuantity1.Text);
                        AccountingDb.UpdateQuantity(newQuantity.ToString(), cmbProduct1.SelectedItem.ToString());
                    }
                }
                else
                {
                    string[] row =
                    {
                        cmbProduct1.SelectedItem.ToString(), txtQuantity1.Text, txtRate1.Text
                    };
                    dgvProducts1.Rows.Add(row);
                    Product product = new Product(cmbProduct1.SelectedItem.ToString(), txtQuantity1.Text, txtRate1.Text);
                    AccountingDb.UpdateSaleProducts(product, Id);
                    int oldQuantity = AccountingDb.GetQuantity("SELECT Product_Quantity FROM Products WHERE Product_Name = '" + cmbProduct1.SelectedItem.ToString() + "';");
                    int newQuantity = oldQuantity - Convert.ToInt32(txtQuantity1.Text);
                    AccountingDb.UpdateQuantity(newQuantity.ToString(), cmbProduct1.SelectedItem.ToString());
                }
                already_have = true;
                lblProduct1.Text = dgvProducts1.Rows.Count.ToString();
                foreach (DataGridViewRow row in dgvProducts1.Rows)
                {
                    row.Cells["Total1"].Value = Convert.ToInt32(row.Cells["Quantity1"].Value.ToString()) * Convert.ToInt32(row.Cells["Rate1"].Value.ToString());
                    grand_total += Convert.ToInt32(row.Cells["Total1"].Value.ToString());
                    lblGrandTotal1.Text = grand_total.ToString();
                }
                Sale sale_update = new Sale(lblProduct1.Text, lblGrandTotal1.Text);
                AccountingDb.UpdateSale(sale_update, Id);
                grand_total = 0;
            }
        }

        private void dgvProducts1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProducts1.Columns["Image1"].Index && e.RowIndex != -1)
            {
                DataGridViewRow row = dgvProducts1.Rows[e.RowIndex];
                int oldQuantity = AccountingDb.GetQuantity("SELECT Product_Quantity FROM Products WHERE Product_Name = '" + row.Cells["Product_Name1"].Value.ToString() + "';");
                int newQuantity = oldQuantity + Convert.ToInt32(row.Cells["Quantity1"].Value.ToString());
                AccountingDb.UpdateQuantity(newQuantity.ToString(), row.Cells["Product_Name1"].Value.ToString());
                AccountingDb.DeleteSaleProduct(Id, row.Cells["Product_Name1"].Value.ToString());
                grand_total = Convert.ToInt32(lblGrandTotal1.Text);
                grand_total -= Convert.ToInt32(row.Cells["Total1"].Value.ToString());
                lblGrandTotal1.Text = grand_total.ToString();
                grand_total = 0;
                int rowIndex = dgvProducts1.CurrentCell.RowIndex;
                dgvProducts1.Rows.RemoveAt(rowIndex);
                lblProduct1.Text = dgvProducts1.Rows.Count.ToString();
                Sale sale_update = new Sale(lblProduct1.Text, lblGrandTotal1.Text);
                AccountingDb.UpdateSale(sale_update, Id);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCustomerName.SelectedIndex == 0)
            {
                MessageBox.Show("Please select customer.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (dgvProducts.Rows.Count == 0)
            {
                MessageBox.Show("Please add product.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (cbReceived1.Checked)
                    status = "Received";
                else
                    status = "Not Received";

                Sale sale = new Sale(cmbCustomerName.SelectedItem.ToString(), dtpDate.Text, lblProduct.Text, lblGrandTotal.Text, status);
                AccountingDb.SaveSale(sale);
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    Product product = new Product(row.Cells["Product_Name"].Value.ToString(), row.Cells["Quantity"].Value.ToString(), row.Cells["Rate"].Value.ToString());
                    AccountingDb.SaveSaleProducts(product);
                    int oldQuantity = AccountingDb.GetQuantity("SELECT Product_Quantity FROM Products WHERE Product_Name = '" + row.Cells["Product_Name"].Value.ToString() + "';");
                    int newQuantity = oldQuantity - Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
                    AccountingDb.UpdateQuantity(newQuantity.ToString(), row.Cells["Product_Name"].Value.ToString());
                }
                EmptyBox();
            }
        }

        private void tpAddSale_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageSale_Enter(object sender, EventArgs e)
        {
            txtSearchAll.Clear();
            AccountingDb.DisplayAndSearch("SELECT Sale_Id, Sale_Date, Customer_Name, Customer_Phone, Sale_Total_Product, Sale_Grand_Total, Sale_Status FROM Customers INNER JOIN Sales ON Customer_Id = Sale_Customer_Id;", dgvSales);
            lblTotal.Text = dgvSales.Rows.Count.ToString();
        }

        private void txtSearchAll_TextChanged(object sender, EventArgs e)
        {
            AccountingDb.DisplayAndSearch("SELECT Sale_Id, Sale_Date, Customer_Name, Customer_Phone, Sale_Total_Product, Sale_Grand_Total, Sale_Status FROM Customers INNER JOIN Sales ON Customer_Id = Sale_Customer_Id WHERE Sale_Id LIKE '%" + txtSearchAll.Text + "%' OR Customer_Name LIKE '%" + txtSearchAll.Text + "%' OR Sale_Date LIKE '%" + txtSearchAll.Text + "%' OR Customer_Phone LIKE '%" + txtSearchAll.Text + "%';", dgvSales);
            lblTotal.Text = dgvSales.Rows.Count.ToString();
        }

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != dgvSales.Columns["Column8"].Index)
            {
                DataGridViewRow dgv_row = dgvSales.Rows[e.RowIndex];
                Id = dgv_row.Cells["Column1"].Value.ToString();
                FillCustomerName1();
                cmbCustomerName1.SelectedItem = dgv_row.Cells["Column3"].Value.ToString();
                dtpDate1.Text = dgv_row.Cells["Column2"].Value.ToString();
                if (dgv_row.Cells["Column7"].Value.ToString() == "Received")
                    cbReceived1.Checked = true;
                tcSale.SelectedTab = tpUpdateAndDeleteSale;
            }
            if(e.RowIndex != -1 && e.ColumnIndex == dgvSales.Columns["Column8"].Index)
            {
                DataGridViewRow dgv_row = dgvSales.Rows[e.RowIndex];
                i = 1;
                grand = 0;
                easyHTMLReports.Clear();
                easyHTMLReports.AddImage(Resources.accountinf_transparent, "width=100, style='float:right'");
                easyHTMLReports.AddString("<h1>SALE INVOICE</h1>");
                easyHTMLReports.AddString("<h3><i>" + dgv_row.Cells["Column1"].Value.ToString() + "</i></h3>");
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddString("<h3>Customer Detail:</h3>");
                DataTable dt_customer = new DataTable();
                dt_customer.Columns.Add("NAME");
                dt_customer.Columns.Add("PHONE #");
                dt_customer.Columns.Add("ADDRESS");
                SqlDataReader sdr_customer = AccountingDb.GetProduct("SELECT Customer_Name, Customer_Phone, Customer_Address FROM Customers INNER JOIN Sales ON Customer_Id = Sale_Customer_Id WHERE Sale_Id = '" + dgv_row.Cells["Column1"].Value.ToString() + "';");
                do
                {
                    while (sdr_customer.Read())
                    {
                        string[] row =
                            {
                            sdr_customer["Customer_Name"].ToString(), sdr_customer["Customer_Phone"].ToString(), sdr_customer["Customer_Address"].ToString()
                    };
                        dt_customer.Rows.Add(row);
                    }
                } while (sdr_customer.NextResult());
                easyHTMLReports.AddDataTable(dt_customer);
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddString("<h3>Sale Products:</h3>");
                DataTable dt_product = new DataTable();
                dt_product.Columns.Add("#");
                dt_product.Columns.Add("NAME");
                dt_product.Columns.Add("DESCRIPTION");
                dt_product.Columns.Add("QUANTITY");
                dt_product.Columns.Add("RATE");
                dt_product.Columns.Add("TOTAL");
                
                SqlDataReader sdr_product = AccountingDb.GetProduct("SELECT Product_Name, Product_Description, Sale_Product_Quantity, Sale_Product_Rate FROM Products INNER JOIN Sale_Products ON Product_Id = Sale_Product_Product_Id WHERE Sale_Product_Sale_Id = '" + dgv_row.Cells["Column1"].Value.ToString() + "';");
                do
                {
                    while (sdr_product.Read())
                    {
                        string[] row =
                            {
                            i.ToString(), sdr_product["Product_Name"].ToString(), sdr_product["Product_Description"].ToString(), sdr_product["Sale_Product_Quantity"].ToString(), sdr_product["Sale_Product_Rate"].ToString(), (Convert.ToInt32(sdr_product["Sale_Product_Rate"].ToString()) * Convert.ToInt32(sdr_product["Sale_Product_Quantity"].ToString())).ToString()
                    };
                        dt_product.Rows.Add(row);
                        i++;
                        grand += Convert.ToInt32(sdr_product["Sale_Product_Rate"].ToString()) * Convert.ToInt32(sdr_product["Sale_Product_Quantity"].ToString());
                    }
                } while (sdr_product.NextResult());
                easyHTMLReports.AddDataTable(dt_product);
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddString("Grand Total: Rs " + grand.ToString());
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddString("Cash: " + dgv_row.Cells["Column7"].Value.ToString());
                easyHTMLReports.ShowPrintPreviewDialog();
            }
        }

        private void tpUpdateAndDeleteSale_Enter(object sender, EventArgs e)
        {
            if (Id == "")
            {
                tcSale.SelectedTab = tpManageSale;
                return;
            }
            FillProduct1();
            SqlDataReader sdr = AccountingDb.GetProduct("SELECT Product_Name, Sale_Product_Quantity, Sale_Product_Rate FROM Products INNER JOIN Sale_Products ON Product_Id = Sale_Product_Product_Id WHERE Sale_Product_Sale_Id = '" + Id + "';");
            do
            {
                while (sdr.Read())
                {
                    string[] row =
                        {
                            sdr["Product_Name"].ToString(), sdr["Sale_Product_Quantity"].ToString(), sdr["Sale_Product_Rate"].ToString(), (Convert.ToInt32(sdr["Sale_Product_Rate"].ToString()) * Convert.ToInt32(sdr["Sale_Product_Quantity"].ToString())).ToString()
                        };
                    dgvProducts1.Rows.Add(row);
                    lblProduct1.Text = dgvProducts1.Rows.Count.ToString();
                    grand_total += Convert.ToInt32(sdr["Sale_Product_Rate"].ToString()) * Convert.ToInt32(sdr["Sale_Product_Quantity"].ToString());
                    lblGrandTotal1.Text = grand_total.ToString();
                }
            } while (sdr.NextResult());
            grand_total = 0;
        }

        private void tpUpdateAndDeleteSale_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cmbCustomerName1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select customer.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (cbReceived1.Checked)
                    status = "Received";
                else
                    status = "Not Received";

                AccountingDb.UpdateSaleNameDateAndStatus(cmbCustomerName1.SelectedItem.ToString(), dtpDate1.Text, Id, status);
                EmptyBox1();
                tcSale.SelectedTab = tpManageSale;
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
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this sale?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    AccountingDb.DeleteSaleProduct(Id);
                    AccountingDb.DeleteSale(Id);
                    EmptyBox1();
                    tcSale.SelectedTab = tpManageSale;
                }
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbProduct.SelectedIndex != 0)
            {
                sdr = AccountingDb.RateAndQuantity(cmbProduct.SelectedItem.ToString());
                txtQuantity.Text = "1";
                txtRate.Text = sdr["Product_Rate"].ToString();
            }
            else
            {
                txtQuantity.Clear();
                txtRate.Clear();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex != 0 && txtQuantity.Text != string.Empty)
            {
                sdr = AccountingDb.RateAndQuantity(cmbProduct.SelectedItem.ToString());
                if(Convert.ToInt32(txtQuantity.Text) > Convert.ToInt32(sdr["Product_Quantity"].ToString()))
                    txtQuantity.Text = sdr["Product_Quantity"].ToString();
            }
        }

        private void cmbProduct1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct1.SelectedIndex != 0)
            {
                sdr = AccountingDb.RateAndQuantity(cmbProduct1.SelectedItem.ToString());
                txtQuantity1.Text = "1";
                txtRate1.Text = sdr["Product_Rate"].ToString();
            }
            else
            {
                txtQuantity1.Clear();
                txtRate1.Clear();
            }
        }

        private void dgvSales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (row.Cells["Column7"].Value.ToString() == "Received")
                    row.Cells["Column7"].Style.ForeColor = Color.Green;
                else
                    row.Cells["Column7"].Style.ForeColor = Color.DarkOrange;
            }
        }

        private void txtQuantity1_TextChanged(object sender, EventArgs e)
        {
            if (cmbProduct1.SelectedIndex != 0 && txtQuantity1.Text != string.Empty)
            {
                sdr = AccountingDb.RateAndQuantity(cmbProduct1.SelectedItem.ToString());
                if (Convert.ToInt32(txtQuantity1.Text) > Convert.ToInt32(sdr["Product_Quantity"].ToString()))
                    txtQuantity1.Text = sdr["Product_Quantity"].ToString();
            }
        }
    }
}
