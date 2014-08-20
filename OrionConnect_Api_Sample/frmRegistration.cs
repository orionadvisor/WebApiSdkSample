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
    public partial class frmRegistration : Form {
        private RegistrationVerbose _registrationVerbose;

        public RegistrationVerbose RegistrationVerbose { get { return _registrationVerbose; } set { _registrationVerbose = value; } }
        
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

            // load clients combo
            cboClient.DisplayMember = "name";
            cboClient.ValueMember = "id";
            cboClient.DataSource = OrionApi.Portfolio.ClientsSimple( );
            
            
            // load account types combo
            cboAccountType.DisplayMember = "name";
            cboAccountType.ValueMember = "id";
            cboAccountType.DataSource = OrionApi.Portfolio.RepresentativesSimple( );


            // if the RegistrationVerbose has not been set, initialize a new one.
            if( this._registrationVerbose == null ) {
                this._registrationVerbose = OrionApi.Portfolio.RegistrationVerboseNew( );
            }


            // Basic data is popualted in RegistrationVerbose.Portfolio
            txtFirstName.Text = _registrationVerbose.portfolio.firstName;
            txtLastName.Text = _registrationVerbose.portfolio.lastName;
            txtBirthDate.Text = _registrationVerbose.portfolio.dob.HasValue ? _registrationVerbose.portfolio.dob.Value.ToShortDateString() : string.Empty;
            txtSSN.Text = _registrationVerbose.portfolio.ssN_TaxID;


            if( _registrationVerbose.id == 0 ) {
                this.Text = "Add new registration record";
            } else {
                this.Text = string.Format( "Edit Reg: {0} ({1})", _registrationVerbose.name, _registrationVerbose.id );
                cboClient.SelectedValue = _registrationVerbose.portfolio.clientId;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            // fill out the client verbose properties, and save changes.
            _registrationVerbose.portfolio.typeId = (int)cboAccountType.SelectedValue;
            _registrationVerbose.portfolio.firstName = txtFirstName.Text;
            _registrationVerbose.portfolio.lastName = txtLastName.Text;
            _registrationVerbose.portfolio.name = txtFullName.Text;
            if( txtBirthDate.Text.Length > 0 )
                _registrationVerbose.portfolio.dob = DateTime.Parse( txtBirthDate.Text );
            else
                _registrationVerbose.portfolio.dob = null;
            _registrationVerbose.beneficiaries = null;

            _registrationVerbose.portfolio.clientId = (int)cboClient.SelectedValue;
            _registrationVerbose = OrionApi.Portfolio.RegistrationSave( _registrationVerbose );


            MessageBox.Show( "Registration id: " + _registrationVerbose.id.ToString( ) + " was saved." );

            this.Close();
        }

        private void txtCientFName_TextChanged(object sender, EventArgs e) {
            txtFullName.Text = txtFirstName.Text + " " + txtLastName.Text;
        }

        private void txtClientFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClientLName_TextChanged(object sender, EventArgs e)
        {
            txtFullName.Text = txtFirstName.Text + " " + txtLastName.Text;
        }                                             
    }
}
