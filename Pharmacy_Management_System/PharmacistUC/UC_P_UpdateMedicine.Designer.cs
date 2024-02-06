
namespace Pharmacy_Management_System.PharmacistUC
{
    partial class UC_P_UpdateMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_P_UpdateMedicine));
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ManufacturingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtMediNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMediName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMediID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ExpireDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPricePerUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAvailableQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtAddQuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.cmbxCategory = new System.Windows.Forms.ComboBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Medicine";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(130, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Manufacturing Date";
            // 
            // ManufacturingDate
            // 
            this.ManufacturingDate.BorderThickness = 1;
            this.ManufacturingDate.Checked = true;
            this.ManufacturingDate.CustomFormat = "dd/MM/yyyy";
            this.ManufacturingDate.FillColor = System.Drawing.Color.White;
            this.ManufacturingDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ManufacturingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ManufacturingDate.Location = new System.Drawing.Point(134, 534);
            this.ManufacturingDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ManufacturingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ManufacturingDate.Name = "ManufacturingDate";
            this.ManufacturingDate.Size = new System.Drawing.Size(340, 36);
            this.ManufacturingDate.TabIndex = 21;
            this.ManufacturingDate.Value = new System.DateTime(2021, 12, 24, 10, 50, 26, 261);
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
            this.txtMediNumber.Location = new System.Drawing.Point(134, 447);
            this.txtMediNumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtMediNumber.Name = "txtMediNumber";
            this.txtMediNumber.PasswordChar = '\0';
            this.txtMediNumber.PlaceholderText = "";
            this.txtMediNumber.SelectedText = "";
            this.txtMediNumber.Size = new System.Drawing.Size(340, 36);
            this.txtMediNumber.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Batch Number";
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
            this.txtMediName.Location = new System.Drawing.Point(134, 269);
            this.txtMediName.Margin = new System.Windows.Forms.Padding(5);
            this.txtMediName.Name = "txtMediName";
            this.txtMediName.PasswordChar = '\0';
            this.txtMediName.PlaceholderText = "";
            this.txtMediName.SelectedText = "";
            this.txtMediName.Size = new System.Drawing.Size(340, 36);
            this.txtMediName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Medicine Name";
            // 
            // txtMediID
            // 
            this.txtMediID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediID.DefaultText = "";
            this.txtMediID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMediID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMediID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediID.ForeColor = System.Drawing.Color.Black;
            this.txtMediID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediID.Location = new System.Drawing.Point(136, 154);
            this.txtMediID.Margin = new System.Windows.Forms.Padding(5);
            this.txtMediID.Name = "txtMediID";
            this.txtMediID.PasswordChar = '\0';
            this.txtMediID.PlaceholderText = "";
            this.txtMediID.SelectedText = "";
            this.txtMediID.Size = new System.Drawing.Size(340, 36);
            this.txtMediID.TabIndex = 16;
            this.txtMediID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMediID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Serial Number";
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
            this.btnReset.Location = new System.Drawing.Point(828, 492);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(146, 48);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Clear";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdate.BorderRadius = 19;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(629, 492);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 48);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update Medicine";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(625, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Expire Date";
            // 
            // ExpireDate
            // 
            this.ExpireDate.BorderThickness = 1;
            this.ExpireDate.Checked = true;
            this.ExpireDate.CustomFormat = "dd/MM/yyyy";
            this.ExpireDate.FillColor = System.Drawing.Color.White;
            this.ExpireDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpireDate.Location = new System.Drawing.Point(629, 170);
            this.ExpireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ExpireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.Size = new System.Drawing.Size(340, 36);
            this.ExpireDate.TabIndex = 27;
            this.ExpireDate.Value = new System.DateTime(2021, 12, 23, 14, 42, 45, 619);
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
            this.txtPricePerUnit.Location = new System.Drawing.Point(629, 407);
            this.txtPricePerUnit.Margin = new System.Windows.Forms.Padding(5);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.PasswordChar = '\0';
            this.txtPricePerUnit.PlaceholderText = "";
            this.txtPricePerUnit.SelectedText = "";
            this.txtPricePerUnit.Size = new System.Drawing.Size(340, 36);
            this.txtPricePerUnit.TabIndex = 26;
            this.txtPricePerUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPricePerUnit_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(625, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Price Per Unit";
            // 
            // txtAvailableQuantity
            // 
            this.txtAvailableQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAvailableQuantity.DefaultText = "";
            this.txtAvailableQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAvailableQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAvailableQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAvailableQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAvailableQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAvailableQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtAvailableQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAvailableQuantity.Location = new System.Drawing.Point(629, 278);
            this.txtAvailableQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.txtAvailableQuantity.Name = "txtAvailableQuantity";
            this.txtAvailableQuantity.PasswordChar = '\0';
            this.txtAvailableQuantity.PlaceholderText = "";
            this.txtAvailableQuantity.SelectedText = "";
            this.txtAvailableQuantity.Size = new System.Drawing.Size(340, 36);
            this.txtAvailableQuantity.TabIndex = 24;
            this.txtAvailableQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAvailableQuantity_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(625, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Available Quantity";
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSearch.BorderRadius = 18;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSearch.Location = new System.Drawing.Point(353, 198);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 39);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAddQuan
            // 
            this.txtAddQuan.BorderColor = System.Drawing.Color.Lime;
            this.txtAddQuan.BorderThickness = 3;
            this.txtAddQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddQuan.DefaultText = "0";
            this.txtAddQuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddQuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddQuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddQuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddQuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddQuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQuan.ForeColor = System.Drawing.Color.Black;
            this.txtAddQuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddQuan.Location = new System.Drawing.Point(874, 324);
            this.txtAddQuan.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddQuan.Name = "txtAddQuan";
            this.txtAddQuan.PasswordChar = '\0';
            this.txtAddQuan.PlaceholderText = "";
            this.txtAddQuan.SelectedText = "";
            this.txtAddQuan.SelectionStart = 1;
            this.txtAddQuan.Size = new System.Drawing.Size(95, 36);
            this.txtAddQuan.TabIndex = 33;
            this.txtAddQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddQuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddQuan_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(754, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Add Quantity";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(133, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 21);
            this.label10.TabIndex = 35;
            this.label10.Text = "Medicine Categories";
            // 
            // cmbxCategory
            // 
            this.cmbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxCategory.FormattingEnabled = true;
            this.cmbxCategory.Location = new System.Drawing.Point(140, 362);
            this.cmbxCategory.Name = "cmbxCategory";
            this.cmbxCategory.Size = new System.Drawing.Size(334, 32);
            this.cmbxCategory.TabIndex = 36;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(710, 88);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryID.TabIndex = 38;
            this.txtCategoryID.Visible = false;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(487, 88);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 37;
            this.txtUserID.Visible = false;
            // 
            // UC_P_UpdateMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.cmbxCategory);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAddQuan);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ExpireDate);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAvailableQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ManufacturingDate);
            this.Controls.Add(this.txtMediNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMediName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMediID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_P_UpdateMedicine";
            this.Size = new System.Drawing.Size(1104, 770);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker ManufacturingDate;
        private Guna.UI2.WinForms.Guna2TextBox txtMediNumber;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtMediName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMediID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker ExpireDate;
        private Guna.UI2.WinForms.Guna2TextBox txtPricePerUnit;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtAvailableQuantity;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtAddQuan;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbxCategory;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtUserID;
    }
}
