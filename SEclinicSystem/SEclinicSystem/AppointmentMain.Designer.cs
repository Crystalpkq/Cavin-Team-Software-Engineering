namespace SEclinicSystem
{
    partial class AppointmentMain
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
            this.createApt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpName = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.timeList = new System.Windows.Forms.ComboBox();
            this.remark = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // createApt
            // 
            this.createApt.Location = new System.Drawing.Point(12, 206);
            this.createApt.Name = "createApt";
            this.createApt.Size = new System.Drawing.Size(75, 23);
            this.createApt.TabIndex = 0;
            this.createApt.Text = "Create";
            this.createApt.UseVisualStyleBackColor = true;
            this.createApt.Click += new System.EventHandler(this.createApt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Remark";
            // 
            // gpName
            // 
            this.gpName.FormattingEnabled = true;
            this.gpName.Location = new System.Drawing.Point(75, 41);
            this.gpName.Name = "gpName";
            this.gpName.Size = new System.Drawing.Size(265, 21);
            this.gpName.TabIndex = 7;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(75, 127);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(265, 20);
            this.date.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Time";
            // 
            // timeList
            // 
            this.timeList.FormattingEnabled = true;
            this.timeList.Location = new System.Drawing.Point(75, 82);
            this.timeList.Name = "timeList";
            this.timeList.Size = new System.Drawing.Size(265, 21);
            this.timeList.TabIndex = 11;
            // 
            // remark
            // 
            this.remark.FormattingEnabled = true;
            this.remark.Location = new System.Drawing.Point(75, 169);
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(265, 21);
            this.remark.TabIndex = 12;
            // 
            // AppointmentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 241);
            this.Controls.Add(this.remark);
            this.Controls.Add(this.timeList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date);
            this.Controls.Add(this.gpName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createApt);
            this.Name = "AppointmentMain";
            this.Text = "AppoimentMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createApt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox gpName;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox timeList;
        private System.Windows.Forms.ComboBox remark;
    }
}