namespace Accounting_Software.PAL.UC
{
    partial class UserControlSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tpUpdateAndDeleteUser = new System.Windows.Forms.TabPage();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtUsername1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSearchUsername = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tcUser = new System.Windows.Forms.TabControl();
            this.tpAddUser = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpManageUser = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tpUpdateAndDeleteUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tcUser.SuspendLayout();
            this.tpAddUser.SuspendLayout();
            this.tpManageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(325, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tpUpdateAndDeleteUser
            // 
            this.tpUpdateAndDeleteUser.Controls.Add(this.txtPassword1);
            this.tpUpdateAndDeleteUser.Controls.Add(this.txtOldPassword);
            this.tpUpdateAndDeleteUser.Controls.Add(this.txtNewPassword);
            this.tpUpdateAndDeleteUser.Controls.Add(this.txtUsername1);
            this.tpUpdateAndDeleteUser.Controls.Add(this.label10);
            this.tpUpdateAndDeleteUser.Controls.Add(this.label11);
            this.tpUpdateAndDeleteUser.Controls.Add(this.label4);
            this.tpUpdateAndDeleteUser.Controls.Add(this.label5);
            this.tpUpdateAndDeleteUser.Controls.Add(this.label9);
            this.tpUpdateAndDeleteUser.Controls.Add(this.btnDelete);
            this.tpUpdateAndDeleteUser.Controls.Add(this.btnUpdate);
            this.tpUpdateAndDeleteUser.Location = new System.Drawing.Point(4, 4);
            this.tpUpdateAndDeleteUser.Name = "tpUpdateAndDeleteUser";
            this.tpUpdateAndDeleteUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateAndDeleteUser.Size = new System.Drawing.Size(934, 571);
            this.tpUpdateAndDeleteUser.TabIndex = 2;
            this.tpUpdateAndDeleteUser.Text = "Update and Delete User";
            this.tpUpdateAndDeleteUser.UseVisualStyleBackColor = true;
            this.tpUpdateAndDeleteUser.Enter += new System.EventHandler(this.tpEditAndDeleteUser_Enter);
            this.tpUpdateAndDeleteUser.Leave += new System.EventHandler(this.tpEditAndDeleteUser_Leave);
            // 
            // txtPassword1
            // 
            this.txtPassword1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtPassword1.Location = new System.Drawing.Point(129, 176);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.ReadOnly = true;
            this.txtPassword1.Size = new System.Drawing.Size(689, 24);
            this.txtPassword1.TabIndex = 2;
            this.txtPassword1.UseSystemPasswordChar = true;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOldPassword.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtOldPassword.Location = new System.Drawing.Point(129, 232);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(689, 24);
            this.txtOldPassword.TabIndex = 3;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtNewPassword.Location = new System.Drawing.Point(129, 288);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(689, 24);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername1
            // 
            this.txtUsername1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtUsername1.Location = new System.Drawing.Point(129, 120);
            this.txtUsername1.Name = "txtUsername1";
            this.txtUsername1.Size = new System.Drawing.Size(689, 24);
            this.txtUsername1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Password:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(126, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Old Password:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "New Password:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "../Update and Delete User";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(129, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 38);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSearchUsername
            // 
            this.txtSearchUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchUsername.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSearchUsername.Location = new System.Drawing.Point(261, 142);
            this.txtSearchUsername.Name = "txtSearchUsername";
            this.txtSearchUsername.Size = new System.Drawing.Size(393, 24);
            this.txtSearchUsername.TabIndex = 1;
            this.txtSearchUsername.TextChanged += new System.EventHandler(this.txtSearchUsername_TextChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.ColumnHeadersHeight = 45;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Location = new System.Drawing.Point(7, 209);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.ShowCellErrors = false;
            this.dgvUsers.ShowEditingIcon = false;
            this.dgvUsers.ShowRowErrors = false;
            this.dgvUsers.Size = new System.Drawing.Size(919, 313);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            this.dgvUsers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUsers_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "User_Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "User_Name";
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "User_Password";
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "../Manage User";
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
            // tcUser
            // 
            this.tcUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcUser.Controls.Add(this.tpAddUser);
            this.tcUser.Controls.Add(this.tpManageUser);
            this.tcUser.Controls.Add(this.tpUpdateAndDeleteUser);
            this.tcUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUser.Location = new System.Drawing.Point(0, 0);
            this.tcUser.Name = "tcUser";
            this.tcUser.SelectedIndex = 0;
            this.tcUser.Size = new System.Drawing.Size(942, 601);
            this.tcUser.TabIndex = 0;
            // 
            // tpAddUser
            // 
            this.tpAddUser.Controls.Add(this.btnAdd);
            this.tpAddUser.Controls.Add(this.txtPassword);
            this.tpAddUser.Controls.Add(this.txtUsername);
            this.tpAddUser.Controls.Add(this.label3);
            this.tpAddUser.Controls.Add(this.label2);
            this.tpAddUser.Controls.Add(this.label1);
            this.tpAddUser.Location = new System.Drawing.Point(4, 4);
            this.tpAddUser.Name = "tpAddUser";
            this.tpAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddUser.Size = new System.Drawing.Size(934, 571);
            this.tpAddUser.TabIndex = 0;
            this.tpAddUser.Text = "Add User";
            this.tpAddUser.UseVisualStyleBackColor = true;
            this.tpAddUser.Enter += new System.EventHandler(this.tpAddUser_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(129, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtPassword.Location = new System.Drawing.Point(129, 176);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(689, 24);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtUsername.Location = new System.Drawing.Point(129, 120);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(689, 24);
            this.txtUsername.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "../Add User";
            // 
            // tpManageUser
            // 
            this.tpManageUser.Controls.Add(this.txtSearchUsername);
            this.tpManageUser.Controls.Add(this.dgvUsers);
            this.tpManageUser.Controls.Add(this.label8);
            this.tpManageUser.Controls.Add(this.lblTotal);
            this.tpManageUser.Controls.Add(this.label6);
            this.tpManageUser.Controls.Add(this.label7);
            this.tpManageUser.Controls.Add(this.picSearch);
            this.tpManageUser.Location = new System.Drawing.Point(4, 4);
            this.tpManageUser.Name = "tpManageUser";
            this.tpManageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageUser.Size = new System.Drawing.Size(934, 571);
            this.tpManageUser.TabIndex = 1;
            this.tpManageUser.Text = "Manage User";
            this.tpManageUser.UseVisualStyleBackColor = true;
            this.tpManageUser.Enter += new System.EventHandler(this.tpManageUser_Enter);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(257, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Username:";
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
            // UserControlSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tcUser);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlSetting";
            this.Size = new System.Drawing.Size(942, 601);
            this.tpUpdateAndDeleteUser.ResumeLayout(false);
            this.tpUpdateAndDeleteUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tcUser.ResumeLayout(false);
            this.tpAddUser.ResumeLayout(false);
            this.tpAddUser.PerformLayout();
            this.tpManageUser.ResumeLayout(false);
            this.tpManageUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabPage tpUpdateAndDeleteUser;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtUsername1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSearchUsername;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tcUser;
        private System.Windows.Forms.TabPage tpAddUser;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpManageUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
