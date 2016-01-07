namespace PatientCare
{
    partial class TestsToPrescribe
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.testPrescription = new System.Windows.Forms.DataGridView();
            this.medicinePrescription = new System.Windows.Forms.DataGridView();
            this.CommentOnTest = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.addItem = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.categorizedTestItems = new System.Windows.Forms.ComboBox();
            this.clearFields = new Syncfusion.Windows.Forms.ButtonAdv();
            this.ShowTestToSelect = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gradientLabel3 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinePrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentOnTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowTestToSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 265);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(731, 159);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // testPrescription
            // 
            this.testPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testPrescription.Location = new System.Drawing.Point(368, 3);
            this.testPrescription.Name = "testPrescription";
            this.testPrescription.Size = new System.Drawing.Size(360, 153);
            this.testPrescription.TabIndex = 7;
            // 
            // medicinePrescription
            // 
            this.medicinePrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinePrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicinePrescription.Location = new System.Drawing.Point(3, 3);
            this.medicinePrescription.Name = "medicinePrescription";
            this.medicinePrescription.Size = new System.Drawing.Size(359, 153);
            this.medicinePrescription.TabIndex = 6;
            // 
            // CommentOnTest
            // 
            this.CommentOnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentOnTest.BeforeTouchSize = new System.Drawing.Size(187, 20);
            this.CommentOnTest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CommentOnTest.Location = new System.Drawing.Point(183, 150);
            this.CommentOnTest.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.CommentOnTest.Name = "CommentOnTest";
            this.CommentOnTest.Size = new System.Drawing.Size(174, 20);
            this.CommentOnTest.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.CommentOnTest.TabIndex = 5;
            this.CommentOnTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CommentOnTest.TextChanged += new System.EventHandler(this.CommentOnTest_TextChanged);
            // 
            // addItem
            // 
            this.addItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addItem.BeforeTouchSize = new System.Drawing.Size(85, 61);
            this.addItem.IsBackStageButton = false;
            this.addItem.Location = new System.Drawing.Point(227, 195);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(85, 61);
            this.addItem.TabIndex = 3;
            this.addItem.Text = "ADD Item";
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(174, 23);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.Location = new System.Drawing.Point(3, 148);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(174, 23);
            this.gradientLabel1.TabIndex = 4;
            this.gradientLabel1.Text = "Comment:";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categorizedTestItems
            // 
            this.categorizedTestItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.categorizedTestItems.FormattingEnabled = true;
            this.categorizedTestItems.Location = new System.Drawing.Point(183, 85);
            this.categorizedTestItems.Name = "categorizedTestItems";
            this.categorizedTestItems.Size = new System.Drawing.Size(174, 21);
            this.categorizedTestItems.TabIndex = 1;
            this.categorizedTestItems.SelectedIndexChanged += new System.EventHandler(this.categorizedTestItems_SelectedIndexChanged);
            // 
            // clearFields
            // 
            this.clearFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.clearFields.BeforeTouchSize = new System.Drawing.Size(85, 61);
            this.clearFields.IsBackStageButton = false;
            this.clearFields.Location = new System.Drawing.Point(47, 195);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(85, 61);
            this.clearFields.TabIndex = 2;
            this.clearFields.Text = "CLEAR";
            // 
            // ShowTestToSelect
            // 
            this.ShowTestToSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowTestToSelect.BeforeTouchSize = new System.Drawing.Size(187, 20);
            this.ShowTestToSelect.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShowTestToSelect.Location = new System.Drawing.Point(183, 22);
            this.ShowTestToSelect.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.ShowTestToSelect.Name = "ShowTestToSelect";
            this.ShowTestToSelect.Size = new System.Drawing.Size(174, 20);
            this.ShowTestToSelect.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.ShowTestToSelect.TabIndex = 4;
            this.ShowTestToSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ShowTestToSelect.TextChanged += new System.EventHandler(this.ShowTestToSelect_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(359, 259);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(731, 265);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.gradientLabel3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.gradientLabel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gradientLabel1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.CommentOnTest, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.ShowTestToSelect, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.addItem, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.clearFields, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.categorizedTestItems, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(368, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(360, 259);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel3.BeforeTouchSize = new System.Drawing.Size(174, 23);
            this.gradientLabel3.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel3.Location = new System.Drawing.Point(3, 84);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(174, 23);
            this.gradientLabel3.TabIndex = 7;
            this.gradientLabel3.Text = "Test to Prescribe:";
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel2.BeforeTouchSize = new System.Drawing.Size(174, 23);
            this.gradientLabel2.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel2.Location = new System.Drawing.Point(3, 20);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(174, 23);
            this.gradientLabel2.TabIndex = 6;
            this.gradientLabel2.Text = "Selected Test:";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestsToPrescribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 424);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "TestsToPrescribe";
            this.Text = "Prescribing Test";
            this.Load += new System.EventHandler(this.TestsToPrescribe_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinePrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentOnTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowTestToSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt CommentOnTest;
        private Syncfusion.Windows.Forms.ButtonAdv addItem;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private System.Windows.Forms.ComboBox categorizedTestItems;
        private Syncfusion.Windows.Forms.ButtonAdv clearFields;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt ShowTestToSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView testPrescription;
        private System.Windows.Forms.DataGridView medicinePrescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel3;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel2;
    }
}