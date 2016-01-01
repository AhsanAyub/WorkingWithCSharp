namespace PatientCare
{
    partial class ArrivalOfPattient
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.setDoctorName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.oldPatient = new Syncfusion.Windows.Forms.ButtonAdv();
            this.newPatient = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.autoLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.setDoctorName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(609, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.autoLabel1.AutoSize = false;
            this.autoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(19, 0);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(266, 57);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Welcome, Doctor!";
            this.autoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setDoctorName
            // 
            this.setDoctorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setDoctorName.Location = new System.Drawing.Point(307, 18);
            this.setDoctorName.Name = "setDoctorName";
            this.setDoctorName.Size = new System.Drawing.Size(299, 20);
            this.setDoctorName.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.oldPatient, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.newPatient, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(609, 421);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // oldPatient
            // 
            this.oldPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldPatient.BeforeTouchSize = new System.Drawing.Size(164, 90);
            this.oldPatient.IsBackStageButton = false;
            this.oldPatient.Location = new System.Drawing.Point(222, 270);
            this.oldPatient.Name = "oldPatient";
            this.oldPatient.Padding = new System.Windows.Forms.Padding(10);
            this.oldPatient.Size = new System.Drawing.Size(164, 90);
            this.oldPatient.TabIndex = 1;
            this.oldPatient.Text = "Old Patient";
            this.oldPatient.Click += new System.EventHandler(this.oldPatient_Click);
            // 
            // newPatient
            // 
            this.newPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPatient.BeforeTouchSize = new System.Drawing.Size(164, 90);
            this.newPatient.IsBackStageButton = false;
            this.newPatient.Location = new System.Drawing.Point(222, 60);
            this.newPatient.Name = "newPatient";
            this.newPatient.Padding = new System.Windows.Forms.Padding(10);
            this.newPatient.Size = new System.Drawing.Size(164, 90);
            this.newPatient.TabIndex = 0;
            this.newPatient.Text = "New Patient";
            this.newPatient.Click += new System.EventHandler(this.newPatient_Click);
            // 
            // ArrivalOfPattient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 478);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ArrivalOfPattient";
            this.Text = "Patient Arrived!";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.Windows.Forms.ButtonAdv oldPatient;
        private Syncfusion.Windows.Forms.ButtonAdv newPatient;
        private System.Windows.Forms.TextBox setDoctorName;
    }
}