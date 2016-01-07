namespace PatientCare
{
    partial class MedicineToPrescribe
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
            this.selectedMedicine = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.CategorizedDrugs = new System.Windows.Forms.ComboBox();
            this.clearFields = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.testPrescription = new System.Windows.Forms.DataGridView();
            this.medicinePrescription = new System.Windows.Forms.DataGridView();
            this.comment = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.addMedicine = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Days = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Intake = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gradientLabel5 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel4 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel3 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMedicine)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinePrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intake)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedMedicine
            // 
            this.selectedMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedMedicine.BeforeTouchSize = new System.Drawing.Size(95, 20);
            this.selectedMedicine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.selectedMedicine.Location = new System.Drawing.Point(104, 5);
            this.selectedMedicine.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.selectedMedicine.Name = "selectedMedicine";
            this.selectedMedicine.Size = new System.Drawing.Size(95, 20);
            this.selectedMedicine.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.selectedMedicine.TabIndex = 4;
            this.selectedMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CategorizedDrugs
            // 
            this.CategorizedDrugs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CategorizedDrugs.FormattingEnabled = true;
            this.CategorizedDrugs.Location = new System.Drawing.Point(104, 36);
            this.CategorizedDrugs.Name = "CategorizedDrugs";
            this.CategorizedDrugs.Size = new System.Drawing.Size(95, 21);
            this.CategorizedDrugs.TabIndex = 0;
            this.CategorizedDrugs.SelectedIndexChanged += new System.EventHandler(this.CategorizedDrugs_SelectedIndexChanged_1);
            // 
            // clearFields
            // 
            this.clearFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clearFields.BeforeTouchSize = new System.Drawing.Size(78, 29);
            this.clearFields.IsBackStageButton = false;
            this.clearFields.Location = new System.Drawing.Point(3, 158);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(78, 29);
            this.clearFields.TabIndex = 2;
            this.clearFields.Text = "CLEAR";
            this.clearFields.Click += new System.EventHandler(this.ShowDataTableOfTests_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.testPrescription, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.medicinePrescription, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 196);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(593, 176);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // testPrescription
            // 
            this.testPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testPrescription.Location = new System.Drawing.Point(299, 3);
            this.testPrescription.Name = "testPrescription";
            this.testPrescription.Size = new System.Drawing.Size(291, 170);
            this.testPrescription.TabIndex = 3;
            // 
            // medicinePrescription
            // 
            this.medicinePrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinePrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicinePrescription.Location = new System.Drawing.Point(3, 3);
            this.medicinePrescription.Name = "medicinePrescription";
            this.medicinePrescription.Size = new System.Drawing.Size(290, 170);
            this.medicinePrescription.TabIndex = 2;
            // 
            // comment
            // 
            this.comment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comment.BeforeTouchSize = new System.Drawing.Size(95, 20);
            this.comment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comment.Location = new System.Drawing.Point(104, 129);
            this.comment.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(95, 20);
            this.comment.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.comment.TabIndex = 0;
            this.comment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comment.TextChanged += new System.EventHandler(this.comment_TextChanged);
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(95, 23);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.Location = new System.Drawing.Point(3, 35);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(95, 23);
            this.gradientLabel1.TabIndex = 1;
            this.gradientLabel1.Text = "Medicine Catogory:";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addMedicine
            // 
            this.addMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addMedicine.BeforeTouchSize = new System.Drawing.Size(78, 29);
            this.addMedicine.IsBackStageButton = false;
            this.addMedicine.Location = new System.Drawing.Point(121, 158);
            this.addMedicine.Name = "addMedicine";
            this.addMedicine.Size = new System.Drawing.Size(78, 29);
            this.addMedicine.TabIndex = 2;
            this.addMedicine.Text = "ADD ITEM";
            this.addMedicine.Click += new System.EventHandler(this.addMedicine_Click);
            // 
            // Days
            // 
            this.Days.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Days.BeforeTouchSize = new System.Drawing.Size(95, 20);
            this.Days.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Days.Location = new System.Drawing.Point(104, 98);
            this.Days.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(95, 20);
            this.Days.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.Days.TabIndex = 4;
            this.Days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Days.TextChanged += new System.EventHandler(this.Days_TextChanged);
            // 
            // Intake
            // 
            this.Intake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Intake.BeforeTouchSize = new System.Drawing.Size(95, 20);
            this.Intake.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Intake.Location = new System.Drawing.Point(104, 67);
            this.Intake.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.Intake.Name = "Intake";
            this.Intake.Size = new System.Drawing.Size(95, 20);
            this.Intake.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.Intake.TabIndex = 3;
            this.Intake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Intake.TextChanged += new System.EventHandler(this.Intake_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 196);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(379, 190);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(373, 184);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.gradientLabel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.clearFields, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.selectedMedicine, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.gradientLabel4, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.gradientLabel3, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.gradientLabel2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.gradientLabel1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.addMedicine, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.comment, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.Days, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.Intake, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.CategorizedDrugs, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(388, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(202, 190);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // gradientLabel5
            // 
            this.gradientLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel5.BeforeTouchSize = new System.Drawing.Size(95, 23);
            this.gradientLabel5.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel5.Location = new System.Drawing.Point(3, 4);
            this.gradientLabel5.Name = "gradientLabel5";
            this.gradientLabel5.Size = new System.Drawing.Size(95, 23);
            this.gradientLabel5.TabIndex = 8;
            this.gradientLabel5.Text = "Selected Medicine:";
            this.gradientLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel4
            // 
            this.gradientLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel4.BeforeTouchSize = new System.Drawing.Size(95, 23);
            this.gradientLabel4.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel4.Location = new System.Drawing.Point(3, 128);
            this.gradientLabel4.Name = "gradientLabel4";
            this.gradientLabel4.Size = new System.Drawing.Size(95, 23);
            this.gradientLabel4.TabIndex = 7;
            this.gradientLabel4.Text = "Comments:";
            this.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel3.BeforeTouchSize = new System.Drawing.Size(95, 23);
            this.gradientLabel3.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel3.Location = new System.Drawing.Point(3, 97);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(95, 23);
            this.gradientLabel3.TabIndex = 6;
            this.gradientLabel3.Text = "Days of Consumption:";
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel2.BeforeTouchSize = new System.Drawing.Size(95, 23);
            this.gradientLabel2.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel2.Location = new System.Drawing.Point(3, 66);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(95, 23);
            this.gradientLabel2.TabIndex = 5;
            this.gradientLabel2.Text = "Intake of Medicine:";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedicineToPrescribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 372);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "MedicineToPrescribe";
            this.Text = "Medicine Prescribing";
            this.Load += new System.EventHandler(this.MedicineToPrescribe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectedMedicine)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinePrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intake)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CategorizedDrugs;
        private Syncfusion.Windows.Forms.ButtonAdv clearFields;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt selectedMedicine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt comment;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.ButtonAdv addMedicine;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Days;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Intake;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel5;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel4;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel3;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel2;
        private System.Windows.Forms.DataGridView testPrescription;
        private System.Windows.Forms.DataGridView medicinePrescription;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}