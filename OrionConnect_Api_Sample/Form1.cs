using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrionApiSdk;
using OrionApiSdk.Classes.Enums;
using OrionApiSdk.Classes.Portfolio;

namespace OrionConnect_Api_Sample
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Helpers

        private void setStatus(string status, string endpoint = "")
        {
            statusStrip.Items["lblStatus"].Text = status;
            statusStrip.Items["lblEndpoint"].Text = "endpoint: " + endpoint;
        }

        private bool checkAuth()
        {
            if( !string.IsNullOrEmpty( OrionApi.AuthToken ) )
                return true;
            MessageBox.Show("You must authenticate first.");
            return false;
        }

        #endregion

        #region Login
        private void btnCheckToken_Click(object sender, EventArgs e) {


            lblLoginStatus.Text = "";
            try {
                // use the "stored" token, in this case it is just the token in the text box.
                if( OrionApi.Authenticate( txtAuthToken.Text, OrionEnvironment.Test ) ) {
                    MessageBox.Show( "The token is valid." );
                } else
                {
                    MessageBox.Show("Token is not valid, you will need to login.");

                    var login = new frmLogin();
                    if( login.ShowDialog( ) == DialogResult.OK ) {
                        OrionApi.Authenticate( login.UserName, login.Password, OrionEnvironment.Test );
                        this.setStatus( "Authenticate", "/Security/Token" );
                    } else {
                        return;
                    }
                    txtAuthToken.Text = OrionApi.AuthToken;
                }
                var user = OrionApi.Authorization.User( );
                lblLoginStatus.Text = "Current User: " + user.loginUserId + ", Database: " + user.alClientName;

            } catch( Exception ex ) {
                MessageBox.Show( ex.Message );
            }
        }
        #endregion

        #region Launch OrionConnect
        private void btnLaunchConnectMenu_Click(object sender, EventArgs e) {
            if (!this.checkAuth()) return;
            var url = OrionApi.OrionConnectLinks.AppsMenu( );

            Process.Start( url );
            this.setStatus( "Launch Menu", url  );
        }

        private void btnLaunchHHOverview_Click(object sender, EventArgs e) {
            if (!this.checkAuth()) return;

            Process.Start( OrionApi.OrionConnectLinks.HouseholdOverview( Entity.Client, int.Parse( txtHouseholdId.Text  )  ));

            this.setStatus("Launch Overview"  );
        }
        #endregion

        #region Clients Tab


        private void btnLoadClients_Click(object sender, EventArgs e) {
            if( !this.checkAuth()  ) return;

            grdClients.DataSource = OrionApi.Portfolio.Clients( );
            this.setStatus( string.Format( "{0} Clients Loaded.", grdClients.RowCount ), "/Portfolio/Clients");
        }

        private void btnLaunchOverview_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;

            if(  grdClients.SelectedRows.Count == 0 ) {
                MessageBox.Show( "Select a client from the grid." );
                return;
            }

            // cast the selected row into the original object.
            var clientId = (int)(grdClients.SelectedRows[ 0 ].Cells[ "id" ].Value);

            string url = OrionApi.OrionConnectLinks.HouseholdOverview( Entity.Client, clientId );

            Process.Start(url);

            this.setStatus(string.Format("Lauch Household Overview", grdClients.RowCount), url);
        }

        private void btnClientSimple_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;

            grdClients.DataSource = OrionApi.Portfolio.ClientsSimple();
            this.setStatus(string.Format("{0} Simiple Clients Loaded.", grdClients.RowCount), "/Portfolio/Clients/Simple");
        }

        private void btnClientSimpleWithValue_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;

            grdClients.DataSource = OrionApi.Portfolio.ClientsValue();
            this.setStatus( string.Format( "{0} Simple with Value Clients Loaded.", grdClients.RowCount ), "/Portfolio/Clients/Value" );
        }

        private void btnSearchClients_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;

            grdClients.DataSource = OrionApi.Portfolio.ClientsSearch( txtClientSearch.Text );
            this.setStatus( string.Format( "{0} Clients Loaded.", grdClients.RowCount ), "/Portfolio/Clients/Simple/Search?search=" + txtClientSearch.Text );
        }

        private void btnClientSearchValue_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;

            grdClients.DataSource = OrionApi.Portfolio.ClientsSearchValue(txtClientSearch.Text);
            this.setStatus(  string.Format("{0} Clients Loaded.", grdClients.RowCount), "Portfolio/Clients/Value/Search?search=" + txtClientSearch.Text);
        }

        private void cmdEditClient_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;
            var frm = new frmClient();

            // set the currently selected client (must use verbose objects for editing)
            frm.ClientVerbose = OrionApi.Portfolio.ClientVerbose((int)grdClients.SelectedRows[0].Cells["id"].Value);

            frm.ShowDialog();

        }

        private void cmdNewClient_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;
            var frm = new frmClient();

            frm.ShowDialog();
        }

        #endregion

        #region Accounts Tab
        private void btnLoadAllAccounts_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;

            grdAccounts.DataSource = OrionApi.Portfolio.Accounts();
            this.setStatus(string.Format("{0} Accounts Loaded.", grdAccounts.RowCount), "/Portfolio/Accounts");
        }

        private void btnLoadAccountsSimple_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;

            grdAccounts.DataSource = OrionApi.Portfolio.AccountsSimple();
            this.setStatus(string.Format("{0} Simple Accounts Loaded.", grdAccounts.RowCount), "/Portfolio/Accounts/Simple");
        }

        private void btnLoadAccountValue_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;

            grdAccounts.DataSource = OrionApi.Portfolio.AccountsValue();
            this.setStatus(string.Format("{0} Simple Value Accounts Loaded.", grdAccounts.RowCount), "/Portfolio/Accounts/Value");
        }

        private void btnSearchAccounts_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;

            grdAccounts.DataSource = OrionApi.Portfolio.AccountsSearch( txtAccountSearch.Text );
            this.setStatus(string.Format("{0} Accounts Found.", grdAccounts.RowCount), "/Portfolio/Accounts/Simple/Search?search=" + txtAccountSearch.Text);
        }

        private void btnSearchAccountsValue_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;

            grdAccounts.DataSource = OrionApi.Portfolio.AccountsValueSearch(txtAccountSearch.Text);
            this.setStatus(string.Format("{0} Accounts Found.", grdAccounts.RowCount), "/Portfolio/Accounts/Value/Search?search=" + txtAccountSearch.Text);
        }

        private void txtAccountOverview_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;

            if (grdAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an account from the grid.");
                return;
            }

            // cast the selected row into the original object.
            var accountId = (int)grdAccounts.SelectedRows[0].Cells["id"].Value;

            // add the auth token to the string, and launch the url, passing the auth token.
            string url = OrionApi.OrionConnectLinks.HouseholdOverview( Entity.Account, accountId );

            Process.Start(url);

            this.setStatus(string.Format("Lauch Account Overview for accountId {0}", accountId), url);
        }


        #endregion

        private void btnLoadRegistrations_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;
            grdRegistrations.DataSource = OrionApi.Portfolio.Registrations( top: 1000 );

        }

        private void btnLoadSimpleRegistration_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;
            grdRegistrations.DataSource = OrionApi.Portfolio.RegistrationsSimple();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchRegistrations_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;
            grdRegistrations.DataSource = OrionApi.Portfolio.RegistrationsSearch( txtRegistrationSearch.Text );

        }

        private void btnEditRegistration_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;
            var frm = new frmRegistration();

            if( grdRegistrations.Rows.Count == 0 ) {
                MessageBox.Show( "select registration from grid." );
                return;
            }

            // set the currently selected client (must use verbose objects for editing)
            frm.RegistrationVerbose = OrionApi.Portfolio.RegistrationVerbose((int)grdRegistrations.SelectedRows[0].Cells["id"].Value);

            frm.ShowDialog();

        }

        private void btnNewRegistration_Click(object sender, EventArgs e)
        {
            if (!this.checkAuth()) return;
            var frm = new frmRegistration();

            frm.ShowDialog();

        }









    }
}
