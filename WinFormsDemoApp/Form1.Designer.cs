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
            this.gbUserDetails.SuspendLayout();
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
            this.lstCity.Location = new System.Drawing.Point(63, 423);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(300, 209);
            this.lstCity.TabIndex = 2;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(747, 82);
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
            this.rbFemale.Location = new System.Drawing.Point(747, 142);
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
            this.chkC.Location = new System.Drawing.Point(747, 423);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(93, 45);
            this.chkC.TabIndex = 5;
            this.chkC.Text = "C#";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkASP
            // 
            this.chkASP.AutoSize = true;
            this.chkASP.Location = new System.Drawing.Point(748, 507);
            this.chkASP.Name = "chkASP";
            this.chkASP.Size = new System.Drawing.Size(163, 45);
            this.chkASP.TabIndex = 6;
            this.chkASP.Text = "ASP.Net";
            this.chkASP.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(63, 760);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(188, 58);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 1003);
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
    }
}