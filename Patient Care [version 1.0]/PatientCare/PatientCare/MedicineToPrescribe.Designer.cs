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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.selectedMedicine = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.CategorizedDrugs = new System.Windows.Forms.ComboBox();
            this.DrugItems = new System.Windows.Forms.ComboBox();
            this.ShowDataTableOfTests = new Syncfusion.Windows.Forms.ButtonAdv();
            this.addDrugItem = new Syncfusion.Windows.Forms.ButtonAdv();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comment = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.addMedicine = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Days = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Intake = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comment)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intake)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.selectedMedicine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CategorizedDrugs, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DrugItems, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ShowDataTableOfTests, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // selectedMedicine
            // 
            this.selectedMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedMedicine.BeforeTouchSize = new System.Drawing.Size(167, 20);
            this.selectedMedicine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.selectedMedicine.Location = new System.Drawing.Point(377, 20);
            this.selectedMedicine.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.selectedMedicine.Name = "selectedMedicine";
            this.selectedMedicine.Size = new System.Drawing.Size(119, 20);
            this.selectedMedicine.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.selectedMedicine.TabIndex = 4;
            this.selectedMedicine.Text = "Selected Medicine";
            this.selectedMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CategorizedDrugs
            // 
            this.CategorizedDrugs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CategorizedDrugs.FormattingEnabled = true;
            this.CategorizedDrugs.Location = new System.Drawing.Point(190, 19);
            this.CategorizedDrugs.Name = "CategorizedDrugs";
            this.CategorizedDrugs.Size = new System.Drawing.Size(181, 21);
            this.CategorizedDrugs.TabIndex = 1;
            this.CategorizedDrugs.SelectedIndexChanged += new System.EventHandler(this.CategorizedDrugs_SelectedIndexChanged);
            // 
            // DrugItems
            // 
            this.DrugItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DrugItems.FormattingEnabled = true;
            this.DrugItems.Location = new System.Drawing.Point(3, 19);
            this.DrugItems.Name = "DrugItems";
            this.DrugItems.Size = new System.Drawing.Size(181, 21);
            this.DrugItems.TabIndex = 0;
            this.DrugItems.SelectedIndexChanged += new System.EventHandler(this.DrugItems_SelectedIndexChanged);
            // 
            // ShowDataTableOfTests
            // 
            this.ShowDataTableOfTests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ShowDataTableOfTests.BeforeTouchSize = new System.Drawing.Size(75, 54);
            this.ShowDataTableOfTests.IsBackStageButton = false;
            this.ShowDataTableOfTests.Location = new System.Drawing.Point(525, 3);
            this.ShowDataTableOfTests.Name = "ShowDataTableOfTests";
            this.ShowDataTableOfTests.Size = new System.Drawing.Size(75, 54);
            this.ShowDataTableOfTests.TabIndex = 2;
            this.ShowDataTableOfTests.Text = "GO";
            this.ShowDataTableOfTests.Click += new System.EventHandler(this.ShowDataTableOfTests_Click);
            // 
            // addDrugItem
            // 
            this.addDrugItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addDrugItem.BeforeTouchSize = new System.Drawing.Size(111, 54);
            this.addDrugItem.IsBackStageButton = false;
            this.addDrugItem.Location = new System.Drawing.Point(3, 24);
            this.addDrugItem.Name = "addDrugItem";
            this.addDrugItem.Size = new System.Drawing.Size(111, 54);
            this.addDrugItem.TabIndex = 3;
            this.addDrugItem.Text = "Select Medice";
            this.addDrugItem.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 373);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.comment, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gradientLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.addMedicine, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 367);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(626, 66);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // comment
            // 
            this.comment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comment.BeforeTouchSize = new System.Drawing.Size(167, 20);
            this.comment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comment.Location = new System.Drawing.Point(128, 23);
            this.comment.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(369, 20);
            this.comment.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.comment.TabIndex = 0;
            this.comment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comment.TextChanged += new System.EventHandler(this.comment_TextChanged);
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(119, 23);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.Location = new System.Drawing.Point(3, 21);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(119, 23);
            this.gradientLabel1.TabIndex = 1;
            this.gradientLabel1.Text = "Comments:";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addMedicine
            // 
            this.addMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addMedicine.BeforeTouchSize = new System.Drawing.Size(120, 38);
            this.addMedicine.IsBackStageButton = false;
            this.addMedicine.Location = new System.Drawing.Point(503, 14);
            this.addMedicine.Name = "addMedicine";
            this.addMedicine.Size = new System.Drawing.Size(120, 38);
            this.addMedicine.TabIndex = 2;
            this.addMedicine.Text = "ADD ITEM";
            this.addMedicine.Click += new System.EventHandler(this.addMedicine_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.Days, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.addDrugItem, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Intake, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(509, 60);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(117, 307);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // Days
            // 
            this.Days.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Days.BeforeTouchSize = new System.Drawing.Size(167, 20);
            this.Days.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Days.Location = new System.Drawing.Point(3, 245);
            this.Days.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(111, 20);
            this.Days.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.Days.TabIndex = 4;
            this.Days.Text = "Days";
            this.Days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Days.TextChanged += new System.EventHandler(this.Days_TextChanged);
            // 
            // Intake
            // 
            this.Intake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Intake.BeforeTouchSize = new System.Drawing.Size(167, 20);
            this.Intake.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Intake.Location = new System.Drawing.Point(3, 143);
            this.Intake.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.Intake.Name = "Intake";
            this.Intake.Size = new System.Drawing.Size(111, 20);
            this.Intake.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.Intake.TabIndex = 3;
            this.Intake.Text = "Intake of Medicine";
            this.Intake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Intake.TextChanged += new System.EventHandler(this.Intake_TextChanged);
            // 
            // MedicineToPrescribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 433);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MedicineToPrescribe";
            this.Text = "Medicine Prescribing";
            this.Load += new System.EventHandler(this.MedicineToPrescribe_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comment)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.ButtonAdv addDrugItem;
        private System.Windows.Forms.ComboBox CategorizedDrugs;
        private System.Windows.Forms.ComboBox DrugItems;
        private Syncfusion.Windows.Forms.ButtonAdv ShowDataTableOfTests;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt selectedMedicine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt comment;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.ButtonAdv addMedicine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Days;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Intake;

    }
}