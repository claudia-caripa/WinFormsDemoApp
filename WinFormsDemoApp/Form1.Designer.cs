namespace WinFormsDemoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Label");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Button");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Checkbox");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbUserDetails = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkASP = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblListBox = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUserDetails
            // 
            this.gbUserDetails.Controls.Add(this.txtAddress);
            this.gbUserDetails.Controls.Add(this.txtName);
            this.gbUserDetails.Controls.Add(this.lblAddress);
            this.gbUserDetails.Controls.Add(this.lblName);
            this.gbUserDetails.Location = new System.Drawing.Point(45, 68);
            this.gbUserDetails.Name = "gbUserDetails";
            this.gbUserDetails.Size = new System.Drawing.Size(496, 226);
            this.gbUserDetails.TabIndex = 1;
            this.gbUserDetails.TabStop = false;
            this.gbUserDetails.Text = "User Details";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(172, 142);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 47);
            this.txtAddress.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 47);
            this.txtName.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(18, 141);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(125, 41);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 41);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.ItemHeight = 41;
            this.lstCity.Items.AddRange(new object[] {
            "Caracas",
            "Buenos Aires",
            "Bogota",
            "Dublin"});
            this.lstCity.Location = new System.Drawing.Point(48, 384);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(300, 209);
            this.lstCity.TabIndex = 2;
            this.lstCity.SelectedIndexChanged += new System.EventHandler(this.lstCity_SelectedIndexChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(720, 93);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(120, 45);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(720, 153);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(150, 45);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(724, 413);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(93, 45);
            this.chkC.TabIndex = 5;
            this.chkC.Text = "C#";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkASP
            // 
            this.chkASP.AutoSize = true;
            this.chkASP.Location = new System.Drawing.Point(725, 497);
            this.chkASP.Name = "chkASP";
            this.chkASP.Size = new System.Drawing.Size(163, 45);
            this.chkASP.TabIndex = 6;
            this.chkASP.Text = "ASP.Net";
            this.chkASP.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(725, 645);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(188, 58);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(1105, 262);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Label";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Button";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Checkbox";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(232, 222);
            this.treeView1.TabIndex = 8;
            // 
            // lblListBox
            // 
            this.lblListBox.AutoSize = true;
            this.lblListBox.Location = new System.Drawing.Point(48, 340);
            this.lblListBox.Name = "lblListBox";
            this.lblListBox.Size = new System.Drawing.Size(69, 41);
            this.lblListBox.TabIndex = 9;
            this.lblListBox.Text = "City";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(720, 35);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(116, 41);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // lblTutorial
            // 
            this.lblTutorial.AutoSize = true;
            this.lblTutorial.Location = new System.Drawing.Point(718, 340);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(118, 41);
            this.lblTutorial.TabIndex = 11;
            this.lblTutorial.Text = "Tutorial";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1105, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 222);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 794);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTutorial);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblListBox);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkASP);
            this.Controls.Add(this.chkC);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.lstCity);
            this.Controls.Add(this.gbUserDetails);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbUserDetails.ResumeLayout(false);
            this.gbUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbUserDetails;
        private Label lblAddress;
        private Label lblName;
        private TextBox txtAddress;
        private TextBox txtName;
        private ListBox lstCity;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private CheckBox chkC;
        private CheckBox chkASP;
        private Button btnSubmit;
        private TreeView treeView1;
        private Label lblListBox;
        private Label lblGender;
        private Label lblTutorial;
        private PictureBox pictureBox1;
    }
}