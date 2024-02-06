using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Pharmacy_Management_System.AdminstratorUC
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            String pass = txtPassword.Text;

            try
            {
                query = "insert into users(userRole,name,dob,mobile,email,username,pass) values('"+ role + "','"+ name + "','"+ dob + "','"+ mobile + "','"+ email + "','"+ username + "','"+ pass + "')";
                fn.setData(query, "Sign Up Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Username Already Exist.", "Pharmacy Management System", MessageBoxButtons.OK,MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearData()
        {
            txtUserRole.SelectedIndex = -1;
            txtName.Clear();
            txtDob.ResetText();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {
            
            query = "select * from users where username='"+txtUsername.Text+"'";
            DataSet ds = fn.getData(query);

            /*if(ds.Tables[0].Rows.Count==0)
            {
                pictureBox1.ImageLocation = @"E:\PROJECT\VEDIOS\OTHER VED\Pharmacy Management System in C#\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"E:\PROJECT\VEDIOS\OTHER VED\Pharmacy Management System in C#\no.png";

            }*/

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1AddUser.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
             

        }
    }
}
