using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Add_Medicine_Category : Form
    {
        function fn = new function();
        String query;
        
       
        public Add_Medicine_Category()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCategories.Text == "")
            {
                MessageBox.Show("Add Medicine Category");
            }
            else
            {
                query = "insert into Medicinecategorie(CategoryName) values('" + txtCategories.Text + "')";
                fn.setData(query, "Medicine Added Successfully");
                txtCategories.Clear();

                Pharmacist f = new Pharmacist();
                f.Show();
                this.Hide();
                    
                
            }
          
        }
  
        private void Add_Medicine_Category_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pharmacist ph = new Pharmacist();
            ph.Show();
            this.Hide();
        }
    }
}
