namespace SEclinicSystem
{
    partial class Main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.staffID = new System.Windows.Forms.Label();
            this.staffName = new System.Windows.Forms.Label();
            this.SearchPatient = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.logoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\LENOVO\\Desktop\\ARU\\Software Engineer\\Cavin-Team-Software-Engineering\\use" +
    "r.png";
            this.pictureBox1.Location = new System.Drawing.Point(274, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // staffID
            // 
            this.staffID.AutoSize = true;
            this.staffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffID.Location = new System.Drawing.Point(271, 164);
            this.staffID.Name = "staffID";
            this.staffID.Size = new System.Drawing.Size(52, 17);
            this.staffID.TabIndex = 1;
            this.staffID.Text = "staff ID";
            // 
            // staffName
            // 
            this.staffName.AutoSize = true;
            this.staffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffName.Location = new System.Drawing.Point(271, 192);
            this.staffName.Name = "staffName";
            this.staffName.Size = new System.Drawing.Size(76, 17);
            this.staffName.TabIndex = 2;
            this.staffName.Text = "staff Name";
            // 
            // SearchPatient
            // 
            this.SearchPatient.Location = new System.Drawing.Point(18, 12);
            this.SearchPatient.Name = "SearchPatient";
            this.SearchPatient.Size = new System.Drawing.Size(124, 23);
            this.SearchPatient.TabIndex = 3;
            this.SearchPatient.Text = "Search Patient";
            this.SearchPatient.UseVisualStyleBackColor = true;
            this.SearchPatient.Click += new System.EventHandler(this.SearchPatient_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 244);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(233, 97);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 56);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(274, 318);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 363);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SearchPatient);
            this.Controls.Add(this.staffName);
            this.Controls.Add(this.staffID);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label staffID;
        private System.Windows.Forms.Label staffName;
        private System.Windows.Forms.Button SearchPatient;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button logoutBtn;
    }
}