namespace Accounting_Software.PAL.UC
{
    partial class UserControlProduct
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.tpManageProduct = new System.Windows.Forms.TabPage();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpAddProduct = new System.Windows.Forms.TabPage();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tcProduct = new System.Windows.Forms.TabControl();
            this.tpUpdateAndDeleteProduct = new System.Windows.Forms.TabPage();
            this.txtDescription1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRate1 = new System.Windows.Forms.TextBox();
            this.txtQuantity1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tpManageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.tpAddProduct.SuspendLayout();
            this.tcProduct.SuspendLayout();
            this.tpUpdateAndDeleteProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(257, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name:";
            // 
            // tpManageProduct
            // 
            this.tpManageProduct.Controls.Add(this.txtSearchName);
            this.tpManageProduct.Controls.Add(this.dgvProducts);
            this.tpManageProduct.Controls.Add(this.label8);
            this.tpManageProduct.Controls.Add(this.lblTotal);
            this.tpManageProduct.Controls.Add(this.label6);
            this.tpManageProduct.Controls.Add(this.label7);
            this.tpManageProduct.Controls.Add(this.picSearch);
            this.tpManageProduct.Location = new System.Drawing.Point(4, 4);
            this.tpManageProduct.Name = "tpManageProduct";
            this.tpManageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageProduct.Size = new System.Drawing.Size(934, 571);
            this.tpManageProduct.TabIndex = 1;
            this.tpManageProduct.Text = "Manage Product";
            this.tpManageProduct.UseVisualStyleBackColor = true;
            this.tpManageProduct.Enter += new System.EventHandler(this.tpManageProduct_Enter);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSearchName.Location = new System.Drawing.Point(261, 142);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(393, 24);
            this.txtSearchName.TabIndex = 1;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeight = 45;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Location = new System.Drawing.Point(7, 209);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.ShowCellErrors = false;
            this.dgvProducts.ShowEditingIcon = false;
            this.dgvProducts.ShowRowErrors = false;
            this.dgvProducts.Size = new System.Drawing.Size(919, 313);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProducts_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Product_Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Product_Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Product_Quantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Product_Rate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Rate";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Product_Description";
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "../Manage Product";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(51, 525);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(20, 15);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "{?}";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(3, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total:";
            // 
            // picSearch
            // 
            this.picSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.picSearch.Image = global::Accounting_Software.Properties.Resources.icons8_search_64px;
            this.picSearch.Location = new System.Drawing.Point(653, 142);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(26, 24);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 17;
            this.picSearch.TabStop = false;
            this.picSearch.MouseHover += new System.EventHandler(this.picSearch_MouseHover);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(129, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtQuantity.Location = new System.Drawing.Point(129, 176);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(340, 24);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtName.Location = new System.Drawing.Point(129, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(689, 24);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "../Add Product";
            // 
            // tpAddProduct
            // 
            this.tpAddProduct.Controls.Add(this.btnAdd);
            this.tpAddProduct.Controls.Add(this.txtRate);
            this.tpAddProduct.Controls.Add(this.txtQuantity);
            this.tpAddProduct.Controls.Add(this.txtDescription);
            this.tpAddProduct.Controls.Add(this.txtName);
            this.tpAddProduct.Controls.Add(this.label10);
            this.tpAddProduct.Controls.Add(this.label12);
            this.tpAddProduct.Controls.Add(this.label3);
            this.tpAddProduct.Controls.Add(this.label2);
            this.tpAddProduct.Controls.Add(this.label1);
            this.tpAddProduct.Location = new System.Drawing.Point(4, 4);
            this.tpAddProduct.Name = "tpAddProduct";
            this.tpAddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddProduct.Size = new System.Drawing.Size(934, 571);
            this.tpAddProduct.TabIndex = 0;
            this.tpAddProduct.Text = "Add Product";
            this.tpAddProduct.UseVisualStyleBackColor = true;
            this.tpAddProduct.Enter += new System.EventHandler(this.tpAddProduct_Enter);
            // 
            // txtRate
            // 
            this.txtRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtRate.Location = new System.Drawing.Point(475, 176);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(340, 24);
            this.txtRate.TabIndex = 3;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtDescription.Location = new System.Drawing.Point(129, 230);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(689, 85);
            this.txtDescription.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(475, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Rate:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Description:";
            // 
            // tcProduct
            // 
            this.tcProduct.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcProduct.Controls.Add(this.tpAddProduct);
            this.tcProduct.Controls.Add(this.tpManageProduct);
            this.tcProduct.Controls.Add(this.tpUpdateAndDeleteProduct);
            this.tcProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProduct.Location = new System.Drawing.Point(0, 0);
            this.tcProduct.Name = "tcProduct";
            this.tcProduct.SelectedIndex = 0;
            this.tcProduct.Size = new System.Drawing.Size(942, 601);
            this.tcProduct.TabIndex = 0;
            // 
            // tpUpdateAndDeleteProduct
            // 
            this.tpUpdateAndDeleteProduct.Controls.Add(this.txtDescription1);
            this.tpUpdateAndDeleteProduct.Controls.Add(this.label13);
            this.tpUpdateAndDeleteProduct.Controls.Add(this.txtRate1);
            this.tpUpdateAndDeleteProduct.Controls.Add(this.txtQuantity1);
            this.tpUpdateAndDeleteProduct.Controls.Add(this.label11);
            this.tpUpdateAndDeleteProduct.Controls.Add(this.txtName1);
            this.tpUpdateAndDeleteProduct.Controls.Add(this.label4);
            this.tpUpdateAndDeleteProduct.Controls.Add(this.label5);
            this.tpUpdateAndDeleteProduct.Controls.Add(this.label9);
            this.tpUpdateAndDeleteProduct.Controls.Add(this.btnDelete);
            this.tpUpdateAndDeleteProduct.Controls.Add(this.btnUpdate);
            this.tpUpdateAndDeleteProduct.Location = new System.Drawing.Point(4, 4);
            this.tpUpdateAndDeleteProduct.Name = "tpUpdateAndDeleteProduct";
            this.tpUpdateAndDeleteProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateAndDeleteProduct.Size = new System.Drawing.Size(934, 571);
            this.tpUpdateAndDeleteProduct.TabIndex = 2;
            this.tpUpdateAndDeleteProduct.Text = "Update and Delete Product";
            this.tpUpdateAndDeleteProduct.UseVisualStyleBackColor = true;
            this.tpUpdateAndDeleteProduct.Enter += new System.EventHandler(this.tpEditAndDeleteProduct_Enter);
            this.tpUpdateAndDeleteProduct.Leave += new System.EventHandler(this.tpEditAndDeleteProduct_Leave);
            // 
            // txtDescription1
            // 
            this.txtDescription1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtDescription1.Location = new System.Drawing.Point(129, 232);
            this.txtDescription1.Multiline = true;
            this.txtDescription1.Name = "txtDescription1";
            this.txtDescription1.Size = new System.Drawing.Size(689, 85);
            this.txtDescription1.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(126, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Description:";
            // 
            // txtRate1
            // 
            this.txtRate1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRate1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtRate1.Location = new System.Drawing.Point(478, 178);
            this.txtRate1.Name = "txtRate1";
            this.txtRate1.Size = new System.Drawing.Size(340, 24);
            this.txtRate1.TabIndex = 3;
            this.txtRate1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity1_KeyPress);
            // 
            // txtQuantity1
            // 
            this.txtQuantity1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtQuantity1.Location = new System.Drawing.Point(129, 178);
            this.txtQuantity1.Name = "txtQuantity1";
            this.txtQuantity1.Size = new System.Drawing.Size(340, 24);
            this.txtQuantity1.TabIndex = 2;
            this.txtQuantity1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity1_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(475, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Rate:";
            // 
            // txtName1
            // 
            this.txtName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtName1.Location = new System.Drawing.Point(129, 122);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(689, 24);
            this.txtName1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "../Update and Delete Product";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(324, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(129, 359);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 38);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UserControlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tcProduct);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlProduct";
            this.Size = new System.Drawing.Size(942, 601);
            this.tpManageProduct.ResumeLayout(false);
            this.tpManageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.tpAddProduct.ResumeLayout(false);
            this.tpAddProduct.PerformLayout();
            this.tcProduct.ResumeLayout(false);
            this.tpUpdateAndDeleteProduct.ResumeLayout(false);
            this.tpUpdateAndDeleteProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tpManageProduct;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpAddProduct;
        private System.Windows.Forms.TabControl tcProduct;
        private System.Windows.Forms.TabPage tpUpdateAndDeleteProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtQuantity1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRate1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtDescription1;
        private System.Windows.Forms.Label label13;
    }
}
