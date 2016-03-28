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

        public void writeUpBill()
        {
            lblDaysSpentChg.Text = mainForm.calculateStayCharges();
        }

        
    }
}
