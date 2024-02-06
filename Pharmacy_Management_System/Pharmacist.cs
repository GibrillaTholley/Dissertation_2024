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
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_P_Dashbord1.Visible = true;
            uC_P_Dashbord1.BringToFront();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
           // PharmacistUC.UC_P_AddMedicine uc = new PharmacistUC.UC_P_AddMedicine();
            //uc.Fillcombo();
            uC_P_Dashbord1.Visible = false;
            uC_P_AddMedicine1.Visible = false;
           uC_P_ViewMedicines1.Visible = false;
            uC_P_UpdateMedicine1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;
            uC_P_SellMedicine1.Visible = false;
            btnDashboard.PerformClick();
           //uC_P_AddMedicine1.Fillcombo();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            

            
            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();
            
            
          //  uC_P_AddMedicine1.Fillcombo();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uC_P_ViewMedicines1.Visible = true;
           uC_P_ViewMedicines1.BringToFront();
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            uC_P_UpdateMedicine1.Visible = true;
            uC_P_UpdateMedicine1.BringToFront();
        }

        private void btnMedicineValiditiyCheck_Click(object sender, EventArgs e)
        {
            uC_P_MedicineValidityCheck1.Visible = true;
            uC_P_MedicineValidityCheck1.BringToFront();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            
        }

        private void uC_P_SellMedicine1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uC_P_SellMedicine1.Visible = true;
            uC_P_SellMedicine1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e){
            this.Close();
          
            Add_Medicine_Category amc = new Add_Medicine_Category();
            amc.Show();
        }
    }
}
