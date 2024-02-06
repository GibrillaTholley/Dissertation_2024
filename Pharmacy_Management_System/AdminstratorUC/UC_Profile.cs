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
    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_Profile()
        {
            InitializeComponent();
        }

        public String ID
        {
            set { userNamelabel.Text = value; }
        }


        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            query = "select * from users where username='" + userNamelabel.Text + "'";
            ds = fn.getData(query);
            txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDob.Text = ds.Tables[0].Rows[0][3].ToString();
            txtMobileNo.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtPassword.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
            ClearData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            String email = txtEmail.Text;
            String username = userNamelabel.Text;
            String pass = txtPassword.Text;

            query = "update users set userRole='" + role + "',name='" + name + "',dob='" + dob + "',mobile='" + mobile + "',email='" + email + "',pass='" + pass + "' where username='" + username + "'";
            fn.setData(query, "Profile Updation Successful");
        }

        private void checkBoxProfile_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxProfile.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        private void ClearData()
        {
            txtUserRole.SelectedItem = null;
            txtName.Clear();
            txtDob.Clear();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtPassword.Clear();

        }
    }
}
