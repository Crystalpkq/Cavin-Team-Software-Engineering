namespace SEclinicSystem
{
    partial class PrescriptionAddNew
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
            this.txtGPName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAppointmentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreatePrescription = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name: ";
            // 
            // txtGPName
            // 
            this.txtGPName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGPName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGPName.Location = new System.Drawing.Point(129, 228);
            this.txtGPName.Name = "txtGPName";
            this.txtGPName.Size = new System.Drawing.Size(373, 22);
            this.txtGPName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "GP Name: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(526, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(532, 460);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAppointmentID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAppointmentID.Location = new System.Drawing.Point(129, 290);
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(241, 22);
            this.txtAppointmentID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Appointment ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "End Date: ";
            // 
            // btnCreatePrescription
            // 
            this.btnCreatePrescription.Location = new System.Drawing.Point(129, 431);
            this.btnCreatePrescription.Name = "btnCreatePrescription";
            this.btnCreatePrescription.Size = new System.Drawing.Size(172, 38);
            this.btnCreatePrescription.TabIndex = 9;
            this.btnCreatePrescription.Text = "Create Prescription";
            this.btnCreatePrescription.UseVisualStyleBackColor = true;
            this.btnCreatePrescription.Click += new System.EventHandler(this.btnCreatePrescription_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "New Prescription";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(129, 348);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(241, 22);
            this.dtpEndDate.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 38);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(129, 163);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(373, 22);
            this.txtPatientName.TabIndex = 13;
            // 
            // PrescriptionAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 503);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreatePrescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAppointmentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtGPName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrescriptionAddNew";
            this.Text = "PrescriptionAddNew";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGPName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreatePrescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPatientName;
    }
}