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
            this.tabClients = new System.Windows.Forms.TabPage();
            this.cmdEditClient = new System.Windows.Forms.Button();
            this.cmdNewClient = new System.Windows.Forms.Button();
            this.btnClientSearchValue = new System.Windows.Forms.Button();
            this.txtClientSearch = new System.Windows.Forms.TextBox();
            this.btnSearchClients = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClientSimpleWithValue = new System.Windows.Forms.Button();
            this.btnClientSimple = new System.Windows.Forms.Button();
            this.btnLaunchOverview = new System.Windows.Forms.Button();
            this.grdClients = new System.Windows.Forms.DataGridView();
            this.btnLoadClients = new System.Windows.Forms.Button();
            this.tabRegistrations = new System.Windows.Forms.TabPage();
            this.btnEditRegistration = new System.Windows.Forms.Button();
            this.btnNewRegistration = new System.Windows.Forms.Button();
            this.txtRegistrationSearch = new System.Windows.Forms.TextBox();
            this.btnSearchRegistrations = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLoadSimpleRegistration = new System.Windows.Forms.Button();
            this.grdRegistrations = new System.Windows.Forms.DataGridView();
            this.btnLoadRegistrations = new System.Windows.Forms.Button();
            this.tabAccounts = new System.Windows.Forms.TabPage();
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
            this.tabLaunchOC = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoginStatus = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEndpoint = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).BeginInit();
            this.tabRegistrations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRegistrations)).BeginInit();
            this.tabAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).BeginInit();
            this.tabLaunchOC.SuspendLayout();
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
            this.btnCheckToken.Text = "Check Token / Login";
            this.btnCheckToken.UseVisualStyleBackColor = true;
            this.btnCheckToken.Click += new System.EventHandler(this.btnCheckToken_Click);
            // 
            // txtAuthToken
            // 
            this.txtAuthToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthToken.Location = new System.Drawing.Point(18, 15);
            this.txtAuthToken.Name = "txtAuthToken";
            this.txtAuthToken.Size = new System.Drawing.Size(981, 20);
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
            this.label4.Location = new System.Drawing.Point(11, 685);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(474, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "OrionConnect URL: https://testapi.orionadvisor.com/OrionConnectApp/integration.ht" +
    "ml?t={token}&&\r\np={page}\r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClients);
            this.tabControl1.Controls.Add(this.tabRegistrations);
            this.tabControl1.Controls.Add(this.tabAccounts);
            this.tabControl1.Controls.Add(this.tabLaunchOC);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1018, 552);
            this.tabControl1.TabIndex = 11;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.cmdEditClient);
            this.tabClients.Controls.Add(this.cmdNewClient);
            this.tabClients.Controls.Add(this.btnClientSearchValue);
            this.tabClients.Controls.Add(this.txtClientSearch);
            this.tabClients.Controls.Add(this.btnSearchClients);
            this.tabClients.Controls.Add(this.label6);
            this.tabClients.Controls.Add(this.btnClientSimpleWithValue);
            this.tabClients.Controls.Add(this.btnClientSimple);
            this.tabClients.Controls.Add(this.btnLaunchOverview);
            this.tabClients.Controls.Add(this.grdClients);
            this.tabClients.Controls.Add(this.btnLoadClients);
            this.tabClients.Location = new System.Drawing.Point(4, 22);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(1010, 526);
            this.tabClients.TabIndex = 1;
            this.tabClients.Text = "Clients";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // cmdEditClient
            // 
            this.cmdEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdEditClient.Location = new System.Drawing.Point(250, 476);
            this.cmdEditClient.Name = "cmdEditClient";
            this.cmdEditClient.Size = new System.Drawing.Size(167, 23);
            this.cmdEditClient.TabIndex = 17;
            this.cmdEditClient.Text = "Edit Client...";
            this.cmdEditClient.UseVisualStyleBackColor = true;
            this.cmdEditClient.Click += new System.EventHandler(this.cmdEditClient_Click);
            // 
            // cmdNewClient
            // 
            this.cmdNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdNewClient.Location = new System.Drawing.Point(449, 476);
            this.cmdNewClient.Name = "cmdNewClient";
            this.cmdNewClient.Size = new System.Drawing.Size(167, 23);
            this.cmdNewClient.TabIndex = 16;
            this.cmdNewClient.Text = "New Client...";
            this.cmdNewClient.UseVisualStyleBackColor = true;
            this.cmdNewClient.Click += new System.EventHandler(this.cmdNewClient_Click);
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
            this.label6.Size = new System.Drawing.Size(1004, 66);
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
            this.btnLaunchOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLaunchOverview.Location = new System.Drawing.Point(23, 476);
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
            this.grdClients.Size = new System.Drawing.Size(958, 291);
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
            // tabRegistrations
            // 
            this.tabRegistrations.Controls.Add(this.btnEditRegistration);
            this.tabRegistrations.Controls.Add(this.btnNewRegistration);
            this.tabRegistrations.Controls.Add(this.txtRegistrationSearch);
            this.tabRegistrations.Controls.Add(this.btnSearchRegistrations);
            this.tabRegistrations.Controls.Add(this.label8);
            this.tabRegistrations.Controls.Add(this.btnLoadSimpleRegistration);
            this.tabRegistrations.Controls.Add(this.grdRegistrations);
            this.tabRegistrations.Controls.Add(this.btnLoadRegistrations);
            this.tabRegistrations.Location = new System.Drawing.Point(4, 22);
            this.tabRegistrations.Name = "tabRegistrations";
            this.tabRegistrations.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrations.Size = new System.Drawing.Size(1010, 526);
            this.tabRegistrations.TabIndex = 3;
            this.tabRegistrations.Text = "Registrations";
            this.tabRegistrations.UseVisualStyleBackColor = true;
            // 
            // btnEditRegistration
            // 
            this.btnEditRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditRegistration.Location = new System.Drawing.Point(275, 470);
            this.btnEditRegistration.Name = "btnEditRegistration";
            this.btnEditRegistration.Size = new System.Drawing.Size(167, 23);
            this.btnEditRegistration.TabIndex = 28;
            this.btnEditRegistration.Text = "Edit Registration...";
            this.btnEditRegistration.UseVisualStyleBackColor = true;
            this.btnEditRegistration.Click += new System.EventHandler(this.btnEditRegistration_Click);
            // 
            // btnNewRegistration
            // 
            this.btnNewRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewRegistration.Location = new System.Drawing.Point(448, 470);
            this.btnNewRegistration.Name = "btnNewRegistration";
            this.btnNewRegistration.Size = new System.Drawing.Size(167, 23);
            this.btnNewRegistration.TabIndex = 27;
            this.btnNewRegistration.Text = "New Registration...";
            this.btnNewRegistration.UseVisualStyleBackColor = true;
            this.btnNewRegistration.Click += new System.EventHandler(this.btnNewRegistration_Click);
            // 
            // txtRegistrationSearch
            // 
            this.txtRegistrationSearch.Location = new System.Drawing.Point(644, 119);
            this.txtRegistrationSearch.Name = "txtRegistrationSearch";
            this.txtRegistrationSearch.Size = new System.Drawing.Size(236, 20);
            this.txtRegistrationSearch.TabIndex = 25;
            this.txtRegistrationSearch.Text = "enter name or id to search";
            // 
            // btnSearchRegistrations
            // 
            this.btnSearchRegistrations.Location = new System.Drawing.Point(644, 145);
            this.btnSearchRegistrations.Name = "btnSearchRegistrations";
            this.btnSearchRegistrations.Size = new System.Drawing.Size(236, 23);
            this.btnSearchRegistrations.TabIndex = 24;
            this.btnSearchRegistrations.Text = "Search Registrations";
            this.btnSearchRegistrations.UseVisualStyleBackColor = true;
            this.btnSearchRegistrations.Click += new System.EventHandler(this.btnSearchRegistrations_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1004, 66);
            this.label8.TabIndex = 23;
            this.label8.Text = "Demonstrates querying all clients, and Searching Clients.  The /Simple and /Value" +
    " endpoints return slimmed down objects to reduce overhead, useful for things lik" +
    "e populating drop downs.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoadSimpleRegistration
            // 
            this.btnLoadSimpleRegistration.Location = new System.Drawing.Point(183, 145);
            this.btnLoadSimpleRegistration.Name = "btnLoadSimpleRegistration";
            this.btnLoadSimpleRegistration.Size = new System.Drawing.Size(178, 23);
            this.btnLoadSimpleRegistration.TabIndex = 21;
            this.btnLoadSimpleRegistration.Text = "Load Simple (for drop downs)";
            this.btnLoadSimpleRegistration.UseVisualStyleBackColor = true;
            this.btnLoadSimpleRegistration.Click += new System.EventHandler(this.btnLoadSimpleRegistration_Click);
            // 
            // grdRegistrations
            // 
            this.grdRegistrations.AllowUserToOrderColumns = true;
            this.grdRegistrations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRegistrations.Location = new System.Drawing.Point(23, 191);
            this.grdRegistrations.Name = "grdRegistrations";
            this.grdRegistrations.Size = new System.Drawing.Size(958, 273);
            this.grdRegistrations.TabIndex = 19;
            // 
            // btnLoadRegistrations
            // 
            this.btnLoadRegistrations.Location = new System.Drawing.Point(23, 145);
            this.btnLoadRegistrations.Name = "btnLoadRegistrations";
            this.btnLoadRegistrations.Size = new System.Drawing.Size(154, 23);
            this.btnLoadRegistrations.TabIndex = 18;
            this.btnLoadRegistrations.Text = "Load All Registrations";
            this.btnLoadRegistrations.UseVisualStyleBackColor = true;
            this.btnLoadRegistrations.Click += new System.EventHandler(this.btnLoadRegistrations_Click);
            // 
            // tabAccounts
            // 
            this.tabAccounts.Controls.Add(this.btnSearchAccountsValue);
            this.tabAccounts.Controls.Add(this.txtAccountSearch);
            this.tabAccounts.Controls.Add(this.btnSearchAccounts);
            this.tabAccounts.Controls.Add(this.label7);
            this.tabAccounts.Controls.Add(this.btnLoadAccountValue);
            this.tabAccounts.Controls.Add(this.btnLoadAccountsSimple);
            this.tabAccounts.Controls.Add(this.txtAccountOverview);
            this.tabAccounts.Controls.Add(this.lblLoadAccountResults);
            this.tabAccounts.Controls.Add(this.grdAccounts);
            this.tabAccounts.Controls.Add(this.btnLoadAllAccounts);
            this.tabAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.Size = new System.Drawing.Size(1010, 526);
            this.tabAccounts.TabIndex = 2;
            this.tabAccounts.Text = "Accounts";
            this.tabAccounts.UseVisualStyleBackColor = true;
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
            this.label7.Size = new System.Drawing.Size(1010, 66);
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
            this.txtAccountOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAccountOverview.Location = new System.Drawing.Point(24, 444);
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
            this.grdAccounts.Size = new System.Drawing.Size(940, 276);
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
            // tabLaunchOC
            // 
            this.tabLaunchOC.Controls.Add(this.label5);
            this.tabLaunchOC.Controls.Add(this.label4);
            this.tabLaunchOC.Controls.Add(this.txtHouseholdId);
            this.tabLaunchOC.Controls.Add(this.label1);
            this.tabLaunchOC.Controls.Add(this.label3);
            this.tabLaunchOC.Controls.Add(this.btnLaunchConnectMenu);
            this.tabLaunchOC.Controls.Add(this.btnLaunchHHOverview);
            this.tabLaunchOC.Controls.Add(this.label2);
            this.tabLaunchOC.Location = new System.Drawing.Point(4, 22);
            this.tabLaunchOC.Name = "tabLaunchOC";
            this.tabLaunchOC.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaunchOC.Size = new System.Drawing.Size(1010, 526);
            this.tabLaunchOC.TabIndex = 0;
            this.tabLaunchOC.Text = "Launch Orion Connect";
            this.tabLaunchOC.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1004, 66);
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
            this.panel1.Size = new System.Drawing.Size(1018, 82);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 612);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip.TabIndex = 27;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
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
            this.ClientSize = new System.Drawing.Size(1018, 634);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Orion Api SDK Sample Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            this.tabClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).EndInit();
            this.tabRegistrations.ResumeLayout(false);
            this.tabRegistrations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRegistrations)).EndInit();
            this.tabAccounts.ResumeLayout(false);
            this.tabAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).EndInit();
            this.tabLaunchOC.ResumeLayout(false);
            this.tabLaunchOC.PerformLayout();
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
        private System.Windows.Forms.TabPage tabLaunchOC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabClients;
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
        private System.Windows.Forms.TabPage tabAccounts;
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
        private System.Windows.Forms.Button cmdEditClient;
        private System.Windows.Forms.Button cmdNewClient;
        private System.Windows.Forms.TabPage tabRegistrations;
        private System.Windows.Forms.Button btnEditRegistration;
        private System.Windows.Forms.Button btnNewRegistration;
        private System.Windows.Forms.TextBox txtRegistrationSearch;
        private System.Windows.Forms.Button btnSearchRegistrations;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLoadSimpleRegistration;
        private System.Windows.Forms.DataGridView grdRegistrations;
        private System.Windows.Forms.Button btnLoadRegistrations;
    }
}

