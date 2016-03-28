namespace HospitalCharges
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDaysInHospital = new System.Windows.Forms.Label();
            this.tbDaysInHospital = new System.Windows.Forms.TextBox();
            this.tbMedicationChg = new System.Windows.Forms.TextBox();
            this.tbSurgicalFees = new System.Windows.Forms.TextBox();
            this.tbLabFees = new System.Windows.Forms.TextBox();
            this.tbPhysRehabChg = new System.Windows.Forms.TextBox();
            this.lblMedicationChg = new System.Windows.Forms.Label();
            this.lblSurgicalFees = new System.Windows.Forms.Label();
            this.lblLabFees = new System.Windows.Forms.Label();
            this.lblPhysRehabChg = new System.Windows.Forms.Label();
            this.btnCalcBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(197, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDaysInHospital
            // 
            this.lblDaysInHospital.AutoSize = true;
            this.lblDaysInHospital.Location = new System.Drawing.Point(12, 9);
            this.lblDaysInHospital.Name = "lblDaysInHospital";
            this.lblDaysInHospital.Size = new System.Drawing.Size(118, 13);
            this.lblDaysInHospital.TabIndex = 2;
            this.lblDaysInHospital.Text = "Days Spent In Hospital:";
            // 
            // tbDaysInHospital
            // 
            this.tbDaysInHospital.Location = new System.Drawing.Point(172, 6);
            this.tbDaysInHospital.Name = "tbDaysInHospital";
            this.tbDaysInHospital.Size = new System.Drawing.Size(100, 20);
            this.tbDaysInHospital.TabIndex = 1;
            // 
            // tbMedicationChg
            // 
            this.tbMedicationChg.Location = new System.Drawing.Point(172, 32);
            this.tbMedicationChg.Name = "tbMedicationChg";
            this.tbMedicationChg.Size = new System.Drawing.Size(100, 20);
            this.tbMedicationChg.TabIndex = 2;
            // 
            // tbSurgicalFees
            // 
            this.tbSurgicalFees.Location = new System.Drawing.Point(172, 58);
            this.tbSurgicalFees.Name = "tbSurgicalFees";
            this.tbSurgicalFees.Size = new System.Drawing.Size(100, 20);
            this.tbSurgicalFees.TabIndex = 3;
            // 
            // tbLabFees
            // 
            this.tbLabFees.Location = new System.Drawing.Point(172, 84);
            this.tbLabFees.Name = "tbLabFees";
            this.tbLabFees.Size = new System.Drawing.Size(100, 20);
            this.tbLabFees.TabIndex = 4;
            // 
            // tbPhysRehabChg
            // 
            this.tbPhysRehabChg.Location = new System.Drawing.Point(172, 110);
            this.tbPhysRehabChg.Name = "tbPhysRehabChg";
            this.tbPhysRehabChg.Size = new System.Drawing.Size(100, 20);
            this.tbPhysRehabChg.TabIndex = 5;
            // 
            // lblMedicationChg
            // 
            this.lblMedicationChg.AutoSize = true;
            this.lblMedicationChg.Location = new System.Drawing.Point(12, 35);
            this.lblMedicationChg.Name = "lblMedicationChg";
            this.lblMedicationChg.Size = new System.Drawing.Size(88, 13);
            this.lblMedicationChg.TabIndex = 8;
            this.lblMedicationChg.Text = "Medication Fees:";
            // 
            // lblSurgicalFees
            // 
            this.lblSurgicalFees.AutoSize = true;
            this.lblSurgicalFees.Location = new System.Drawing.Point(12, 61);
            this.lblSurgicalFees.Name = "lblSurgicalFees";
            this.lblSurgicalFees.Size = new System.Drawing.Size(74, 13);
            this.lblSurgicalFees.TabIndex = 9;
            this.lblSurgicalFees.Text = "Surgical Fees:";
            // 
            // lblLabFees
            // 
            this.lblLabFees.AutoSize = true;
            this.lblLabFees.Location = new System.Drawing.Point(12, 87);
            this.lblLabFees.Name = "lblLabFees";
            this.lblLabFees.Size = new System.Drawing.Size(54, 13);
            this.lblLabFees.TabIndex = 10;
            this.lblLabFees.Text = "Lab Fees:";
            // 
            // lblPhysRehabChg
            // 
            this.lblPhysRehabChg.AutoSize = true;
            this.lblPhysRehabChg.Location = new System.Drawing.Point(12, 113);
            this.lblPhysRehabChg.Name = "lblPhysRehabChg";
            this.lblPhysRehabChg.Size = new System.Drawing.Size(158, 13);
            this.lblPhysRehabChg.TabIndex = 11;
            this.lblPhysRehabChg.Text = "Physical Rehabilitation Charges:";
            // 
            // btnCalcBill
            // 
            this.btnCalcBill.Location = new System.Drawing.Point(12, 227);
            this.btnCalcBill.Name = "btnCalcBill";
            this.btnCalcBill.Size = new System.Drawing.Size(75, 23);
            this.btnCalcBill.TabIndex = 6;
            this.btnCalcBill.Text = "Calculate Bill";
            this.btnCalcBill.UseVisualStyleBackColor = true;
            this.btnCalcBill.Click += new System.EventHandler(this.btnCalcBill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCalcBill);
            this.Controls.Add(this.lblPhysRehabChg);
            this.Controls.Add(this.lblLabFees);
            this.Controls.Add(this.lblSurgicalFees);
            this.Controls.Add(this.lblMedicationChg);
            this.Controls.Add(this.tbPhysRehabChg);
            this.Controls.Add(this.tbLabFees);
            this.Controls.Add(this.tbSurgicalFees);
            this.Controls.Add(this.tbMedicationChg);
            this.Controls.Add(this.tbDaysInHospital);
            this.Controls.Add(this.lblDaysInHospital);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Hospital Charge Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDaysInHospital;
        private System.Windows.Forms.TextBox tbDaysInHospital;
        private System.Windows.Forms.TextBox tbSurgicalFees;
        private System.Windows.Forms.TextBox tbLabFees;
        private System.Windows.Forms.TextBox tbPhysRehabChg;
        private System.Windows.Forms.TextBox tbMedicationChg;
        private System.Windows.Forms.Label lblMedicationChg;
        private System.Windows.Forms.Label lblSurgicalFees;
        private System.Windows.Forms.Label lblLabFees;
        private System.Windows.Forms.Label lblPhysRehabChg;
        private System.Windows.Forms.Button btnCalcBill;
    }
}

