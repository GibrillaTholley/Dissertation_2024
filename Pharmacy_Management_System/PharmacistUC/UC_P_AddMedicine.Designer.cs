
namespace Pharmacy_Management_System.PharmacistUC
{
    partial class UC_P_AddMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_P_AddMedicine));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMediId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMediName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMediNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPricePerUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ExpireDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ManufacturingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddMedi = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cmbxCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medicine  Identification Number (ID)";
            // 
            // txtMediId
            // 
            this.txtMediId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediId.DefaultText = "";
            this.txtMediId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMediId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMediId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediId.ForeColor = System.Drawing.Color.Black;
            this.txtMediId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediId.Location = new System.Drawing.Point(178, 342);
            this.txtMediId.Margin = new System.Windows.Forms.Padding(5);
            this.txtMediId.Name = "txtMediId";
            this.txtMediId.PasswordChar = '\0';
            this.txtMediId.PlaceholderText = "";
            this.txtMediId.SelectedText = "";
            this.txtMediId.Size = new System.Drawing.Size(340, 36);
            this.txtMediId.TabIndex = 3;
            this.txtMediId.TextChanged += new System.EventHandler(this.txtMediId_TextChanged);
            this.txtMediId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMediId_KeyPress);
            // 
            // txtMediName
            // 
            this.txtMediName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediName.DefaultText = "";
            this.txtMediName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMediName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMediName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediName.ForeColor = System.Drawing.Color.Black;
            this.txtMediName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediName.Location = new System.Drawing.Point(179, 247);
            this.txtMediName.Margin = new System.Windows.Forms.Padding(5);
            this.txtMediName.Name = "txtMediName";
            this.txtMediName.PasswordChar = '\0';
            this.txtMediName.PlaceholderText = "";
            this.txtMediName.SelectedText = "";
            this.txtMediName.Size = new System.Drawing.Size(340, 36);
            this.txtMediName.TabIndex = 5;
            this.txtMediName.TextChanged += new System.EventHandler(this.txtMediName_TextChanged);
            this.txtMediName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMediName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medicine Name";
            // 
            // txtMediNumber
            // 
            this.txtMediNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediNumber.DefaultText = "";
            this.txtMediNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMediNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMediNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediNumber.ForeColor = System.Drawing.Color.Black;
            this.txtMediNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediNumber.Location = new System.Drawing.Point(178, 438);
            this.txtMediNumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtMediNumber.Name = "txtMediNumber";
            this.txtMediNumber.PasswordChar = '\0';
            this.txtMediNumber.PlaceholderText = "";
            this.txtMediNumber.SelectedText = "";
            this.txtMediNumber.Size = new System.Drawing.Size(340, 36);
            this.txtMediNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Medicine Serial Number";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(655, 283);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(340, 36);
            this.txtQuantity.TabIndex = 9;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(651, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPricePerUnit.DefaultText = "";
            this.txtPricePerUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPricePerUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPricePerUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerUnit.ForeColor = System.Drawing.Color.Black;
            this.txtPricePerUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.Location = new System.Drawing.Point(655, 412);
            this.txtPricePerUnit.Margin = new System.Windows.Forms.Padding(5);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.PasswordChar = '\0';
            this.txtPricePerUnit.PlaceholderText = "";
            this.txtPricePerUnit.SelectedText = "";
            this.txtPricePerUnit.Size = new System.Drawing.Size(340, 36);
            this.txtPricePerUnit.TabIndex = 11;
            this.txtPricePerUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPricePerUnit_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(651, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price Per Unit";
            // 
            // ExpireDate
            // 
            this.ExpireDate.BorderThickness = 1;
            this.ExpireDate.Checked = true;
            this.ExpireDate.CustomFormat = "dd/MM/yyyy";
            this.ExpireDate.FillColor = System.Drawing.Color.White;
            this.ExpireDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpireDate.Location = new System.Drawing.Point(655, 175);
            this.ExpireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ExpireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.Size = new System.Drawing.Size(340, 36);
            this.ExpireDate.TabIndex = 12;
            this.ExpireDate.Value = new System.DateTime(2021, 12, 23, 14, 42, 45, 619);
            // 
            // ManufacturingDate
            // 
            this.ManufacturingDate.BorderThickness = 1;
            this.ManufacturingDate.Checked = true;
            this.ManufacturingDate.CustomFormat = "dd/MM/yyyy";
            this.ManufacturingDate.FillColor = System.Drawing.Color.White;
            this.ManufacturingDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ManufacturingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ManufacturingDate.Location = new System.Drawing.Point(178, 534);
            this.ManufacturingDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ManufacturingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ManufacturingDate.Name = "ManufacturingDate";
            this.ManufacturingDate.Size = new System.Drawing.Size(340, 36);
            this.ManufacturingDate.TabIndex = 13;
            this.ManufacturingDate.Value = new System.DateTime(2021, 12, 24, 10, 50, 26, 261);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(177, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Manufacturing Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(651, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Expire Date";
            // 
            // btnAddMedi
            // 
            this.btnAddMedi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddMedi.BorderRadius = 19;
            this.btnAddMedi.BorderThickness = 1;
            this.btnAddMedi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddMedi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedi.ForeColor = System.Drawing.Color.White;
            this.btnAddMedi.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAddMedi.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddMedi.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedi.Image")));
            this.btnAddMedi.Location = new System.Drawing.Point(655, 497);
            this.btnAddMedi.Name = "btnAddMedi";
            this.btnAddMedi.Size = new System.Drawing.Size(146, 48);
            this.btnAddMedi.TabIndex = 16;
            this.btnAddMedi.Text = "Add Medicine";
            this.btnAddMedi.Click += new System.EventHandler(this.btnAddMedi_Click);
            // 
            // btnReset
            // 
            this.btnReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReset.BorderRadius = 19;
            this.btnReset.BorderThickness = 1;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnReset.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(854, 497);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(146, 48);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Clear";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(177, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Medicine Categories";
            // 
            // cmbxCategory
            // 
            this.cmbxCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbxCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbxCategory.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbxCategory.ItemHeight = 30;
            this.cmbxCategory.Location = new System.Drawing.Point(178, 171);
            this.cmbxCategory.Name = "cmbxCategory";
            this.cmbxCategory.Size = new System.Drawing.Size(338, 36);
            this.cmbxCategory.TabIndex = 20;
            this.cmbxCategory.SelectedIndexChanged += new System.EventHandler(this.UC_P_AddMedicine_Load);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(390, 87);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 21;
            this.txtUserID.Visible = false;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(613, 87);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryID.TabIndex = 22;
            this.txtCategoryID.Visible = false;
            this.txtCategoryID.TextChanged += new System.EventHandler(this.txtCategoryID_TextChanged);
            // 
            // UC_P_AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.cmbxCategory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddMedi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ManufacturingDate);
            this.Controls.Add(this.ExpireDate);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMediNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMediName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMediId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_P_AddMedicine";
            this.Size = new System.Drawing.Size(1104, 770);
            this.Load += new System.EventHandler(this.UC_P_AddMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMediId;
        private Guna.UI2.WinForms.Guna2TextBox txtMediName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMediNumber;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPricePerUnit;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker ExpireDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker ManufacturingDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnAddMedi;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cmbxCategory;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtUserID;
    }
}
