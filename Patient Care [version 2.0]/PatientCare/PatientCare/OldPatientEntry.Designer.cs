namespace PatientCare
{
    partial class OldPatientEntry
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
            this.searchDirectoryOfPatient = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.getPName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.getPatientID = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.goTreatment = new Syncfusion.Windows.Forms.ButtonAdv();
            this.abortOperation = new Syncfusion.Windows.Forms.ButtonAdv();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientID)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchDirectoryOfPatient
            // 
            this.searchDirectoryOfPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchDirectoryOfPatient.BeforeTouchSize = new System.Drawing.Size(113, 51);
            this.searchDirectoryOfPatient.IsBackStageButton = false;
            this.searchDirectoryOfPatient.Location = new System.Drawing.Point(422, 117);
            this.searchDirectoryOfPatient.Name = "searchDirectoryOfPatient";
            this.searchDirectoryOfPatient.Size = new System.Drawing.Size(113, 51);
            this.searchDirectoryOfPatient.TabIndex = 0;
            this.searchDirectoryOfPatient.Text = "Search";
            this.searchDirectoryOfPatient.Click += new System.EventHandler(this.searchDirectoryOfPatient_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.searchDirectoryOfPatient, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.autoLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.autoLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.getPName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.getPatientID, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 171);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.autoLabel1.Location = new System.Drawing.Point(122, 0);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(74, 57);
            this.autoLabel1.TabIndex = 1;
            this.autoLabel1.Text = "Patient Name:";
            this.autoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoLabel2
            // 
            this.autoLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.autoLabel2.Location = new System.Drawing.Point(79, 57);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(161, 57);
            this.autoLabel2.TabIndex = 2;
            this.autoLabel2.Text = "Patient ID(NID/ Birth Certificate):";
            this.autoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getPName
            // 
            this.getPName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.getPName.BeforeTouchSize = new System.Drawing.Size(313, 20);
            this.getPName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.getPName.Location = new System.Drawing.Point(322, 18);
            this.getPName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.getPName.Name = "getPName";
            this.getPName.Size = new System.Drawing.Size(313, 20);
            this.getPName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.getPName.TabIndex = 3;
            this.getPName.TextChanged += new System.EventHandler(this.getPName_TextChanged);
            // 
            // getPatientID
            // 
            this.getPatientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.getPatientID.BeforeTouchSize = new System.Drawing.Size(313, 20);
            this.getPatientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.getPatientID.Location = new System.Drawing.Point(322, 75);
            this.getPatientID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.getPatientID.Name = "getPatientID";
            this.getPatientID.Size = new System.Drawing.Size(313, 20);
            this.getPatientID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.getPatientID.TabIndex = 4;
            this.getPatientID.TextChanged += new System.EventHandler(this.getPatientID_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.goTreatment, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.abortOperation, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 418);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(638, 83);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // goTreatment
            // 
            this.goTreatment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.goTreatment.BeforeTouchSize = new System.Drawing.Size(113, 77);
            this.goTreatment.IsBackStageButton = false;
            this.goTreatment.Location = new System.Drawing.Point(422, 3);
            this.goTreatment.Name = "goTreatment";
            this.goTreatment.Size = new System.Drawing.Size(113, 77);
            this.goTreatment.TabIndex = 2;
            this.goTreatment.Text = "SELECT";
            this.goTreatment.Click += new System.EventHandler(this.goTreatment_Click);
            // 
            // abortOperation
            // 
            this.abortOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.abortOperation.BeforeTouchSize = new System.Drawing.Size(113, 77);
            this.abortOperation.IsBackStageButton = false;
            this.abortOperation.Location = new System.Drawing.Point(103, 3);
            this.abortOperation.Name = "abortOperation";
            this.abortOperation.Size = new System.Drawing.Size(113, 77);
            this.abortOperation.TabIndex = 1;
            this.abortOperation.Text = "ABORT";
            this.abortOperation.Click += new System.EventHandler(this.abortOperation_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 206);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(638, 172);
            this.dataGridView1.TabIndex = 3;
            // 
            // OldPatientEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OldPatientEntry";
            this.Text = "Old Patient";
            this.Load += new System.EventHandler(this.OldPatientEntry_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientID)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv searchDirectoryOfPatient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt getPName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt getPatientID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.Windows.Forms.ButtonAdv goTreatment;
        private Syncfusion.Windows.Forms.ButtonAdv abortOperation;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}