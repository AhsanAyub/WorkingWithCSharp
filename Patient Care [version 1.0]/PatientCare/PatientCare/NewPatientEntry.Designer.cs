namespace PatientCare
{
    partial class NewPatientEntry
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
            this.doneProcess = new Syncfusion.Windows.Forms.ButtonAdv();
            this.exitProcess = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.getFullName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.getPatientID = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.getAge = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.getGender = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.getAddress = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.exitProcess, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.doneProcess, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 434);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // doneProcess
            // 
            this.doneProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.doneProcess.BeforeTouchSize = new System.Drawing.Size(147, 64);
            this.doneProcess.IsBackStageButton = false;
            this.doneProcess.Location = new System.Drawing.Point(423, 3);
            this.doneProcess.Name = "doneProcess";
            this.doneProcess.Size = new System.Drawing.Size(147, 64);
            this.doneProcess.TabIndex = 1;
            this.doneProcess.Text = "Done";
            this.doneProcess.Click += new System.EventHandler(this.doneProcess_Click);
            // 
            // exitProcess
            // 
            this.exitProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.exitProcess.BeforeTouchSize = new System.Drawing.Size(147, 64);
            this.exitProcess.IsBackStageButton = false;
            this.exitProcess.Location = new System.Drawing.Point(92, 3);
            this.exitProcess.Name = "exitProcess";
            this.exitProcess.Size = new System.Drawing.Size(147, 64);
            this.exitProcess.TabIndex = 0;
            this.exitProcess.Text = "Go Back";
            this.exitProcess.Click += new System.EventHandler(this.exitProcess_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.getFullName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.getPatientID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.getAge, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.getGender, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.getAddress, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(663, 434);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 86);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient ID (NID/ Birth Certificate):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 86);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 86);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 90);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getFullName
            // 
            this.getFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.getFullName.BeforeTouchSize = new System.Drawing.Size(326, 20);
            this.getFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.getFullName.Location = new System.Drawing.Point(334, 33);
            this.getFullName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.getFullName.Name = "getFullName";
            this.getFullName.Size = new System.Drawing.Size(326, 20);
            this.getFullName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.getFullName.TabIndex = 5;
            this.getFullName.TextChanged += new System.EventHandler(this.getFullName_TextChanged);
            // 
            // getPatientID
            // 
            this.getPatientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.getPatientID.BeforeTouchSize = new System.Drawing.Size(326, 20);
            this.getPatientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.getPatientID.Location = new System.Drawing.Point(334, 119);
            this.getPatientID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.getPatientID.Name = "getPatientID";
            this.getPatientID.Size = new System.Drawing.Size(326, 20);
            this.getPatientID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.getPatientID.TabIndex = 6;
            this.getPatientID.TextChanged += new System.EventHandler(this.getPatientID_TextChanged);
            // 
            // getAge
            // 
            this.getAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.getAge.BeforeTouchSize = new System.Drawing.Size(326, 20);
            this.getAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.getAge.Location = new System.Drawing.Point(334, 205);
            this.getAge.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.getAge.Name = "getAge";
            this.getAge.Size = new System.Drawing.Size(326, 20);
            this.getAge.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.getAge.TabIndex = 7;
            this.getAge.TextChanged += new System.EventHandler(this.getAge_TextChanged);
            // 
            // getGender
            // 
            this.getGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.getGender.BeforeTouchSize = new System.Drawing.Size(326, 20);
            this.getGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.getGender.Location = new System.Drawing.Point(334, 291);
            this.getGender.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.getGender.Name = "getGender";
            this.getGender.Size = new System.Drawing.Size(326, 20);
            this.getGender.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.getGender.TabIndex = 8;
            this.getGender.TextChanged += new System.EventHandler(this.getGender_TextChanged);
            // 
            // getAddress
            // 
            this.getAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.getAddress.BeforeTouchSize = new System.Drawing.Size(326, 20);
            this.getAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.getAddress.Location = new System.Drawing.Point(334, 379);
            this.getAddress.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.getAddress.Name = "getAddress";
            this.getAddress.Size = new System.Drawing.Size(326, 20);
            this.getAddress.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.getAddress.TabIndex = 9;
            this.getAddress.TextChanged += new System.EventHandler(this.getAddress_TextChanged);
            // 
            // NewPatientEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 504);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewPatientEntry";
            this.Text = "Entry of New Patient";
            this.Load += new System.EventHandler(this.NewPatientEntry_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.ButtonAdv exitProcess;
        private Syncfusion.Windows.Forms.ButtonAdv doneProcess;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt getFullName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt getPatientID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt getAge;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt getGender;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt getAddress;
    }
}