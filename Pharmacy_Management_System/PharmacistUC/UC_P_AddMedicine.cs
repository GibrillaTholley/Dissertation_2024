using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.PharmacistUC
{
    public  partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        String query;
        
       


        public UC_P_AddMedicine()
        {
            InitializeComponent();
            
        }
      
        private void btnAddMedi_Click(object sender, EventArgs e)
        {
            if(txtMediId.Text!="" && txtMediName.Text!="" && txtMediNumber.Text!="" && txtQuantity.Text!="" && txtPricePerUnit.Text != "")
            {
                             

                query = "insert into medic(mid,mname,Category,mnumber,mdate,edate,quantity,perUnit,UserID,CategoryID) values('" + txtMediId.Text + "','" + txtMediName.Text + "','"+ cmbxCategory.SelectedItem.ToString()+"','" + txtMediNumber.Text + "','" + ManufacturingDate.Value.ToString("MM/dd/yyyy") + "','" + ExpireDate.Value.ToString("MM/dd/yyyy") + "','" + Int64.Parse(txtQuantity.Text) + "','" + Int64.Parse(txtPricePerUnit.Text) + "','"+txtUserID.Text+"','"+txtCategoryID.Text+"')";
                fn.setData(query,"Medicine Added Successfully");
               
            }
            else
            {
                MessageBox.Show("Fill All The Text Box.", "Pharmacy Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
          



        }
        private void ClearAll()
        {
            txtMediId.Clear();
            txtMediName.Clear();
            txtMediNumber.Clear();
            ManufacturingDate.ResetText();
            ExpireDate.ResetText();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            cmbxCategory.SelectedItem = null;
            
        }

        private void txtMediId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPricePerUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMediName_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void UC_P_AddMedicine_Load(object sender, EventArgs e)
        {
           Fillcombo();
        }
        public void Fillcombo()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=pharmacyDatabase;Integrated Security=True";


            SqlCommand cmd = new SqlCommand("select id,CategoryName from  Medicinecategorie ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            con.Open();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
               
                cmbxCategory.Items.Add(dr["CategoryName"].ToString());
            }

            


        }

        private void txtCategoryID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMediId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMediName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
