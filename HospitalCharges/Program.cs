using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Project Name: Hospital Charges
 * Project Purpose: To calculate and display a hospital bill
 * Input: User inputs in text boxes and button clicks
 * Desired Output: Should display a form with properly calculated bill
 * Variables: doubles store inputs
 * Classes: Extra form to display bill cleanly
 * Formulas: Calculations are performed in separate methods, strings concatenated
 * Main Algorithm: Lets user input charges and click buttons, then when they click calculate
 * it writes up the bill and displays it in a separate form which can be closed separately.
 * Date: 3-24-2016
 */
namespace HospitalCharges
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
