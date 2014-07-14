namespace OrionConnect_Api_Sample
{
    partial class frmRegistration
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
            this.pnlNewClient = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cboAccountType = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cboClient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNewClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNewClient
            // 
            this.pnlNewClient.Controls.Add(this.cboClient);
            this.pnlNewClient.Controls.Add(this.label2);
            this.pnlNewClient.Controls.Add(this.label1);
            this.pnlNewClient.Controls.Add(this.txtFullName);
            this.pnlNewClient.Controls.Add(this.cboAccountType);
            this.pnlNewClient.Controls.Add(this.label35);
            this.pnlNewClient.Controls.Add(this.txtFirstName);
            this.pnlNewClient.Controls.Add(this.label9);
            this.pnlNewClient.Controls.Add(this.label11);
            this.pnlNewClient.Controls.Add(this.txtLastName);
            this.pnlNewClient.Controls.Add(this.label12);
            this.pnlNewClient.Controls.Add(this.txtBirthDate);
            this.pnlNewClient.Controls.Add(this.label13);
            this.pnlNewClient.Controls.Add(this.txtSSN);
            this.pnlNewClient.Location = new System.Drawing.Point(25, 58);
            this.pnlNewClient.Name = "pnlNewClient";
            this.pnlNewClient.Size = new System.Drawing.Size(278, 288);
            this.pnlNewClient.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(90, 137);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(143, 20);
            this.txtFullName.TabIndex = 50;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtClientFullName_TextChanged);
            // 
            // cboAccountType
            // 
            this.cboAccountType.FormattingEnabled = true;
            this.cboAccountType.Location = new System.Drawing.Point(90, 9);
            this.cboAccountType.Name = "cboAccountType";
            this.cboAccountType.Size = new System.Drawing.Size(147, 21);
            this.cboAccountType.TabIndex = 48;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(15, 9);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(77, 13);
            this.label35.TabIndex = 45;
            this.label35.Text = "Account Type:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(90, 85);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(143, 20);
            this.txtFirstName.TabIndex = 15;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtCientFName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(90, 111);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(143, 20);
            this.txtLastName.TabIndex = 18;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtClientLName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Birth Date";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(90, 218);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(143, 20);
            this.txtBirthDate.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "SSN";
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(90, 244);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(143, 20);
            this.txtSSN.TabIndex = 22;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(102, 352);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(89, 23);
            this.cmdSave.TabIndex = 44;
            this.cmdSave.Text = "Save Changes";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Registration Record";
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(197, 352);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(89, 23);
            this.cmdCancel.TabIndex = 45;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cboClient
            // 
            this.cboClient.FormattingEnabled = true;
            this.cboClient.Location = new System.Drawing.Point(90, 45);
            this.cboClient.Name = "cboClient";
            this.cboClient.Size = new System.Drawing.Size(171, 21);
            this.cboClient.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Client:";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(324, 397);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.pnlNewClient);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmdSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRegistration";
            this.Text = "Edit Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.pnlNewClient.ResumeLayout(false);
            this.pnlNewClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewClient;
        private System.Windows.Forms.ComboBox cboAccountType;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox cboClient;
        private System.Windows.Forms.Label label2;
    }
}