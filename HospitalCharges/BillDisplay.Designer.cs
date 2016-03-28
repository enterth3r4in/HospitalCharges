namespace HospitalCharges
{
    partial class BillDisplay
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDaysSpentChg = new System.Windows.Forms.Label();
            this.lblMedicationChg = new System.Windows.Forms.Label();
            this.lblSurgicalFees = new System.Windows.Forms.Label();
            this.lblLabFees = new System.Windows.Forms.Label();
            this.lblPhysRehabChg = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.lblMiscChargeTtl = new System.Windows.Forms.Label();
            this.btnCloseBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Bill Breakdown";
            // 
            // lblDaysSpentChg
            // 
            this.lblDaysSpentChg.AutoSize = true;
            this.lblDaysSpentChg.Location = new System.Drawing.Point(12, 56);
            this.lblDaysSpentChg.Name = "lblDaysSpentChg";
            this.lblDaysSpentChg.Size = new System.Drawing.Size(174, 13);
            this.lblDaysSpentChg.TabIndex = 1;
            this.lblDaysSpentChg.Text = "Charges For Days Spent in Hospital";
            // 
            // lblMedicationChg
            // 
            this.lblMedicationChg.AutoSize = true;
            this.lblMedicationChg.Location = new System.Drawing.Point(12, 79);
            this.lblMedicationChg.Name = "lblMedicationChg";
            this.lblMedicationChg.Size = new System.Drawing.Size(121, 13);
            this.lblMedicationChg.TabIndex = 2;
            this.lblMedicationChg.Text = "Charges for Medications";
            // 
            // lblSurgicalFees
            // 
            this.lblSurgicalFees.AutoSize = true;
            this.lblSurgicalFees.Location = new System.Drawing.Point(12, 102);
            this.lblSurgicalFees.Name = "lblSurgicalFees";
            this.lblSurgicalFees.Size = new System.Drawing.Size(115, 13);
            this.lblSurgicalFees.TabIndex = 3;
            this.lblSurgicalFees.Text = "Surgical Fees/Charges";
            // 
            // lblLabFees
            // 
            this.lblLabFees.AutoSize = true;
            this.lblLabFees.Location = new System.Drawing.Point(12, 125);
            this.lblLabFees.Name = "lblLabFees";
            this.lblLabFees.Size = new System.Drawing.Size(95, 13);
            this.lblLabFees.TabIndex = 4;
            this.lblLabFees.Text = "Lab Fees/Charges";
            // 
            // lblPhysRehabChg
            // 
            this.lblPhysRehabChg.AutoSize = true;
            this.lblPhysRehabChg.Location = new System.Drawing.Point(12, 148);
            this.lblPhysRehabChg.Name = "lblPhysRehabChg";
            this.lblPhysRehabChg.Size = new System.Drawing.Size(155, 13);
            this.lblPhysRehabChg.TabIndex = 5;
            this.lblPhysRehabChg.Text = "Physical Rehabilitation Charges";
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.AutoSize = true;
            this.lblTotalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCharges.Location = new System.Drawing.Point(49, 235);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(114, 18);
            this.lblTotalCharges.TabIndex = 6;
            this.lblTotalCharges.Text = "Total Charges";
            // 
            // lblMiscChargeTtl
            // 
            this.lblMiscChargeTtl.AutoSize = true;
            this.lblMiscChargeTtl.Location = new System.Drawing.Point(12, 191);
            this.lblMiscChargeTtl.Name = "lblMiscChargeTtl";
            this.lblMiscChargeTtl.Size = new System.Drawing.Size(98, 13);
            this.lblMiscChargeTtl.TabIndex = 7;
            this.lblMiscChargeTtl.Text = "Total Misc Charges";
            // 
            // btnCloseBill
            // 
            this.btnCloseBill.Location = new System.Drawing.Point(68, 263);
            this.btnCloseBill.Name = "btnCloseBill";
            this.btnCloseBill.Size = new System.Drawing.Size(75, 23);
            this.btnCloseBill.TabIndex = 8;
            this.btnCloseBill.Text = "Close Bill";
            this.btnCloseBill.UseVisualStyleBackColor = true;
            this.btnCloseBill.Click += new System.EventHandler(this.btnCloseBill_Click);
            // 
            // BillDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 298);
            this.Controls.Add(this.btnCloseBill);
            this.Controls.Add(this.lblMiscChargeTtl);
            this.Controls.Add(this.lblTotalCharges);
            this.Controls.Add(this.lblPhysRehabChg);
            this.Controls.Add(this.lblLabFees);
            this.Controls.Add(this.lblSurgicalFees);
            this.Controls.Add(this.lblMedicationChg);
            this.Controls.Add(this.lblDaysSpentChg);
            this.Controls.Add(this.label1);
            this.Name = "BillDisplay";
            this.Text = "Bill Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDaysSpentChg;
        private System.Windows.Forms.Label lblMedicationChg;
        private System.Windows.Forms.Label lblSurgicalFees;
        private System.Windows.Forms.Label lblLabFees;
        private System.Windows.Forms.Label lblPhysRehabChg;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.Label lblMiscChargeTtl;
        private System.Windows.Forms.Button btnCloseBill;
    }
}