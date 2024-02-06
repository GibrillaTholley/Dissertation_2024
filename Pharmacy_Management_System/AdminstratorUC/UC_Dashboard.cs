using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.AdminstratorUC
{
    public partial class UC_Dashboard : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole = 'Adminstrator'";
            ds = fn.getData(query);
            setLabel(ds, Adminlabel);

            query = "select count(userRole) from users where userRole = 'Pharmacist'";
            ds = fn.getData(query);
            setLabel(ds, Pharlabel);
        }

        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count!=0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();

            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
          
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            UC_Dashboard_Load(this, null);
        }

        private void uC_Sales_Reports1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
