using System;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Login : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {


            query = "select * from users";
            ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                if (txtUsername.Text == "root" && txtpassword.Text == "root")
                {
                    Adminstrator admin = new Adminstrator();
                    admin.Show();
                    this.Hide();
                }

                else
                {

                    query = "select * From users where username = '" + txtUsername.Text + "'  and pass= '" + txtpassword.Text + "'";
                    ds = fn.getData(query);

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        String role = ds.Tables[0].Rows[0][1].ToString();
                        if (role == "Adminstrator")
                        {
                            Adminstrator admin = new Adminstrator(txtUsername.Text);
                            admin.Show();
                            this.Hide();

                        }
                        else if (role == "Pharmacist")
                        {
                            Pharmacist Pharma = new Pharmacist();
                            Pharma.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Pharmacy Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpassword.Clear();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }
    }
}
