namespace Accounting_Software.PAL.WF
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnVendor = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.userControlSale1 = new Accounting_Software.PAL.UC.UserControlSale();
            this.userControlPurchase1 = new Accounting_Software.PAL.UC.UserControlPurchase();
            this.userControlProduct1 = new Accounting_Software.PAL.UC.UserControlProduct();
            this.userControlCustomer1 = new Accounting_Software.PAL.UC.UserControlCustomer();
            this.userControlSetting1 = new Accounting_Software.PAL.UC.UserControlSetting();
            this.userControlVendor1 = new Accounting_Software.PAL.UC.UserControlVendor();
            this.userControlDashboard1 = new Accounting_Software.PAL.UC.UserControlDashboard();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panel5.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnSale);
            this.panel1.Controls.Add(this.btnPurchase);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnVendor);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 681);
            this.panel1.TabIndex = 1;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::Accounting_Software.Properties.Resources.settings_25px;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(8, 448);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(250, 47);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Text = "          Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnSale
            // 
            this.btnSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.Image = global::Accounting_Software.Properties.Resources.receipt_25px;
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(8, 401);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(250, 47);
            this.btnSale.TabIndex = 0;
            this.btnSale.Text = "          Sale";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Image = global::Accounting_Software.Properties.Resources.purchase_order_25px;
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Location = new System.Drawing.Point(8, 354);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(250, 47);
            this.btnPurchase.TabIndex = 0;
            this.btnPurchase.Text = "          Purchase";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::Accounting_Software.Properties.Resources.product_25px1;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(8, 307);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(250, 47);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "          Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnVendor
            // 
            this.btnVendor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendor.FlatAppearance.BorderSize = 0;
            this.btnVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendor.ForeColor = System.Drawing.Color.White;
            this.btnVendor.Image = global::Accounting_Software.Properties.Resources.food_truck_25px;
            this.btnVendor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendor.Location = new System.Drawing.Point(8, 260);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(250, 47);
            this.btnVendor.TabIndex = 0;
            this.btnVendor.Text = "          Vendor";
            this.btnVendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVendor.UseVisualStyleBackColor = true;
            this.btnVendor.Click += new System.EventHandler(this.btnVendor_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::Accounting_Software.Properties.Resources.customer_25px;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(8, 213);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(250, 47);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "          Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Accounting_Software.Properties.Resources.icons8_billboard_25px;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(8, 166);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(250, 47);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "          Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlSlide);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 515);
            this.panel4.TabIndex = 1;
            // 
            // pnlSlide
            // 
            this.pnlSlide.BackColor = System.Drawing.Color.White;
            this.pnlSlide.Location = new System.Drawing.Point(0, 0);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(8, 47);
            this.pnlSlide.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 166);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accounting Software";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting_Software.Properties.Resources.calculator_127px;
            this.pictureBox1.Location = new System.Drawing.Point(89, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.picMinimize);
            this.panel2.Controls.Add(this.picClose);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(258, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 69);
            this.panel2.TabIndex = 2;
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.Image = global::Accounting_Software.Properties.Resources.minimize_window_50px;
            this.picMinimize.Location = new System.Drawing.Point(835, 17);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(35, 35);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 3;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            this.picMinimize.MouseHover += new System.EventHandler(this.picMinimize_MouseHover);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = global::Accounting_Software.Properties.Resources.close_window_50px;
            this.picClose.Location = new System.Drawing.Point(879, 17);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 35);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 4;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseHover += new System.EventHandler(this.picClose_MouseHover);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(134, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(28, 19);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "{?}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Welcome:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.panel5.Controls.Add(this.lblDateAndTime);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(258, 631);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(926, 50);
            this.panel5.TabIndex = 3;
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.ForeColor = System.Drawing.Color.White;
            this.lblDateAndTime.Location = new System.Drawing.Point(535, 14);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(28, 19);
            this.lblDateAndTime.TabIndex = 0;
            this.lblDateAndTime.Text = "{?}";
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.userControlDashboard1);
            this.pnlCenter.Controls.Add(this.userControlSale1);
            this.pnlCenter.Controls.Add(this.userControlPurchase1);
            this.pnlCenter.Controls.Add(this.userControlProduct1);
            this.pnlCenter.Controls.Add(this.userControlCustomer1);
            this.pnlCenter.Controls.Add(this.userControlSetting1);
            this.pnlCenter.Controls.Add(this.userControlVendor1);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(258, 69);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(926, 562);
            this.pnlCenter.TabIndex = 0;
            // 
            // userControlSale1
            // 
            this.userControlSale1.BackColor = System.Drawing.Color.White;
            this.userControlSale1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSale1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlSale1.Location = new System.Drawing.Point(0, 0);
            this.userControlSale1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSale1.Name = "userControlSale1";
            this.userControlSale1.Size = new System.Drawing.Size(926, 562);
            this.userControlSale1.TabIndex = 0;
            this.userControlSale1.Visible = false;
            // 
            // userControlPurchase1
            // 
            this.userControlPurchase1.BackColor = System.Drawing.Color.White;
            this.userControlPurchase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPurchase1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlPurchase1.Location = new System.Drawing.Point(0, 0);
            this.userControlPurchase1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlPurchase1.Name = "userControlPurchase1";
            this.userControlPurchase1.Size = new System.Drawing.Size(926, 562);
            this.userControlPurchase1.TabIndex = 0;
            this.userControlPurchase1.Visible = false;
            // 
            // userControlProduct1
            // 
            this.userControlProduct1.BackColor = System.Drawing.Color.White;
            this.userControlProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlProduct1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlProduct1.Location = new System.Drawing.Point(0, 0);
            this.userControlProduct1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlProduct1.Name = "userControlProduct1";
            this.userControlProduct1.Size = new System.Drawing.Size(926, 562);
            this.userControlProduct1.TabIndex = 0;
            this.userControlProduct1.Visible = false;
            // 
            // userControlCustomer1
            // 
            this.userControlCustomer1.BackColor = System.Drawing.Color.White;
            this.userControlCustomer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCustomer1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlCustomer1.Location = new System.Drawing.Point(0, 0);
            this.userControlCustomer1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlCustomer1.Name = "userControlCustomer1";
            this.userControlCustomer1.Size = new System.Drawing.Size(926, 562);
            this.userControlCustomer1.TabIndex = 0;
            this.userControlCustomer1.Visible = false;
            // 
            // userControlSetting1
            // 
            this.userControlSetting1.BackColor = System.Drawing.Color.White;
            this.userControlSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSetting1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlSetting1.Location = new System.Drawing.Point(0, 0);
            this.userControlSetting1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetting1.Name = "userControlSetting1";
            this.userControlSetting1.Size = new System.Drawing.Size(926, 562);
            this.userControlSetting1.TabIndex = 0;
            this.userControlSetting1.Visible = false;
            // 
            // userControlVendor1
            // 
            this.userControlVendor1.BackColor = System.Drawing.Color.White;
            this.userControlVendor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlVendor1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlVendor1.Location = new System.Drawing.Point(0, 0);
            this.userControlVendor1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlVendor1.Name = "userControlVendor1";
            this.userControlVendor1.Size = new System.Drawing.Size(926, 562);
            this.userControlVendor1.TabIndex = 0;
            this.userControlVendor1.Visible = false;
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.BackColor = System.Drawing.Color.White;
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlDashboard1.Location = new System.Drawing.Point(0, 0);
            this.userControlDashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(926, 562);
            this.userControlDashboard1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting Software";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnVendor;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlSlide;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Timer timerDateAndTime;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnlCenter;
        private UC.UserControlVendor userControlVendor1;
        private UC.UserControlCustomer userControlCustomer1;
        private UC.UserControlSetting userControlSetting1;
        private UC.UserControlProduct userControlProduct1;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnSetting;
        private UC.UserControlPurchase userControlPurchase1;
        private UC.UserControlSale userControlSale1;
        private UC.UserControlDashboard userControlDashboard1;
    }
}