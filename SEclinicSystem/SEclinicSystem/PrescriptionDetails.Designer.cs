namespace SEclinicSystem
{
    partial class PrescriptionDetails
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExtend = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrescriptionID = new System.Windows.Forms.Label();
            this.lblGPName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.blEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(916, 408);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Extend Prescription";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExtend
            // 
            this.btnExtend.Location = new System.Drawing.Point(283, 579);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(151, 43);
            this.btnExtend.TabIndex = 2;
            this.btnExtend.Text = "Extend";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(614, 579);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(151, 43);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prescription ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "GP Name:";
            // 
            // lblPrescriptionID
            // 
            this.lblPrescriptionID.AutoSize = true;
            this.lblPrescriptionID.Location = new System.Drawing.Point(474, 12);
            this.lblPrescriptionID.Name = "lblPrescriptionID";
            this.lblPrescriptionID.Size = new System.Drawing.Size(46, 17);
            this.lblPrescriptionID.TabIndex = 8;
            this.lblPrescriptionID.Text = "label1";
            // 
            // lblGPName
            // 
            this.lblGPName.AutoSize = true;
            this.lblGPName.Location = new System.Drawing.Point(474, 60);
            this.lblGPName.Name = "lblGPName";
            this.lblGPName.Size = new System.Drawing.Size(46, 17);
            this.lblGPName.TabIndex = 9;
            this.lblGPName.Text = "label2";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(474, 86);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 17);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "label";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Location = new System.Drawing.Point(351, 35);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(108, 17);
            this.lblAppointmentID.TabIndex = 11;
            this.lblAppointmentID.Text = "AppointmentID: ";
            // 
            // blEndDate
            // 
            this.blEndDate.AutoSize = true;
            this.blEndDate.Location = new System.Drawing.Point(352, 113);
            this.blEndDate.Name = "blEndDate";
            this.blEndDate.Size = new System.Drawing.Size(75, 17);
            this.blEndDate.TabIndex = 13;
            this.blEndDate.Text = "End Date: ";
            this.blEndDate.Visible = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(477, 113);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(243, 22);
            this.dtpEndDate.TabIndex = 14;
            this.dtpEndDate.Visible = false;
            // 
            // PrescriptionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 634);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.blEndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAppointmentID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblGPName);
            this.Controls.Add(this.lblPrescriptionID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExtend);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrescriptionDetails";
            this.Text = "PrescriptionDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrescriptionID;
        private System.Windows.Forms.Label lblGPName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label blEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}