using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalCharges
{
    public partial class BillDisplay : Form
    {
        Form1 mainForm;
        public BillDisplay()
        {
            InitializeComponent();
            mainForm = new Form1();
        }

        public void setDaysSpentCharge(double charge) { lblDaysSpentChg.Text = "Stay Charges: " + charge.ToString("c"); }
        public void setMedicationCharge(double charge) { lblMedicationChg.Text = "Medication: " + charge.ToString("c"); }
        public void setSurgicalCharge(double charge) { lblSurgicalFees.Text = "Surgical Fees: " + charge.ToString("c"); }
        public void setLabFees(double charge) { lblLabFees.Text = "Lab Fees: " + charge.ToString("c"); }
        public void setPhysRehab(double charge) { lblPhysRehabChg.Text = "Physical Rehab Fees: " + charge.ToString("c"); }
        public void setMiscCharges(double charge) { lblMiscChargeTtl.Text = "Miscellaneous Charges: " + charge.ToString("c"); }
        public void setTotalCharges(double charge) { lblTotalCharges.Text = "Total: " + charge.ToString("c"); }

        private void btnCloseBill_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
