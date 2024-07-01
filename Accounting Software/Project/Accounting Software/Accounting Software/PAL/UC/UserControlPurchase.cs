using System;
using System.Data;
using System.Windows.Forms;
using Accounting_Software.DAL;
using Accounting_Software.BAL;
using System.Data.SqlClient;
using Accounting_Software.Properties;
using System.Drawing;

namespace Accounting_Software.PAL.UC
{
    public partial class UserControlPurchase : UserControl
    {
        private string Id = "", status;
        private bool already_have = true;
        private int grand_total = 0;
        private int i;
        private int grand;

        public UserControlPurchase()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            FillVendorName();
            FillProduct();
            txtQuantity.Clear();
            txtRate.Clear();
            dgvProducts.Rows.Clear();
            lblProduct.Text = "0";
            lblGrandTotal.Text = "0";
            cbPaid.Checked = false;
        }

        private void EmptyBox1()
        {
            FillVendorName1();
            FillProduct1();
            txtQuantity1.Clear();
            txtRate1.Clear();
            dgvProducts1.Rows.Clear();
            lblProduct1.Text = "0";
            lblGrandTotal1.Text = "0";
            cbPaid1.Checked = false;
            Id = "";
        }

        private void FillVendorName()
        {
            cmbVendorName.Items.Clear();
            cmbVendorName.Items.Add("-- SELECT --");
            AccountingDb.FillComboBox("SELECT Vendor_Name FROM Vendors;", cmbVendorName);
            cmbVendorName.SelectedIndex = 0;
        }

        private void FillProduct()
        {
            cmbProduct.Items.Clear();
            cmbProduct.Items.Add("-- SELECT --");
            AccountingDb.FillComboBox("SELECT Product_Name FROM Products;", cmbProduct);
            cmbProduct.SelectedIndex = 0;
        }

