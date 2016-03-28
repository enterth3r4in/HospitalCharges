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
    public partial class Form1 : Form
    {
        //Self-documenting names
        double dailyBaseCharge = 350.0;
        double medicationFees = 0.0;
        double surgicalFees = 0.0;
        double labFees = 0.0;
        double physRehabFees = 0.0;
        //Making days spent in hospital a double for convenience. No one likes converting
        double daysSpentInHospital = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using the program");
            Application.Exit();
        }

        private void btnCalcBill_Click(object sender, EventArgs e)
        {
            //Tries parsing all the fields, failing the whole test if any don't parse correctly
            //Else statement contains the rest of the code so nothing gets done if the parse didn't work
            //Separating these into individual checks would take a lot of additional code so I didn't do
            //personalized checks to determine WHICH type was invalid.
            //Ints entered work as well since it just inherently converts to double if it is a number
            if(!double.TryParse(tbDaysInHospital.Text, out daysSpentInHospital) || !double.TryParse(tbMedicationChg.Text, out medicationFees)
                || !double.TryParse(tbSurgicalFees.Text, out surgicalFees) || !double.TryParse(tbLabFees.Text, out labFees)
                || !double.TryParse(tbPhysRehabChg.Text, out physRehabFees))
            {
                //Alerting user to check ALL inputs to make sure not more than one mistake was made.
                MessageBox.Show("Invalid input, check all inputs and make sure they're only numbers.");
            }
            else
            {
                BillDisplay bill = new BillDisplay();
                bill.writeUpBill();
                bill.Show();
            }
        }

        //Inline getters
        public double getMedicationFees() { return medicationFees; }
        public double getSurgicalFees() { return surgicalFees; }
        public double getLabFees() { return labFees; }
        public double getPhysRehabCharges() { return physRehabFees; }

        //Generally might pass something in, but since all variables are class level, no need.
        public double calculateStayCharges()
        {
            return daysSpentInHospital * dailyBaseCharge; //Single line for compactness and readability
        }

        //Same as above, no need to pass anything in since this method has access to all class vars
        public double calculateMiscCharges()
        {
            return medicationFees + surgicalFees + labFees + physRehabFees;
        }

        //This feels cheaty.... should work though.
        public double calculateTotalBill()
        {
            return calculateStayCharges() + calculateMiscCharges();
        }
    }
}
