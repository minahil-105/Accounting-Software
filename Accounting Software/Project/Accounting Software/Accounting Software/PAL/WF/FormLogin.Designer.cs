namespace Accounting_Software.PAL.WF
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSecureLogin = new System.Windows.Forms.Button();
            this.picError = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(142, 255);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(360, 32);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(142, 142);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(396, 32);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblError.Location = new System.Drawing.Point(186, 318);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(272, 21);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Invalid Username or Password.";
            this.lblError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(138, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(138, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Accounting Software | Login";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnSecureLogin);
            this.groupBox1.Controls.Add(this.picError);
            this.groupBox1.Controls.Add(this.picShow);
            this.groupBox1.Controls.Add(this.picHide);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox1.Location = new System.Drawing.Point(7, 206);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(678, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Login First";
            // 
            // btnSecureLogin
            // 
            this.btnSecureLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.btnSecureLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSecureLogin.FlatAppearance.BorderSize = 0;
            this.btnSecureLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecureLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSecureLogin.ForeColor = System.Drawing.Color.White;
            this.btnSecureLogin.Image = global::Accounting_Software.Properties.Resources.icons8_login_20px;
            this.btnSecureLogin.Location = new System.Drawing.Point(140, 395);
            this.btnSecureLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSecureLogin.Name = "btnSecureLogin";
            this.btnSecureLogin.Size = new System.Drawing.Size(398, 58);
            this.btnSecureLogin.TabIndex = 3;
            this.btnSecureLogin.Text = "Secure Login";
            this.btnSecureLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSecureLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSecureLogin.UseVisualStyleBackColor = false;
            this.btnSecureLogin.Click += new System.EventHandler(this.btnSecureLogin_Click);
            // 
            // picError
            // 
            this.picError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picError.Image = global::Accounting_Software.Properties.Resources.icons8_box_important_64px;
            this.picError.Location = new System.Drawing.Point(140, 311);
            this.picError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(38, 38);
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError.TabIndex = 0;
            this.picError.TabStop = false;
            this.picError.Visible = false;
            // 
            // picShow
            // 
            this.picShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.picShow.Image = global::Accounting_Software.Properties.Resources.icons8_eye_64px;
            this.picShow.Location = new System.Drawing.Point(502, 255);
            this.picShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(36, 36);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 0;
            this.picShow.TabStop = false;
            this.picShow.Click += new System.EventHandler(this.picShow_Click);
            this.picShow.MouseHover += new System.EventHandler(this.picShow_MouseHover);
            // 
            // picHide
            // 
            this.picHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHide.Cursor = System.Windows.Forms.Cursors.Default;
            this.picHide.Image = global::Accounting_Software.Properties.Resources.icons8_hide_64px;
            this.picHide.Location = new System.Drawing.Point(502, 255);
            this.picHide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(36, 36);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHide.TabIndex = 0;
            this.picHide.TabStop = false;
            this.picHide.Visible = false;
            this.picHide.Click += new System.EventHandler(this.picHide_Click);
            this.picHide.MouseHover += new System.EventHandler(this.picHide_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.picMinimize);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Location = new System.Drawing.Point(20, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 72);
            this.panel1.TabIndex = 0;
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.Image = global::Accounting_Software.Properties.Resources.minimize_window_50px;
            this.picMinimize.Location = new System.Drawing.Point(1113, 11);
            this.picMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(52, 54);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 2;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            this.picMinimize.MouseHover += new System.EventHandler(this.picMinimize_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Accounting_Software.Properties.Resources.accountinf_transparent;
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = global::Accounting_Software.Properties.Resources.close_window_50px;
            this.picClose.Location = new System.Drawing.Point(1179, 11);
            this.picClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(52, 54);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseHover += new System.EventHandler(this.picClose_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Accounting_Software.Properties.Resources.accounting;
            this.pictureBox1.Location = new System.Drawing.Point(838, 217);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1285, 860);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting Software | Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSecureLogin;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}