using DGVPrinterHelper;
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
    public partial class UC_P_SellMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_P_SellMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
            listBoxMedicine.Items.Clear();
            query = "select mname,CategoryID from medic where eDate >= getdate() and quantity >'0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicine.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
        private void ClearData()
        {
            txtMediName.Clear();
            cmbxCategory.SelectedItem = null;
            txtPricePerUnit.Clear();
            txtNoOf_Unit.Clear();
            txtTotalPrice.Clear();
           // cmbxCategory.SelectedItem = null;
            guna2DateTimePickerExpireDate.Value = DateTime.Now;

        }

        private void listBoxMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=pharmacyDatabase;Integrated Security=True";


            txtNoOfUnit.Clear();

            String name = listBoxMedicine.GetItemText(listBoxMedicine.SelectedItem);
            txtMediName.Text = name;

            con.Open();


            query = "select mid,Category,eDate,perUnit from medic where mname='" + name + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;

            //ds = fn.getData(query);
            //txtMediId.Text = ds.Tables[0].Rows[0][0].ToString();           
            //guna2DateTimePickerExpireDate.Text= ds.Tables[0].Rows[0][1].ToString();
            //txtPricePerUnit.Text= ds.Tables[0].Rows[0][2].ToString();


            try
            {
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtMediId.Text = sdr["Mid"].ToString();
                    guna2DateTimePickerExpireDate.Text = sdr["eDate"].ToString();
                    cmbxCategory.Text = sdr["Category"].ToString();
                    txtPricePerUnit.Text = sdr["perUnit"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnSync_Click(object sender, EventArgs e)
        {
          
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicine.Items.Clear();
            query = "select mname from medic where mname like '" + txtSearch.Text + "%' and eDate >= getdate() and quantity >'0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicine.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }




        protected int n, totalAmount = 0;
        protected Int64 quantity = 0, newQuantity = 0;

        private void btnAddToCart_Click(object sender, EventArgs e) 
        { 
            if (txtMediId.Text != "")
            {
                query = " select quantity from medic where mid = '" + txtMediId.Text + "' ";
                ds = fn.getData(query);


                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtNoOf_Unit.Text);

                if (newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtMediId.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMediName.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = guna2DateTimePickerExpireDate.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtPricePerUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtNoOf_Unit.Text;
                    guna2DataGridView1.Rows[n].Cells[6].Value = txtTotalPrice.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = cmbxCategory.Text;


                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    totalLabel.Text = "Le." + totalAmount.ToString();

                    query = "update medic set quantity='" + newQuantity + "' where mid='" + txtMediId.Text + "'";
                    fn.setData(query, "Medicine Added");


                }
                else
                {
                    MessageBox.Show("Medicine is out Of stock.\n Only " + quantity + " left", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               


                UC_P_SellMedicine_Load(this, null);

            }
            else
            {
                MessageBox.Show("select Medicine First.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //InsertData();
        }
        int valueAmonut;
        String valueId;
        protected Int64 noOfUnit;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmonut = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception) { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (valueId != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch (Exception)
                {

                }
                finally
                {

                    query = "select quantity from medic where mid = '" + valueId + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfUnit;
                    query = "update medic set quantity = '" + newQuantity + "' where mid = '" + valueId + "'";
                    fn.setData(query, "Medicine Remove From Chat");
                    totalAmount = totalAmount - valueAmonut;
                    totalLabel.Text = "Le. " + totalAmount.ToString();


                }
                UC_P_SellMedicine_Load(this, null);
            }
        }

        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "YOUNG GENERATION PHARMACY\n";
            //print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date:-{0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount :" + totalLabel.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmount = 0;
            totalLabel.Text = "Le. 00";
            guna2DataGridView1.DataSource = 0;
        }

        private void txtMediId_TextChanged(object sender, EventArgs e) 
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.guna2DataGridView1.Rows.Clear();
                ClearData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtNoOf_Unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicine_Load(this, null);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNoOf_Unit.Text != "")
                {
                    Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);
                    Int64 noOfUnit = Int64.Parse(txtNoOf_Unit.Text);
                    Int64 totalAmount = unitPrice * noOfUnit;
                    txtTotalPrice.Text = totalAmount.ToString();

                }
                else
                {
                    txtTotalPrice.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
          
           
        }
        private void InsertData()
        {
            try
           {

                // query = "insert into Sales(Medicine_Name,Unit_Price,No_Of_Unit,Total_Price,Date) values(Medicine_Name='" + txtMediName.Text + "',Unit_Price='" + txtPricePerUnit + "',No_Of_Unit='" + txtNoOf_Unit + "',Total_Price='" + txtTotalPrice + "',Date='" + guna2DateTimePicker1.Value.Date + "')";
                // fn.setData(query, "Medicine Added Successfully");
               SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=pharmacyDatabase;Integrated Security=True");
               con.Open();

               SqlCommand cmd = new SqlCommand("insert into Sales(Medicine_Name,Unit_Price,No_Of_Unit,Total_Price,Date) values (Medicine_Name=@Medicine_Name,Unit_Price=@Unit_Price,No_Of_Unit=@No_Of_Unit,Total_Price=@Total_Price,Date=@Date", con);
               cmd.Parameters.AddWithValue("Medicine_Name", txtMediName.Text);
                cmd.Parameters.AddWithValue("Unit_Price", txtPricePerUnit.Text);
               cmd.Parameters.AddWithValue("No_Of_Unit", txtNoOf_Unit.Text);
               cmd.Parameters.AddWithValue("Total_Price", txtTotalPrice.Text);
               cmd.Parameters.AddWithValue("Date", guna2DateTimePicker1.Value.Date);
               cmd.ExecuteNonQuery();
               con.Close();
            }
           catch(Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
        }

    }
}


       
