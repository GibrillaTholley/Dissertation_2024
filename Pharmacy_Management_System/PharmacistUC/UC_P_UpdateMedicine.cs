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
    public partial class UC_P_UpdateMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-745BTV3\\SQLEXPRESS;Initial Catalog=pharmacyDatabase;Integrated Security=True";



            if (txtMediID.Text != "")
            {
                query = "select * from medic where mid= '" + txtMediID.Text + "'";
                ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMediName.Text = ds.Tables[0].Rows[0]["mname"].ToString();
                    txtMediNumber.Text = ds.Tables[0].Rows[0]["mnumber"].ToString();
                    ManufacturingDate.Text = ds.Tables[0].Rows[0]["mDate"].ToString();
                    ExpireDate.Text = ds.Tables[0].Rows[0]["eDate"].ToString();
                    txtAvailableQuantity.Text = ds.Tables[0].Rows[0]["quantity"].ToString();
                    txtPricePerUnit.Text = ds.Tables[0].Rows[0]["perUnit"].ToString();
                    cmbxCategory.Text= ds.Tables[0].Rows[0]["Category"].ToString();
                    txtUserID.Text = ds.Tables[0].Rows[0]["UserID"].ToString();
                    txtCategoryID.Text = ds.Tables[0].Rows[0]["CategoryID"].ToString();
                   


                }
                else
                {
                    MessageBox.Show("No Medicine With ID : " + txtMediID.Text + "....Exist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                ClearAll();
            }
        }
        private void ClearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtMediNumber.Clear();
            ManufacturingDate.ResetText();
            ExpireDate.ResetText();
            txtAvailableQuantity.Clear();
            txtPricePerUnit.Clear();
          
            if (txtAddQuan.Text != "0") 
            {
                txtAddQuan.Text = "0";
            }
            else
            {
                txtAddQuan.Text = "0";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtAddQuan.Text=="" || txtAvailableQuantity.Text=="" || txtMediName.Text=="" ||txtMediNumber.Text=="" || txtPricePerUnit.Text == "")
            {
                MessageBox.Show("Fell All The Text Boxes ");
            }
            else
            {
                try
                {
                    Int64 quantity = Int64.Parse(txtAvailableQuantity.Text);
                    Int64 addQuantity = Int64.Parse(txtAddQuan.Text);
                    Int64 unitprice = Int64.Parse(txtPricePerUnit.Text);

                    totalQuantity = quantity + addQuantity;

                    query = "update medic set mname='" + txtMediName.Text + "',Category='" + cmbxCategory.Text + "',mnumber='" + txtMediNumber.Text + "',mDate='" + ManufacturingDate.Value.ToString("MM/dd/yyyy") + "',eDate='" + ExpireDate.Value.ToString("MM/dd/yyyy") + "',quantity=" + totalQuantity + ",perUnit=" + Int64.Parse(txtPricePerUnit.Text) + " where mid='" + txtMediID.Text + "'";
                    fn.setData(query, "Medicine Details Updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        private void txtMediID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAvailableQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAddQuan_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
