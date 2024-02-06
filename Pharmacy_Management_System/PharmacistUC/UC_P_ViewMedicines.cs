using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.PharmacistUC
{
    public partial class UC_P_ViewMedicines : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_P_ViewMedicines()
        {
            InitializeComponent();
        }

        private void UC_P_ViewMedicines_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like '"+txtSearch.Text+"%'";
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        String medicineId;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineId = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm","Delete Confirmation !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from medic where Mid = '" + medicineId + "'";
                fn.setData(query, "Medicine Record Deleted Successfully");
                UC_P_ViewMedicines_Load(this, null);

            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
          
        }
      
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            UC_P_ViewMedicines_Load(this, null);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
