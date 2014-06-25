namespace OrionConnect_Api_Sample
{
    partial class Form1
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
            this.btnCheckToken = new System.Windows.Forms.Button();
            this.txtAuthToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLaunchConnectMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLaunchHHOverview = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHouseholdId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClientSearchValue = new System.Windows.Forms.Button();
            this.txtClientSearch = new System.Windows.Forms.TextBox();
            this.btnSearchClients = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClientSimpleWithValue = new System.Windows.Forms.Button();
            this.btnClientSimple = new System.Windows.Forms.Button();
            this.btnLaunchOverview = new System.Windows.Forms.Button();
            this.grdClients = new System.Windows.Forms.DataGridView();
            this.btnLoadClients = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSearchAccountsValue = new System.Windows.Forms.Button();
            this.txtAccountSearch = new System.Windows.Forms.TextBox();
            this.btnSearchAccounts = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLoadAccountValue = new System.Windows.Forms.Button();
            this.btnLoadAccountsSimple = new System.Windows.Forms.Button();
            this.txtAccountOverview = new System.Windows.Forms.Button();
            this.lblLoadAccountResults = new System.Windows.Forms.Label();
            this.grdAccounts = new System.Windows.Forms.DataGridView();
            this.btnLoadAllAccounts = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoginStatus = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEndpoint = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckToken
            // 
            this.btnCheckToken.Location = new System.Drawing.Point(18, 41);
            this.btnCheckToken.Name = "btnCheckToken";
            this.btnCheckToken.Size = new System.Drawing.Size(137, 23);
            this.btnCheckToken.TabIndex = 0;
            this.btnCheckToken.Text = "Check Token";
            this.btnCheckToken.UseVisualStyleBackColor = true;
            this.btnCheckToken.Click += new System.EventHandler(this.btnCheckToken_Click);
            // 
            // txtAuthToken
            // 
            this.txtAuthToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthToken.Location = new System.Drawing.Point(18, 15);
            this.txtAuthToken.Name = "txtAuthToken";
            this.txtAuthToken.Size = new System.Drawing.Size(917, 20);
            this.txtAuthToken.TabIndex = 1;
            this.txtAuthToken.Text = "<no token>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Orion Connect Main Menu";
            // 
            // btnLaunchConnectMenu
            // 
            this.btnLaunchConnectMenu.Location = new System.Drawing.Point(181, 81);
            this.btnLaunchConnectMenu.Name = "btnLaunchConnectMenu";
            this.btnLaunchConnectMenu.Size = new System.Drawing.Size(75, 23);
            this.btnLaunchConnectMenu.TabIndex = 5;
            this.btnLaunchConnectMenu.Text = "Launch";
            this.btnLaunchConnectMenu.UseVisualStyleBackColor = true;
            this.btnLaunchConnectMenu.Click += new System.EventHandler(this.btnLaunchConnectMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Household Overview";
            // 
            // btnLaunchHHOverview
            // 
            this.btnLaunchHHOverview.Location = new System.Drawing.Point(181, 128);
            this.btnLaunchHHOverview.Name = "btnLaunchHHOverview";
            this.btnLaunchHHOverview.Size = new System.Drawing.Size(75, 23);
            this.btnLaunchHHOverview.TabIndex = 7;
            this.btnLaunchHHOverview.Text = "Launch";
            this.btnLaunchHHOverview.UseVisualStyleBackColor = true;
            this.btnLaunchHHOverview.Click += new System.EventHandler(this.btnLaunchHHOverview_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "For ClientId:";
            // 
            // txtHouseholdId
            // 
            this.txtHouseholdId.Location = new System.Drawing.Point(331, 131);
            this.txtHouseholdId.Name = "txtHouseholdId";
            this.txtHouseholdId.Size = new System.Drawing.Size(69, 20);
            this.txtHouseholdId.TabIndex = 9;
            this.txtHouseholdId.Text = "46";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(474, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "OrionConnect URL: https://testapi.orionadvisor.com/OrionConnectApp/integration.ht" +
    "ml?t={token}&&\r\np={page}\r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 465);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClientSearchValue);
            this.tabPage2.Controls.Add(this.txtClientSearch);
            this.tabPage2.Controls.Add(this.btnSearchClients);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnClientSimpleWithValue);
            this.tabPage2.Controls.Add(this.btnClientSimple);
            this.tabPage2.Controls.Add(this.btnLaunchOverview);
            this.tabPage2.Controls.Add(this.grdClients);
            this.tabPage2.Controls.Add(this.btnLoadClients);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(946, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clients";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClientSearchValue
            // 
            this.btnClientSearchValue.Location = new System.Drawing.Point(644, 150);
            this.btnClientSearchValue.Name = "btnClientSearchValue";
            this.btnClientSearchValue.Size = new System.Drawing.Size(236, 23);
            this.btnClientSearchValue.TabIndex = 15;
            this.btnClientSearchValue.Text = "Search Clients With Value";
            this.btnClientSearchValue.UseVisualStyleBackColor = true;
            this.btnClientSearchValue.Click += new System.EventHandler(this.btnClientSearchValue_Click);
            // 
            // txtClientSearch
            // 
            this.txtClientSearch.Location = new System.Drawing.Point(644, 95);
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.Size = new System.Drawing.Size(236, 20);
            this.txtClientSearch.TabIndex = 14;
            this.txtClientSearch.Text = "enter name or id to search";
            // 
            // btnSearchClients
            // 
            this.btnSearchClients.Location = new System.Drawing.Point(644, 121);
            this.btnSearchClients.Name = "btnSearchClients";
            this.btnSearchClients.Size = new System.Drawing.Size(236, 23);
            this.btnSearchClients.TabIndex = 13;
            this.btnSearchClients.Text = "Search Clients";
            this.btnSearchClients.UseVisualStyleBackColor = true;
            this.btnSearchClients.Click += new System.EventHandler(this.btnSearchClients_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(940, 66);
            this.label6.TabIndex = 12;
            this.label6.Text = "Demonstrates querying all clients, and Searching Clients.  The /Simple and /Value" +
    " endpoints return slimmed down objects to reduce overhead, useful for things lik" +
    "e populating drop downs.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClientSimpleWithValue
            // 
            this.btnClientSimpleWithValue.Location = new System.Drawing.Point(326, 133);
            this.btnClientSimpleWithValue.Name = "btnClientSimpleWithValue";
            this.btnClientSimpleWithValue.Size = new System.Drawing.Size(236, 23);
            this.btnClientSimpleWithValue.TabIndex = 5;
            this.btnClientSimpleWithValue.Text = "Load Simple With Value";
            this.btnClientSimpleWithValue.UseVisualStyleBackColor = true;
            this.btnClientSimpleWithValue.Click += new System.EventHandler(this.btnClientSimpleWithValue_Click);
            // 
            // btnClientSimple
            // 
            this.btnClientSimple.Location = new System.Drawing.Point(142, 133);
            this.btnClientSimple.Name = "btnClientSimple";
            this.btnClientSimple.Size = new System.Drawing.Size(178, 23);
            this.btnClientSimple.TabIndex = 4;
            this.btnClientSimple.Text = "Load Simple (for drop downs)";
            this.btnClientSimple.UseVisualStyleBackColor = true;
            this.btnClientSimple.Click += new System.EventHandler(this.btnClientSimple_Click);
            // 
            // btnLaunchOverview
            // 
            this.btnLaunchOverview.Location = new System.Drawing.Point(23, 389);
            this.btnLaunchOverview.Name = "btnLaunchOverview";
            this.btnLaunchOverview.Size = new System.Drawing.Size(167, 23);
            this.btnLaunchOverview.TabIndex = 3;
            this.btnLaunchOverview.Text = "Launch Overview";
            this.btnLaunchOverview.UseVisualStyleBackColor = true;
            this.btnLaunchOverview.Click += new System.EventHandler(this.btnLaunchOverview_Click);
            // 
            // grdClients
            // 
            this.grdClients.AllowUserToOrderColumns = true;
            this.grdClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClients.Location = new System.Drawing.Point(23, 179);
            this.grdClients.Name = "grdClients";
            this.grdClients.Size = new System.Drawing.Size(894, 204);
            this.grdClients.TabIndex = 1;
            // 
            // btnLoadClients
            // 
            this.btnLoadClients.Location = new System.Drawing.Point(23, 133);
            this.btnLoadClients.Name = "btnLoadClients";
            this.btnLoadClients.Size = new System.Drawing.Size(113, 23);
            this.btnLoadClients.TabIndex = 0;
            this.btnLoadClients.Text = "Load All Clients";
            this.btnLoadClients.UseVisualStyleBackColor = true;
            this.btnLoadClients.Click += new System.EventHandler(this.btnLoadClients_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSearchAccountsValue);
            this.tabPage3.Controls.Add(this.txtAccountSearch);
            this.tabPage3.Controls.Add(this.btnSearchAccounts);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnLoadAccountValue);
            this.tabPage3.Controls.Add(this.btnLoadAccountsSimple);
            this.tabPage3.Controls.Add(this.txtAccountOverview);
            this.tabPage3.Controls.Add(this.lblLoadAccountResults);
            this.tabPage3.Controls.Add(this.grdAccounts);
            this.tabPage3.Controls.Add(this.btnLoadAllAccounts);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(946, 439);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Accounts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSearchAccountsValue
            // 
            this.btnSearchAccountsValue.Location = new System.Drawing.Point(645, 133);
            this.btnSearchAccountsValue.Name = "btnSearchAccountsValue";
            this.btnSearchAccountsValue.Size = new System.Drawing.Size(236, 23);
            this.btnSearchAccountsValue.TabIndex = 25;
            this.btnSearchAccountsValue.Text = "Search Accounts With Value";
            this.btnSearchAccountsValue.UseVisualStyleBackColor = true;
            this.btnSearchAccountsValue.Click += new System.EventHandler(this.btnSearchAccountsValue_Click);
            // 
            // txtAccountSearch
            // 
            this.txtAccountSearch.Location = new System.Drawing.Point(645, 78);
            this.txtAccountSearch.Name = "txtAccountSearch";
            this.txtAccountSearch.Size = new System.Drawing.Size(236, 20);
            this.txtAccountSearch.TabIndex = 24;
            this.txtAccountSearch.Text = "enter name or id to search";
            // 
            // btnSearchAccounts
            // 
            this.btnSearchAccounts.Location = new System.Drawing.Point(645, 104);
            this.btnSearchAccounts.Name = "btnSearchAccounts";
            this.btnSearchAccounts.Size = new System.Drawing.Size(236, 23);
            this.btnSearchAccounts.TabIndex = 23;
            this.btnSearchAccounts.Text = "Search Accounts";
            this.btnSearchAccounts.UseVisualStyleBackColor = true;
            this.btnSearchAccounts.Click += new System.EventHandler(this.btnSearchAccounts_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(946, 66);
            this.label7.TabIndex = 22;
            this.label7.Text = "Demonstrates querying all accounts, and Searching Accounts.  The /Simple and /Val" +
    "ue endpoints return slimmed down objects to reduce overhead, useful for things l" +
    "ike populating drop downs.\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoadAccountValue
            // 
            this.btnLoadAccountValue.Location = new System.Drawing.Point(327, 116);
            this.btnLoadAccountValue.Name = "btnLoadAccountValue";
            this.btnLoadAccountValue.Size = new System.Drawing.Size(236, 23);
            this.btnLoadAccountValue.TabIndex = 21;
            this.btnLoadAccountValue.Text = "Load Simple With Value";
            this.btnLoadAccountValue.UseVisualStyleBackColor = true;
            this.btnLoadAccountValue.Click += new System.EventHandler(this.btnLoadAccountValue_Click);
            // 
            // btnLoadAccountsSimple
            // 
            this.btnLoadAccountsSimple.Location = new System.Drawing.Point(143, 116);
            this.btnLoadAccountsSimple.Name = "btnLoadAccountsSimple";
            this.btnLoadAccountsSimple.Size = new System.Drawing.Size(178, 23);
            this.btnLoadAccountsSimple.TabIndex = 20;
            this.btnLoadAccountsSimple.Text = "Load Simple (for drop downs)";
            this.btnLoadAccountsSimple.UseVisualStyleBackColor = true;
            this.btnLoadAccountsSimple.Click += new System.EventHandler(this.btnLoadAccountsSimple_Click);
            // 
            // txtAccountOverview
            // 
            this.txtAccountOverview.Location = new System.Drawing.Point(24, 372);
            this.txtAccountOverview.Name = "txtAccountOverview";
            this.txtAccountOverview.Size = new System.Drawing.Size(167, 23);
            this.txtAccountOverview.TabIndex = 19;
            this.txtAccountOverview.Text = "Launch Overview";
            this.txtAccountOverview.UseVisualStyleBackColor = true;
            this.txtAccountOverview.Click += new System.EventHandler(this.txtAccountOverview_Click);
            // 
            // lblLoadAccountResults
            // 
            this.lblLoadAccountResults.AutoSize = true;
            this.lblLoadAccountResults.Location = new System.Drawing.Point(29, 145);
            this.lblLoadAccountResults.Name = "lblLoadAccountResults";
            this.lblLoadAccountResults.Size = new System.Drawing.Size(0, 13);
            this.lblLoadAccountResults.TabIndex = 18;
            // 
            // grdAccounts
            // 
            this.grdAccounts.AllowUserToOrderColumns = true;
            this.grdAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAccounts.Location = new System.Drawing.Point(24, 162);
            this.grdAccounts.Name = "grdAccounts";
            this.grdAccounts.Size = new System.Drawing.Size(894, 204);
            this.grdAccounts.TabIndex = 17;
            // 
            // btnLoadAllAccounts
            // 
            this.btnLoadAllAccounts.Location = new System.Drawing.Point(24, 116);
            this.btnLoadAllAccounts.Name = "btnLoadAllAccounts";
            this.btnLoadAllAccounts.Size = new System.Drawing.Size(113, 23);
            this.btnLoadAllAccounts.TabIndex = 16;
            this.btnLoadAllAccounts.Text = "Load All Accounts";
            this.btnLoadAllAccounts.UseVisualStyleBackColor = true;
            this.btnLoadAllAccounts.Click += new System.EventHandler(this.btnLoadAllAccounts_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtHouseholdId);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnLaunchConnectMenu);
            this.tabPage1.Controls.Add(this.btnLaunchHHOverview);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Launch Orion Connect";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(940, 66);
            this.label5.TabIndex = 11;
            this.label5.Text = "Demonstrates using the api token to launch Orion Connect.  This is a contextual l" +
    "ink to orion screens, that can be linked to from other systems such as a CRM.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblLoginStatus);
            this.panel1.Controls.Add(this.txtAuthToken);
            this.panel1.Controls.Add(this.btnCheckToken);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 82);
            this.panel1.TabIndex = 12;
            // 
            // lblLoginStatus
            // 
            this.lblLoginStatus.AutoSize = true;
            this.lblLoginStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginStatus.Location = new System.Drawing.Point(178, 46);
            this.lblLoginStatus.Name = "lblLoginStatus";
            this.lblLoginStatus.Size = new System.Drawing.Size(185, 17);
            this.lblLoginStatus.TabIndex = 2;
            this.lblLoginStatus.Text = "Currently Not Logged In!";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblEndpoint});
            this.statusStrip.Location = new System.Drawing.Point(0, 525);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(954, 22);
            this.statusStrip.TabIndex = 27;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 17);
            this.lblStatus.Text = "Not logged in";
            // 
            // lblEndpoint
            // 
            this.lblEndpoint.Name = "lblEndpoint";
            this.lblEndpoint.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 547);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Orion Api SDK Sample Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckToken;
        private System.Windows.Forms.TextBox txtAuthToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLaunchConnectMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLaunchHHOverview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHouseholdId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadClients;
        private System.Windows.Forms.DataGridView grdClients;
        private System.Windows.Forms.Button btnLaunchOverview;
        private System.Windows.Forms.Button btnClientSimple;
        private System.Windows.Forms.Button btnClientSimpleWithValue;
        private System.Windows.Forms.TextBox txtClientSearch;
        private System.Windows.Forms.Button btnSearchClients;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClientSearchValue;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSearchAccountsValue;
        private System.Windows.Forms.TextBox txtAccountSearch;
        private System.Windows.Forms.Button btnSearchAccounts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLoadAccountValue;
        private System.Windows.Forms.Button btnLoadAccountsSimple;
        private System.Windows.Forms.Button txtAccountOverview;
        private System.Windows.Forms.Label lblLoadAccountResults;
        private System.Windows.Forms.DataGridView grdAccounts;
        private System.Windows.Forms.Button btnLoadAllAccounts;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblEndpoint;
        private System.Windows.Forms.Label lblLoginStatus;
    }
}

