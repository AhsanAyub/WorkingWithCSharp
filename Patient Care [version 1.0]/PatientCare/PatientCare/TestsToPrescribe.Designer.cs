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
            this.CommentOnTest = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.addItem = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.testItems = new System.Windows.Forms.ComboBox();
            this.categorizedTestItems = new System.Windows.Forms.ComboBox();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.ShowTestToSelect = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommentOnTest)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowTestToSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.CommentOnTest, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.addItem, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.gradientLabel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 363);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(731, 61);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // CommentOnTest
            // 
            this.CommentOnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentOnTest.BeforeTouchSize = new System.Drawing.Size(140, 20);
            this.CommentOnTest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CommentOnTest.Location = new System.Drawing.Point(149, 20);
            this.CommentOnTest.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.CommentOnTest.Name = "CommentOnTest";
            this.CommentOnTest.Size = new System.Drawing.Size(432, 20);
            this.CommentOnTest.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.CommentOnTest.TabIndex = 5;
            this.CommentOnTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CommentOnTest.TextChanged += new System.EventHandler(this.CommentOnTest_TextChanged);
            // 
            // addItem
            // 
            this.addItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addItem.BeforeTouchSize = new System.Drawing.Size(85, 55);
            this.addItem.IsBackStageButton = false;
            this.addItem.Location = new System.Drawing.Point(615, 3);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(85, 55);
            this.addItem.TabIndex = 3;
            this.addItem.Text = "Add Item";
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(140, 23);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.Location = new System.Drawing.Point(3, 19);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(140, 23);
            this.gradientLabel1.TabIndex = 4;
            this.gradientLabel1.Text = "Comment:";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.categorizedTestItems, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.testItems, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.ShowTestToSelect, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(731, 57);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // testItems
            // 
            this.testItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.testItems.FormattingEnabled = true;
            this.testItems.Location = new System.Drawing.Point(3, 18);
            this.testItems.Name = "testItems";
            this.testItems.Size = new System.Drawing.Size(213, 21);
            this.testItems.TabIndex = 0;
            this.testItems.SelectedIndexChanged += new System.EventHandler(this.testItems_SelectedIndexChanged_1);
            // 
            // categorizedTestItems
            // 
            this.categorizedTestItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.categorizedTestItems.FormattingEnabled = true;
            this.categorizedTestItems.Location = new System.Drawing.Point(222, 18);
            this.categorizedTestItems.Name = "categorizedTestItems";
            this.categorizedTestItems.Size = new System.Drawing.Size(213, 21);
            this.categorizedTestItems.TabIndex = 1;
            this.categorizedTestItems.SelectedIndexChanged += new System.EventHandler(this.categorizedTestItems_SelectedIndexChanged);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(67, 51);
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(441, 3);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(67, 51);
            this.buttonAdv1.TabIndex = 2;
            this.buttonAdv1.Text = "GO";
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click_1);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(67, 51);
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(660, 3);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(67, 51);
            this.buttonAdv2.TabIndex = 3;
            this.buttonAdv2.Text = "SELECT";
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // ShowTestToSelect
            // 
            this.ShowTestToSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowTestToSelect.BeforeTouchSize = new System.Drawing.Size(140, 20);
            this.ShowTestToSelect.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShowTestToSelect.Location = new System.Drawing.Point(514, 18);
            this.ShowTestToSelect.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.ShowTestToSelect.Name = "ShowTestToSelect";
            this.ShowTestToSelect.Size = new System.Drawing.Size(140, 20);
            this.ShowTestToSelect.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.ShowTestToSelect.TabIndex = 4;
            this.ShowTestToSelect.Text = "Selected Test";
            this.ShowTestToSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 306);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TestsToPrescribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "TestsToPrescribe";
            this.Text = "Prescribing Test";
            this.Load += new System.EventHandler(this.TestsToPrescribe_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommentOnTest)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowTestToSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt CommentOnTest;
        private Syncfusion.Windows.Forms.ButtonAdv addItem;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox categorizedTestItems;
        private System.Windows.Forms.ComboBox testItems;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt ShowTestToSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}