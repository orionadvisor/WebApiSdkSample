using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrionApiSdk;
using OrionApiSdk.Classes.Portfolio;

namespace OrionConnect_Api_Sample
{
    public partial class frmClient : Form {
        private ClientVerbose _clientVerbose;

        public ClientVerbose ClientVerbose { get { return _clientVerbose;  } set { _clientVerbose = value; } }
        
        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            // load reps combo
            cboRep.DisplayMember = "name";
            cboRep.ValueMember = "id";
            cboRep.DataSource = OrionApi.Portfolio.RepresentativesSimple();

            // if the clientverbose has not been set, initialize a new one.
            if( this._clientVerbose == null ) {
                this._clientVerbose = OrionApi.Portfolio.ClientVerboseNew( );
            }


            // Basic data is popualted in ClientVerbose.Portfolio
            txtCientFName.Text = _clientVerbose.portfolio.firstName;
            txtClientLName.Text = _clientVerbose.portfolio.lastName;
            txtClientAddr1.Text = _clientVerbose.portfolio.address1;
            txtClientAddr2.Text = _clientVerbose.portfolio.address2;
            txtClientCity.Text = _clientVerbose.portfolio.city;
            txtClientState.Text = _clientVerbose.portfolio.state;
            txtClientZip.Text = _clientVerbose.portfolio.zip;

            if( _clientVerbose.id == 0 )
                this.Text = "Add new client record";
            else 
                this.Text = string.Format( "Edit Client: {0} ({1})", _clientVerbose.name, _clientVerbose.id );
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            // fill out the client verbose properties, and save changes.
            _clientVerbose.portfolio.representativeId = (int)cboRep.SelectedValue;
            _clientVerbose.portfolio.firstName = txtCientFName.Text;
            _clientVerbose.portfolio.lastName = txtClientLName.Text;
            _clientVerbose.portfolio.name = txtClientFullName.Text;

            _clientVerbose.portfolio.address1 = txtClientAddr1.Text;
            _clientVerbose.portfolio.address2 = txtClientAddr2.Text;
            _clientVerbose.portfolio.city = txtClientCity.Text;
            _clientVerbose.portfolio.state = txtClientState.Text;
            _clientVerbose.portfolio.zip = txtClientZip.Text;
            
            _clientVerbose = OrionApi.Portfolio.ClientSave( _clientVerbose );

            MessageBox.Show( "Client id: " + _clientVerbose.id.ToString( ) + " was saved." );

            this.Close();
        }

        private void txtCientFName_TextChanged(object sender, EventArgs e) {
            txtClientFullName.Text = txtCientFName.Text + " " + txtClientLName.Text;
        }

        private void txtClientFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClientLName_TextChanged(object sender, EventArgs e)
        {
            txtClientFullName.Text = txtCientFName.Text + " " + txtClientLName.Text;
        }                                             
    }
}
