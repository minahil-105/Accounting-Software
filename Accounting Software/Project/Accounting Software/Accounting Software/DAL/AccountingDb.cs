using Accounting_Software.BAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Accounting_Software.DAL
{
    class AccountingDb
    {
        private static SqlConnection GetConnection()
        {
            string sql = @"Data Source = DESKTOP-U69J12E\SQLEXPRESS; Initial Catalog = Accounting_Software; Integrated Security = True;";
            SqlConnection connection = new SqlConnection(sql);
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL connection error!" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        public static bool IsValidNamePass(string name, string password)
        {
            try
            {
                string sql = "SELECT User_Name, User_Password FROM Users WHERE User_Name = '" + name + "' AND User_Password = '" + password + "';";
                SqlConnection conn = GetConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sdp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdp.Fill(dt);
                conn.Close();
                if (dt.Rows.Count > 0)
                    return true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Username and password error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static void AddUser(User user)
        {
            string sql = "INSERT INTO Users VALUES (@Username, @Password);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == 2627)
                    MessageBox.Show("User already exist.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("User didn't add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateUser(User user, string id)
        {
            string sql = "UPDATE Users SET User_Name = @Name, User_Password = @Password WHERE User_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = user.Username;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == 2627)
                    MessageBox.Show("User already exist.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("User didn't update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeleteUser(string Id)
        {
            string sql = "DELETE FROM Users WHERE User_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("User didn't delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
            conn.Close();
        }

        public static void AddCustomer(Customer customer)
        {
            string sql = "INSERT INTO Customers VALUES (@Name, @Phone, @Address);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = customer.Name;
            command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = customer.Phone;
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value = customer.Address;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == 2627)
                    MessageBox.Show("Customer already exist.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Customer didn't add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateCustomer(Customer customer, string id)
        {
            string sql = "UPDATE Customers SET Customer_Name = @Name, Customer_Phone = @Phone, Customer_Address = @Address WHERE Customer_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = customer.Name;
            command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = customer.Phone;
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value = customer.Address;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == 2627)
                    MessageBox.Show("Customer already exist.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Customer didn't update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeleteCustomer(string Id)
        {
            string sql = "DELETE FROM Customers WHERE Customer_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Customer didn't delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void AddVendor(Vendor vendor)
        {
            string sql = "INSERT INTO Vendors VALUES (@Name, @Phone, @Address);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = vendor.Name;
            command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = vendor.Phone;
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value = vendor.Address;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == 2627)
                    MessageBox.Show("Vendor already exist.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Vendor didn't add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateVendor(Vendor vendor, string id)
        {
            string sql = "UPDATE Vendors SET Vendor_Name = @Name, Vendor_Phone = @Phone, Vendor_Address = @Address WHERE Vendor_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = vendor.Name;
            command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = vendor.Phone;
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value = vendor.Address;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == 2627)
                    MessageBox.Show("Vendor already exist.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Vendor didn't update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeleteVendor(string Id)
        {
            string sql = "DELETE FROM Vendors WHERE Vendor_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Vendor didn't delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void AddProduct(Product product)
        {
            string sql = "INSERT INTO Products VALUES (@Name, @Quantity, @Rate, @Description);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = product.Name;
            command.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = product.Quantity;
            command.Parameters.Add("@Rate", SqlDbType.VarChar).Value = product.Rate;
            command.Parameters.Add("@Description", SqlDbType.VarChar).Value = product.Description;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == 2627)
                    MessageBox.Show("Product already exist.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Product didn't add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateProduct(Product product, string id)
        {
            string sql = "UPDATE Products SET Product_Name = @Name, Product_Quantity = @Quantity, Product_Rate = @Rate, Product_Description = @Description WHERE Product_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = product.Name;
            command.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = product.Quantity;
            command.Parameters.Add("@Rate", SqlDbType.VarChar).Value = product.Rate;
            command.Parameters.Add("@Description", SqlDbType.VarChar).Value = product.Description;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == 2627)
                    MessageBox.Show("Product already exist.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Product didn't update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeleteProduct(string Id)
        {
            string sql = "DELETE FROM Products WHERE Product_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Product didn't delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void FillComboBox(string query, ComboBox cb)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                    cb.Items.Add(sdr[0]);
            }
            catch (SqlException)
            {
                MessageBox.Show("Name didn't find.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void SavePurchase(Purchase purchase)
        {
            string sql = "INSERT INTO Purchases VALUES (@Vendor_Id, @Date, @Total_Product, @Grand_Total, @Status);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Vendor_Id", SqlDbType.Int).Value = GetVendorId("SELECT Vendor_Id FROM Vendors WHERE Vendor_Name = '" + purchase.Vendor_Name + "';");
            command.Parameters.Add("@Date", SqlDbType.VarChar).Value = purchase.Date;
            command.Parameters.Add("@Total_Product", SqlDbType.VarChar).Value = purchase.Total_Product;
            command.Parameters.Add("@Grand_Total", SqlDbType.VarChar).Value = purchase.Grand_Total;
            command.Parameters.Add("@Status", SqlDbType.VarChar).Value = purchase.Status;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Purchase didn't save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static int GetVendorId(string query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException)
            {
                MessageBox.Show("Vendor didn't find.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            return 0;
        }

        public static void SavePurchaseProducts(Product product)
        {
            string sql = "INSERT INTO Purchase_Products VALUES (@Purchase_Id, @Product_Id, @Quantity, @Rate);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Purchase_Id", SqlDbType.Int).Value = GetLastPurchaseAddedId("SELECT MAX(Purchase_Id) FROM Purchases;");
            command.Parameters.Add("@Product_Id", SqlDbType.Int).Value = GetProductId("SELECT Product_Id FROM Products WHERE Product_Name = '" + product.Name + "';");
            command.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = product.Quantity;
            command.Parameters.Add("@Rate", SqlDbType.VarChar).Value = product.Rate;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Purchase products didn't save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static int GetLastPurchaseAddedId(string query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException)
            {
                MessageBox.Show("Purchase didn't find.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            return 0;
        }

        public static int GetProductId(string query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException)
            {
                MessageBox.Show("Product didn't find.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            return 0;
        }

        public static int GetQuantity(string query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException)
            {
                MessageBox.Show("Quantity didn't find.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            return 0;
        }

        public static void UpdateQuantity(string quantity, string name)
        {
            string sql = "UPDATE Products SET Product_Quantity = @Quantity WHERE Product_Id = @Id;";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = quantity;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = GetProductId("SELECT Product_Id FROM Products WHERE Product_Name = '" + name + "';");
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Quantity didn't update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static SqlDataReader GetProduct(string sql)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            try { }
            catch (SqlException)
            {
                MessageBox.Show("Product didn't show.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sdr;
        }

        public static SqlDataReader GetVendor(string sql)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            try { }
            catch (SqlException)
            {
                MessageBox.Show("Vendor didn't show.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sdr;
        }

        public static void UpdatePurchase(Purchase purchase, string id)
        {
            string sql = "UPDATE Purchases SET Purchase_Total_Product = @Total_Product, Purchase_Grand_Total = @Grand_Total WHERE Purchase_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Total_Product", SqlDbType.VarChar).Value = purchase.Total_Product;
            command.Parameters.Add("@Grand_Total", SqlDbType.VarChar).Value = purchase.Grand_Total;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Purchase didn't update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeletePurchaseProduct(string purchase_id, string product_name)
        {
            string sql = "DELETE FROM Purchase_Products WHERE Purchase_Product_Purchase_Id = @Purchase_Id AND Purchase_Product_Product_Id = @Product_Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Purchase_Id", SqlDbType.Int).Value = purchase_id;
            command.Parameters.Add("@Product_Id", SqlDbType.Int).Value = GetProductId("SELECT Product_Id FROM Products WHERE Product_Name = '" + product_name + "';");
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Product didn't delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdatePurchaseProducts(Product product, string purchase_id)
        {
            string sql = "INSERT INTO Purchase_Products VALUES (@Purchase_Id, @Product_Id, @Quantity, @Rate);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Purchase_Id", SqlDbType.Int).Value = purchase_id;
            command.Parameters.Add("@Product_Id", SqlDbType.Int).Value = GetProductId("SELECT Product_Id FROM Products WHERE Product_Name = '" + product.Name + "';");
            command.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = product.Quantity;
            command.Parameters.Add("@Rate", SqlDbType.VarChar).Value = product.Rate;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Purchase products didn't update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdatePurchaseProductQuantity(string quantity, string purchase_id, string product_name)
        {
            string sql = "UPDATE Purchase_Products SET Purchase_Product_Quantity = @Quantity WHERE Purchase_Product_Purchase_Id = @Purchase_Id AND Purchase_Product_Product_Id = @Product_Id;";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = quantity;
            cmd.Parameters.Add("@Purchase_Id", SqlDbType.Int).Value = purchase_id;
            cmd.Parameters.Add("@Product_Id", SqlDbType.Int).Value = GetProductId("SELECT Product_Id FROM Products WHERE Product_Name = '" + product_name + "';");
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Purchase product quantity didn't update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void DeletePurchaseProduct(string Id)
        {
            string sql = "DELETE FROM Purchase_Products WHERE Purchase_Product_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Purchase product didn't delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeletePurchase(string Id)
        {
            string sql = "DELETE FROM Purchases WHERE Purchase_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Purchase didn't delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdatePurchaseNameDateAndStatus(string vendor_name, string date, string purchase_id, string status)
        {
            string sql = "UPDATE Purchases SET Purchase_Vendor_Id = @Vendor_Id, Purchase_Date = @Purchase_Date, Purchase_Status= @Purchase_Status WHERE Purchase_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Vendor_Id", SqlDbType.Int).Value = GetCustomerId("SELECT Vendor_Id FROM Vendors WHERE Vendor_Name = '" + vendor_name + "';");
            command.Parameters.Add("@Purchase_Date", SqlDbType.VarChar).Value = date;
            command.Parameters.Add("@Purchase_Status", SqlDbType.VarChar).Value = status;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = purchase_id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Purchase didn't update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void SaveSale(Sale sale)
        {
            string sql = "INSERT INTO Sales VALUES (@Customer_Id, @Date, @Total_Product, @Grand_Total, @Status);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Customer_Id", SqlDbType.Int).Value = GetVendorId("SELECT Customer_Id FROM Customers WHERE Customer_Name = '" + sale.Customer_Name + "';");
            command.Parameters.Add("@Date", SqlDbType.VarChar).Value = sale.Date;
            command.Parameters.Add("@Total_Product", SqlDbType.VarChar).Value = sale.Total_Product;
            command.Parameters.Add("@Grand_Total", SqlDbType.VarChar).Value = sale.Grand_Total;
            command.Parameters.Add("@Status", SqlDbType.VarChar).Value = sale.Status;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Sale didn't save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static int GetCustomerId(string query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException)
            {
                MessageBox.Show("Customer didn't find.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            return 0;
        }

        public static void SaveSaleProducts(Product product)
        {
            string sql = "INSERT INTO Sale_Products VALUES (@Sale_Id, @Product_Id, @Quantity, @Rate);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Sale_Id", SqlDbType.Int).Value = GetLastSaleAddedId("SELECT MAX(Sale_Id) FROM Sales;");
            command.Parameters.Add("@Product_Id", SqlDbType.Int).Value = GetProductId("SELECT Product_Id FROM Products WHERE Product_Name = '" + product.Name + "';");
            command.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = product.Quantity;
            command.Parameters.Add("@Rate", SqlDbType.VarChar).Value = product.Rate;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sale products didn't save."+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static int GetLastSaleAddedId(string query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException)
            {
                MessageBox.Show("Sale didn't find.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            return 0;
        }

        public static SqlDataReader GetCustomer(string sql)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            try { }
            catch (SqlException)
            {
                MessageBox.Show("Customer didn't show.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sdr;
        }

        public static void UpdateSale(Sale sale, string id)
        {
            string sql = "UPDATE Sales SET Sale_Total_Product = @Total_Product, Sale_Grand_Total = @Grand_Total WHERE Sale_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Total_Product", SqlDbType.VarChar).Value = sale.Total_Product;
            command.Parameters.Add("@Grand_Total", SqlDbType.VarChar).Value = sale.Grand_Total;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Sale didn't update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeleteSaleProduct(string sale_id, string product_name)
        {
            string sql = "DELETE FROM Sale_Products WHERE Sale_Product_Sale_Id = @Sale_Id AND Sale_Product_Product_Id = @Product_Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Sale_Id", SqlDbType.Int).Value = sale_id;
            command.Parameters.Add("@Product_Id", SqlDbType.Int).Value = GetProductId("SELECT Product_Id FROM Products WHERE Product_Name = '" + product_name + "';");
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Sale didn't delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateSaleProducts(Product product, string sale_id)
        {
            string sql = "INSERT INTO Sale_Products VALUES (@Sale_Id, @Product_Id, @Quantity, @Rate);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Sale_Id", SqlDbType.Int).Value = sale_id;
            command.Parameters.Add("@Product_Id", SqlDbType.Int).Value = GetProductId("SELECT Product_Id FROM Products WHERE Product_Name = '" + product.Name + "';");
            command.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = product.Quantity;
            command.Parameters.Add("@Rate", SqlDbType.VarChar).Value = product.Rate;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Sale products didn't update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateSaleProductQuantity(string quantity, string sale_id, string product_name)
        {
            string sql = "UPDATE Sale_Products SET Sale_Product_Quantity = @Quantity WHERE Sale_Product_Sale_Id = @Sale_Id AND Sale_Product_Product_Id = @Product_Id;";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = quantity;
            cmd.Parameters.Add("@Sale_Id", SqlDbType.Int).Value = sale_id;
            cmd.Parameters.Add("@Product_Id", SqlDbType.Int).Value = GetProductId("SELECT Product_Id FROM Products WHERE Product_Name = '" + product_name + "';");
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Sale product quantity didn't update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void DeleteSaleProduct(string Id)
        {
            string sql = "DELETE FROM Sale_Products WHERE Sale_Product_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Sale product didn't delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeleteSale(string Id)
        {
            string sql = "DELETE FROM Sales WHERE Sale_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Sale didn't delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateSaleNameDateAndStatus(string customer_name, string date, string sale_id, string status)
        {
            string sql = "UPDATE Sales SET Sale_Customer_Id = @Customer_Id, Sale_Date = @Sale_Date, Sale_Status= @Sale_Status WHERE Sale_Id = @Id;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Customer_Id", SqlDbType.Int).Value = GetCustomerId("SELECT Customer_Id FROM Customers WHERE Customer_Name = '" + customer_name + "';");
            command.Parameters.Add("@Sale_Date", SqlDbType.VarChar).Value = date;
            command.Parameters.Add("@Sale_Status", SqlDbType.VarChar).Value = status;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = sale_id;
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Sale didn't update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static SqlDataReader RateAndQuantity(string name)
        {
            string sql = "SELECT Product_Quantity, Product_Rate FROM Products WHERE Product_Name = @Name;";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
            SqlDataReader sdr = cmd.ExecuteReader();
            try
            {
                sdr.Read();
            }
            catch (SqlException)
            {
                MessageBox.Show("Product rate and quantity didn't find.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sdr;
        }

        public static int Count(string query)
        {
            int rows = 0;
            string sql = query;
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                rows = (int)command.ExecuteScalar();
                return rows;
            }
            catch (SqlException)
            {
            }
            connection.Close();
            return rows;
        }
    }
}
