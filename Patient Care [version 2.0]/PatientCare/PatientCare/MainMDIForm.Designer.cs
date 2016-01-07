namespace PatientCare
{
    partial class MainMDIForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientCareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oldPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDrugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardiovascularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastrointestinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respiratorySystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDrugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagonosticTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setDoctorSpeciality = new System.Windows.Forms.Label();
            this.setDoctorName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.setDoctorUserName = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.setPatientAddress = new System.Windows.Forms.Label();
            this.setPatientGender = new System.Windows.Forms.Label();
            this.setPatientAge = new System.Windows.Forms.Label();
            this.setPatientName = new System.Windows.Forms.Label();
            this.setPatientID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radiologicalAndImagingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoryServicesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientCareToolStripMenuItem,
            this.medicineToolStripMenuItem,
            this.diagonosticTestToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientCareToolStripMenuItem
            // 
            this.patientCareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.patientCareToolStripMenuItem.Name = "patientCareToolStripMenuItem";
            this.patientCareToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.patientCareToolStripMenuItem.Text = "Patient Care";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatientToolStripMenuItem,
            this.oldPatientToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // newPatientToolStripMenuItem
            // 
            this.newPatientToolStripMenuItem.Name = "newPatientToolStripMenuItem";
            this.newPatientToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newPatientToolStripMenuItem.Text = "New Patient";
            this.newPatientToolStripMenuItem.Click += new System.EventHandler(this.newPatientToolStripMenuItem_Click);
            // 
            // oldPatientToolStripMenuItem
            // 
            this.oldPatientToolStripMenuItem.Name = "oldPatientToolStripMenuItem";
            this.oldPatientToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.oldPatientToolStripMenuItem.Text = "Old Patient";
            this.oldPatientToolStripMenuItem.Click += new System.EventHandler(this.oldPatientToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDrugsToolStripMenuItem,
            this.removeDrugToolStripMenuItem});
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.medicineToolStripMenuItem.Text = "Medicine";
            // 
            // addDrugsToolStripMenuItem
            // 
            this.addDrugsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antiToolStripMenuItem,
            this.cardiovascularToolStripMenuItem,
            this.gastrointestinalToolStripMenuItem,
            this.respiratorySystemToolStripMenuItem});
            this.addDrugsToolStripMenuItem.Name = "addDrugsToolStripMenuItem";
            this.addDrugsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addDrugsToolStripMenuItem.Text = "Add Drugs";
            // 
            // antiToolStripMenuItem
            // 
            this.antiToolStripMenuItem.Name = "antiToolStripMenuItem";
            this.antiToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.antiToolStripMenuItem.Text = "Antimicrobial";
            this.antiToolStripMenuItem.Click += new System.EventHandler(this.antiToolStripMenuItem_Click);
            // 
            // cardiovascularToolStripMenuItem
            // 
            this.cardiovascularToolStripMenuItem.Name = "cardiovascularToolStripMenuItem";
            this.cardiovascularToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cardiovascularToolStripMenuItem.Text = "Cardiovascular";
            this.cardiovascularToolStripMenuItem.Click += new System.EventHandler(this.cardiovascularToolStripMenuItem_Click);
            // 
            // gastrointestinalToolStripMenuItem
            // 
            this.gastrointestinalToolStripMenuItem.Name = "gastrointestinalToolStripMenuItem";
            this.gastrointestinalToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gastrointestinalToolStripMenuItem.Text = "Gastrointestinal";
            this.gastrointestinalToolStripMenuItem.Click += new System.EventHandler(this.gastrointestinalToolStripMenuItem_Click);
            // 
            // respiratorySystemToolStripMenuItem
            // 
            this.respiratorySystemToolStripMenuItem.Name = "respiratorySystemToolStripMenuItem";
            this.respiratorySystemToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.respiratorySystemToolStripMenuItem.Text = "Respiratory System";
            this.respiratorySystemToolStripMenuItem.Click += new System.EventHandler(this.respiratorySystemToolStripMenuItem_Click);
            // 
            // removeDrugToolStripMenuItem
            // 
            this.removeDrugToolStripMenuItem.Name = "removeDrugToolStripMenuItem";
            this.removeDrugToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeDrugToolStripMenuItem.Text = "Remove Drug";
            this.removeDrugToolStripMenuItem.Click += new System.EventHandler(this.removeDrugToolStripMenuItem_Click);
            // 
            // diagonosticTestToolStripMenuItem
            // 
            this.diagonosticTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTestToolStripMenuItem,
            this.removeTestsToolStripMenuItem});
            this.diagonosticTestToolStripMenuItem.Name = "diagonosticTestToolStripMenuItem";
            this.diagonosticTestToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.diagonosticTestToolStripMenuItem.Text = "Diagonostic Test";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prescriptionToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // prescriptionToolStripMenuItem
            // 
            this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
            this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.prescriptionToolStripMenuItem.Text = "Prescription";
            this.prescriptionToolStripMenuItem.Click += new System.EventHandler(this.prescriptionToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profileToolStripMenuItem.Text = "Patient History";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 98);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.setDoctorSpeciality, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.setDoctorName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.setDoctorUserName, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(385, 92);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Doctor\'s Speciality:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor\'s Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setDoctorSpeciality
            // 
            this.setDoctorSpeciality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setDoctorSpeciality.AutoSize = true;
            this.setDoctorSpeciality.Location = new System.Drawing.Point(195, 38);
            this.setDoctorSpeciality.Name = "setDoctorSpeciality";
            this.setDoctorSpeciality.Size = new System.Drawing.Size(187, 13);
            this.setDoctorSpeciality.TabIndex = 10;
            this.setDoctorSpeciality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setDoctorName
            // 
            this.setDoctorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setDoctorName.AutoSize = true;
            this.setDoctorName.Location = new System.Drawing.Point(195, 20);
            this.setDoctorName.Name = "setDoctorName";
            this.setDoctorName.Size = new System.Drawing.Size(187, 13);
            this.setDoctorName.TabIndex = 1;
            this.setDoctorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Doctor\'s User Name:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setDoctorUserName
            // 
            this.setDoctorUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setDoctorUserName.AutoSize = true;
            this.setDoctorUserName.Location = new System.Drawing.Point(195, 2);
            this.setDoctorUserName.Name = "setDoctorUserName";
            this.setDoctorUserName.Size = new System.Drawing.Size(187, 13);
            this.setDoctorUserName.TabIndex = 13;
            this.setDoctorUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.setPatientAddress, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.setPatientGender, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.setPatientAge, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.setPatientName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.setPatientID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(394, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(386, 92);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // setPatientAddress
            // 
            this.setPatientAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setPatientAddress.AutoSize = true;
            this.setPatientAddress.Location = new System.Drawing.Point(196, 75);
            this.setPatientAddress.Name = "setPatientAddress";
            this.setPatientAddress.Size = new System.Drawing.Size(187, 13);
            this.setPatientAddress.TabIndex = 16;
            this.setPatientAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setPatientGender
            // 
            this.setPatientGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setPatientGender.AutoSize = true;
            this.setPatientGender.Location = new System.Drawing.Point(196, 56);
            this.setPatientGender.Name = "setPatientGender";
            this.setPatientGender.Size = new System.Drawing.Size(187, 13);
            this.setPatientGender.TabIndex = 15;
            this.setPatientGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setPatientAge
            // 
            this.setPatientAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setPatientAge.AutoSize = true;
            this.setPatientAge.Location = new System.Drawing.Point(196, 38);
            this.setPatientAge.Name = "setPatientAge";
            this.setPatientAge.Size = new System.Drawing.Size(187, 13);
            this.setPatientAge.TabIndex = 14;
            this.setPatientAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setPatientName
            // 
            this.setPatientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setPatientName.AutoSize = true;
            this.setPatientName.Location = new System.Drawing.Point(196, 20);
            this.setPatientName.Name = "setPatientName";
            this.setPatientName.Size = new System.Drawing.Size(187, 13);
            this.setPatientName.TabIndex = 13;
            this.setPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setPatientID
            // 
            this.setPatientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setPatientID.AutoSize = true;
            this.setPatientID.Location = new System.Drawing.Point(196, 2);
            this.setPatientID.Name = "setPatientID";
            this.setPatientID.Size = new System.Drawing.Size(187, 13);
            this.setPatientID.TabIndex = 12;
            this.setPatientID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Patient\'s Address:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Patient\'s ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Patient\'s Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Patient\'s Age:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Patient\'s Gender:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addTestToolStripMenuItem
            // 
            this.addTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radiologicalAndImagingToolStripMenuItem1,
            this.laboratoryServicesToolStripMenuItem1});
            this.addTestToolStripMenuItem.Name = "addTestToolStripMenuItem";
            this.addTestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addTestToolStripMenuItem.Text = "Add Tests";
            this.addTestToolStripMenuItem.Click += new System.EventHandler(this.addTestToolStripMenuItem_Click);
            // 
            // radiologicalAndImagingToolStripMenuItem1
            // 
            this.radiologicalAndImagingToolStripMenuItem1.Name = "radiologicalAndImagingToolStripMenuItem1";
            this.radiologicalAndImagingToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.radiologicalAndImagingToolStripMenuItem1.Text = "Radiological and Imaging";
            this.radiologicalAndImagingToolStripMenuItem1.Click += new System.EventHandler(this.radiologicalAndImagingToolStripMenuItem1_Click);
            // 
            // laboratoryServicesToolStripMenuItem1
            // 
            this.laboratoryServicesToolStripMenuItem1.Name = "laboratoryServicesToolStripMenuItem1";
            this.laboratoryServicesToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.laboratoryServicesToolStripMenuItem1.Text = "Laboratory Services";
            this.laboratoryServicesToolStripMenuItem1.Click += new System.EventHandler(this.laboratoryServicesToolStripMenuItem1_Click);
            // 
            // removeTestsToolStripMenuItem
            // 
            this.removeTestsToolStripMenuItem.Name = "removeTestsToolStripMenuItem";
            this.removeTestsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeTestsToolStripMenuItem.Text = "Remove Test";
            this.removeTestsToolStripMenuItem.Click += new System.EventHandler(this.removeTestsToolStripMenuItem_Click);
            // 
            // MainMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMDIForm";
            this.Text = "MainMDIForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMDIForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientCareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oldPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDrugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardiovascularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastrointestinalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respiratorySystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDrugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagonosticTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label setDoctorSpeciality;
        private System.Windows.Forms.Label setDoctorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label setPatientAddress;
        private System.Windows.Forms.Label setPatientGender;
        private System.Windows.Forms.Label setPatientAge;
        private System.Windows.Forms.Label setPatientName;
        private System.Windows.Forms.Label setPatientID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label setDoctorUserName;
        private System.Windows.Forms.ToolStripMenuItem addTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radiologicalAndImagingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem laboratoryServicesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeTestsToolStripMenuItem;

    }
}