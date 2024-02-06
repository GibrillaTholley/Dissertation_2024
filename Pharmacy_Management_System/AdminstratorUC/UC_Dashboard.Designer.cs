
namespace Pharmacy_Management_System.AdminstratorUC
{
    partial class UC_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pharlabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.Adminlabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(755, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 566);
            this.panel2.TabIndex = 2;
            // 
            // Pharlabel
            // 
            this.Pharlabel.AutoSize = true;
            this.Pharlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pharlabel.Location = new System.Drawing.Point(1024, 35);
            this.Pharlabel.Name = "Pharlabel";
            this.Pharlabel.Size = new System.Drawing.Size(29, 20);
            this.Pharlabel.TabIndex = 7;
            this.Pharlabel.Text = "60";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(762, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(234, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Total number of Pharmacist \r\n";
            // 
            // btnReload
            // 
            this.btnReload.BorderRadius = 19;
            this.btnReload.BorderThickness = 1;
            this.btnReload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(196, 35);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(95, 40);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "Refresh";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total number of Admin \r\n";
            // 
            // Adminlabel
            // 
            this.Adminlabel.AutoSize = true;
            this.Adminlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminlabel.Location = new System.Drawing.Point(115, 518);
            this.Adminlabel.Name = "Adminlabel";
            this.Adminlabel.Size = new System.Drawing.Size(29, 20);
            this.Adminlabel.TabIndex = 4;
            this.Adminlabel.Text = "60";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.Adminlabel);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(102, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 566);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-23, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1127, 686);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Pharlabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(1104, 770);
            this.Load += new System.EventHandler(this.UC_Dashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Pharlabel;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Adminlabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
