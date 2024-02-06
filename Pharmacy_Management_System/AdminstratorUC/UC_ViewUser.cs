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
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        String currentUser = "";
        public UC_ViewUser()
        {
            InitializeComponent();
        }

        public String ID
        {
            set { currentUser = value; }
        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users ";
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like'" + txtUserName.Text + "%'";
             ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }


        String userName;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Delete Comfirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {


                if (currentUser != userName)
                {
                    query = "delete from users where username= '" + userName + "'";
                    fn.setData(query, "User Record Deleted");
                    UC_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Confirm", "Pharmacy Management Syetem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }   
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