        private void FillVendorName1()
        {
            cmbVendorName1.Items.Clear();
            cmbVendorName1.Items.Add("-- SELECT --");
            AccountingDb.FillComboBox("SELECT Vendor_Name FROM Vendors;", cmbVendorName1);
            cmbVendorName1.SelectedIndex = 0;
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
                            int newQuantity = oldQuantity + Convert.ToInt32(txtQuantity1.Text);
                            AccountingDb.UpdateQuantity(newQuantity.ToString(), row.Cells["Product_Name1"].Value.ToString());
                            AccountingDb.UpdatePurchaseProductQuantity(row.Cells["Quantity1"].Value.ToString(), Id, cmbProduct1.SelectedItem.ToString());
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
                        AccountingDb.UpdatePurchaseProducts(product, Id);
                        int oldQuantity = AccountingDb.GetQuantity("SELECT Product_Quantity FROM Products WHERE Product_Name = '" + cmbProduct1.SelectedItem.ToString() + "';");
                        int newQuantity = oldQuantity + Convert.ToInt32(txtQuantity1.Text);
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
                    AccountingDb.UpdatePurchaseProducts(product, Id);
                    int oldQuantity = AccountingDb.GetQuantity("SELECT Product_Quantity FROM Products WHERE Product_Name = '" + cmbProduct1.SelectedItem.ToString() + "';");
                    int newQuantity = oldQuantity + Convert.ToInt32(txtQuantity1.Text);
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
                Purchase purchase_update = new Purchase(lblProduct1.Text, lblGrandTotal1.Text);
                AccountingDb.UpdatePurchase(purchase_update, Id);
                grand_total = 0;
            }
        }

        private void dgvProducts1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProducts1.Columns["Image1"].Index && e.RowIndex != -1)
            {
                DataGridViewRow row = dgvProducts1.Rows[e.RowIndex];
                int oldQuantity = AccountingDb.GetQuantity("SELECT Product_Quantity FROM Products WHERE Product_Name = '" + row.Cells["Product_Name1"].Value.ToString() + "';");
                int newQuantity = oldQuantity - Convert.ToInt32(row.Cells["Quantity1"].Value.ToString());
                AccountingDb.UpdateQuantity(newQuantity.ToString(), row.Cells["Product_Name1"].Value.ToString());
                AccountingDb.DeletePurchaseProduct(Id, row.Cells["Product_Name1"].Value.ToString());
                grand_total = Convert.ToInt32(lblGrandTotal1.Text);
                grand_total -= Convert.ToInt32(row.Cells["Total1"].Value.ToString());
                lblGrandTotal1.Text = grand_total.ToString();
                grand_total = 0;
                int rowIndex = dgvProducts1.CurrentCell.RowIndex;
                dgvProducts1.Rows.RemoveAt(rowIndex);
                lblProduct1.Text = dgvProducts1.Rows.Count.ToString();
                Purchase purchase_update = new Purchase(lblProduct1.Text, lblGrandTotal1.Text);
                AccountingDb.UpdatePurchase(purchase_update, Id);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbVendorName.SelectedIndex == 0)
            {
                MessageBox.Show("Please select vendor.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (dgvProducts.Rows.Count == 0)
            {
                MessageBox.Show("Please add product.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (cbPaid.Checked)
                    status = "Paid";
                else
                    status = "Not Paid";

                Purchase purchase = new Purchase(cmbVendorName.SelectedItem.ToString(), dtpDate.Text, lblProduct.Text, lblGrandTotal.Text, status);
                AccountingDb.SavePurchase(purchase);
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    Product product = new Product(row.Cells["Product_Name"].Value.ToString(), row.Cells["Quantity"].Value.ToString(), row.Cells["Rate"].Value.ToString());
                    AccountingDb.SavePurchaseProducts(product);
                    int oldQuantity = AccountingDb.GetQuantity("SELECT Product_Quantity FROM Products WHERE Product_Name = '" + row.Cells["Product_Name"].Value.ToString() + "';");
                    int newQuantity = oldQuantity + Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
                    AccountingDb.UpdateQuantity(newQuantity.ToString(), row.Cells["Product_Name"].Value.ToString());
                }
                EmptyBox();
            }
        }

        private void tpAddPurchase_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManagePurchase_Enter(object sender, EventArgs e)
        {
            txtSearchAll.Clear();
            AccountingDb.DisplayAndSearch("SELECT Purchase_Id, Purchase_Date, Vendor_Name, Vendor_Phone, Purchase_Total_Product, Purchase_Grand_Total, Purchase_Status FROM Vendors INNER JOIN Purchases ON Vendor_Id = Purchase_Vendor_Id;", dgvPurchases);
            lblTotal.Text = dgvPurchases.Rows.Count.ToString();
        }

        private void txtSearchAll_TextChanged(object sender, EventArgs e)
        {
            AccountingDb.DisplayAndSearch("SELECT Purchase_Id, Purchase_Date, Vendor_Name, Vendor_Phone, Purchase_Total_Product, Purchase_Grand_Total, Purchase_Status FROM Vendors INNER JOIN Purchases ON Vendor_Id = Purchase_Vendor_Id WHERE Purchase_Id LIKE '%" + txtSearchAll.Text + "%' OR Vendor_Name LIKE '%" + txtSearchAll.Text + "%' OR Purchase_Date LIKE '%" + txtSearchAll.Text + "%' OR Vendor_Phone LIKE '%" + txtSearchAll.Text + "%';", dgvPurchases);
            lblTotal.Text = dgvPurchases.Rows.Count.ToString();
        }

        private void dgvPurchases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != dgvPurchases.Columns["Column8"].Index)
            {
                DataGridViewRow dgv_row = dgvPurchases.Rows[e.RowIndex];
                Id = dgv_row.Cells["Column1"].Value.ToString();
                FillVendorName1();
                cmbVendorName1.SelectedItem = dgv_row.Cells["Column3"].Value.ToString();
                dtpDate1.Text = dgv_row.Cells["Column2"].Value.ToString();
                if (dgv_row.Cells["Column7"].Value.ToString() == "Paid")
                    cbPaid1.Checked = true;
                tcPurchase.SelectedTab = tpUpdateAndDeletePurchase;
            }
            if(e.RowIndex != -1 && e.ColumnIndex == dgvPurchases.Columns["Column8"].Index)
            {
                DataGridViewRow dgv_row = dgvPurchases.Rows[e.RowIndex];
                i = 1;
                grand = 0;
                easyHTMLReports.Clear();
                easyHTMLReports.AddImage(Resources.accountinf_transparent, "width=100, style='float:right'");
                easyHTMLReports.AddString("<h1>PURCHASE INVOICE</h1>");
                easyHTMLReports.AddString("<h3><i>" + dgv_row.Cells["Column1"].Value.ToString() + "</i></h3>");
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddString("<h3>Vendor Detail:</h3>");
                DataTable dt_vendor = new DataTable();
                dt_vendor.Columns.Add("NAME");
                dt_vendor.Columns.Add("PHONE #");
                dt_vendor.Columns.Add("ADDRESS");
                SqlDataReader sdr_vendor = AccountingDb.GetProduct("SELECT Vendor_Name, Vendor_Phone, Vendor_Address FROM Vendors INNER JOIN Purchases ON Vendor_Id = Purchase_Vendor_Id WHERE Purchase_Id = '" + dgv_row.Cells["Column1"].Value.ToString() + "';");
                do
                {
                    while (sdr_vendor.Read())
                    {
                        string[] row =
                            {
                            sdr_vendor["Vendor_Name"].ToString(), sdr_vendor["Vendor_Phone"].ToString(), sdr_vendor["Vendor_Address"].ToString()
                    };
                        dt_vendor.Rows.Add(row);
                    }
                } while (sdr_vendor.NextResult());
                easyHTMLReports.AddDataTable(dt_vendor);
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddString("<h3>Purchase Products:</h3>");
                DataTable dt_product = new DataTable();
                dt_product.Columns.Add("#");
                dt_product.Columns.Add("NAME");
                dt_product.Columns.Add("QUANTITY");
                dt_product.Columns.Add("RATE");
                dt_product.Columns.Add("TOTAL");
                
                SqlDataReader sdr_product = AccountingDb.GetProduct("SELECT Product_Name, Purchase_Product_Quantity, Purchase_Product_Rate FROM Products INNER JOIN Purchase_Products ON Product_Id = Purchase_Product_Product_Id WHERE Purchase_Product_Purchase_Id = '" + dgv_row.Cells["Column1"].Value.ToString() + "';");
                do
                {
                    while (sdr_product.Read())
                    {
                        string[] row =
                            {
                            i.ToString(), sdr_product["Product_Name"].ToString(), sdr_product["Purchase_Product_Quantity"].ToString(), sdr_product["Purchase_Product_Rate"].ToString(), (Convert.ToInt32(sdr_product["Purchase_Product_Rate"].ToString()) * Convert.ToInt32(sdr_product["Purchase_Product_Quantity"].ToString())).ToString()
                    };
                        dt_product.Rows.Add(row);
                        i++;
                        grand += Convert.ToInt32(sdr_product["Purchase_Product_Rate"].ToString()) * Convert.ToInt32(sdr_product["Purchase_Product_Quantity"].ToString());
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

        private void tpUpdateAndDeletePurchase_Enter(object sender, EventArgs e)
        {
            if (Id == "")
            {
                tcPurchase.SelectedTab = tpManagePurchase;
                return;
            }
            FillProduct1();
            SqlDataReader sdr = AccountingDb.GetProduct("SELECT Product_Name, Purchase_Product_Quantity, Purchase_Product_Rate FROM Products INNER JOIN Purchase_Products ON Product_Id = Purchase_Product_Product_Id WHERE Purchase_Product_Purchase_Id = '" + Id + "';");
            do
            {
                while (sdr.Read())
                {
                    string[] row =
                        {
                            sdr["Product_Name"].ToString(), sdr["Purchase_Product_Quantity"].ToString(), sdr["Purchase_Product_Rate"].ToString(), (Convert.ToInt32(sdr["Purchase_Product_Rate"].ToString()) * Convert.ToInt32(sdr["Purchase_Product_Quantity"].ToString())).ToString()
                        };
                    dgvProducts1.Rows.Add(row);
                    lblProduct1.Text = dgvProducts1.Rows.Count.ToString();
                    grand_total += Convert.ToInt32(sdr["Purchase_Product_Rate"].ToString()) * Convert.ToInt32(sdr["Purchase_Product_Quantity"].ToString());
                    lblGrandTotal1.Text = grand_total.ToString();
                }
            } while (sdr.NextResult());
            grand_total = 0;
        }

        private void tpUpdateAndDeletePurchase_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void dgvPurchases_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvPurchases.Rows)
            {
                if (row.Cells["Column7"].Value.ToString() == "Paid")
                    row.Cells["Column7"].Style.ForeColor = Color.Green;
                else
                    row.Cells["Column7"].Style.ForeColor = Color.DarkOrange;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cmbVendorName1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select vendor.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (cbPaid.Checked)
                    status = "Paid";
                else
                    status = "Not Paid";

                AccountingDb.UpdatePurchaseNameDateAndStatus(cmbVendorName1.SelectedItem.ToString(), dtpDate1.Text, Id, status);
                EmptyBox1();
                tcPurchase.SelectedTab = tpManagePurchase;
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
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this purchase?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    AccountingDb.DeletePurchaseProduct(Id);
                    AccountingDb.DeletePurchase(Id);
                    EmptyBox1();
                    tcPurchase.SelectedTab = tpManagePurchase;
                }
            }
        }
    }
}
