
namespace Pharmacy_Management_System
{
    partial class Adminstrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminstrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userNamelabel = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Profile1 = new Pharmacy_Management_System.AdminstratorUC.UC_Profile();
            this.uC_ViewUser1 = new Pharmacy_Management_System.AdminstratorUC.UC_ViewUser();
            this.uC_AddUser1 = new Pharmacy_Management_System.AdminstratorUC.UC_AddUser();
            this.uC_Dashboard1 = new Pharmacy_Management_System.AdminstratorUC.UC_Dashboard();
            this.btnSaleReports = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnSaleReports);
            this.panel1.Controls.Add(this.userNamelabel);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnViewUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 730);
            this.panel1.TabIndex = 0;
            // 
            // userNamelabel
            // 
            this.userNamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNamelabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNamelabel.ForeColor = System.Drawing.Color.Yellow;
            this.userNamelabel.Location = new System.Drawing.Point(69, 682);
            this.userNamelabel.Name = "userNamelabel";
            this.userNamelabel.Size = new System.Drawing.Size(121, 29);
            this.userNamelabel.TabIndex = 8;
            this.userNamelabel.Text = "User Name";
            this.userNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogout.Location = new System.Drawing.Point(0, 621);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(275, 45);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProfile.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnProfile.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProfile.Location = new System.Drawing.Point(0, 562);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(275, 45);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewUser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewUser.Image")));
            this.btnViewUser.Location = new System.Drawing.Point(0, 443);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(275, 45);
            this.btnViewUser.TabIndex = 5;
            this.btnViewUser.Text = "View User";
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddUser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.Location = new System.Drawing.Point(0, 374);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(275, 45);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(0, 313);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(272, 45);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adminstrator";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(279, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 729);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel1;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel1;
            // 
            // uC_Profile1
            // 
            this.uC_Profile1.BackColor = System.Drawing.Color.White;
            this.uC_Profile1.Location = new System.Drawing.Point(264, 0);
            this.uC_Profile1.Name = "uC_Profile1";
            this.uC_Profile1.Size = new System.Drawing.Size(1104, 770);
            this.uC_Profile1.TabIndex = 6;
            // 
            // uC_ViewUser1
            // 
            this.uC_ViewUser1.BackColor = System.Drawing.Color.White;
            this.uC_ViewUser1.Location = new System.Drawing.Point(264, 0);
            this.uC_ViewUser1.Name = "uC_ViewUser1";
            this.uC_ViewUser1.Size = new System.Drawing.Size(1104, 7740);
            this.uC_ViewUser1.TabIndex = 5;
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.BackColor = System.Drawing.Color.White;
            this.uC_AddUser1.Location = new System.Drawing.Point(264, 0);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(1104, 770);
            this.uC_AddUser1.TabIndex = 4;
            this.uC_AddUser1.Load += new System.EventHandler(this.uC_AddUser1_Load);
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_Dashboard1.Location = new System.Drawing.Point(264, 0);
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Size = new System.Drawing.Size(1104, 770);
            this.uC_Dashboard1.TabIndex = 3;
            // 
            // btnSaleReports
            // 
            this.btnSaleReports.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSaleReports.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSaleReports.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSaleReports.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaleReports.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleReports.ForeColor = System.Drawing.Color.White;
            this.btnSaleReports.Image = ((System.Drawing.Image)(resources.GetObject("btnSaleReports.Image")));
            this.btnSaleReports.Location = new System.Drawing.Point(3, 506);
            this.btnSaleReports.Name = "btnSaleReports";
            this.btnSaleReports.Size = new System.Drawing.Size(275, 45);
            this.btnSaleReports.TabIndex = 9;
            this.btnSaleReports.Text = "Sales Reports";
            this.btnSaleReports.Click += new System.EventHandler(this.btnSaleReports_Click);
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel1;
            // 
            // Adminstrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.uC_Profile1);
            this.Controls.Add(this.uC_ViewUser1);
            this.Controls.Add(this.uC_AddUser1);
            this.Controls.Add(this.uC_Dashboard1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminstrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminstrator";
            this.Load += new System.EventHandler(this.Adminstrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnViewUser;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userNamelabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AdminstratorUC.UC_Dashboard uC_Dashboard1;
        private AdminstratorUC.UC_AddUser uC_AddUser1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AdminstratorUC.UC_ViewUser uC_ViewUser1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AdminstratorUC.UC_Profile uC_Profile1;
        private Guna.UI2.WinForms.Guna2Button btnSaleReports;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
    }
}