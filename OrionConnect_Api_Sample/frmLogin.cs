using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrionConnect_Api_Sample
{
    public partial class frmLogin : Form
    {
        public string UserName { get { return txtUserName.Text;  } }
        public string Password { get { return txtPassword.Text; } }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            
        }
    }
}
