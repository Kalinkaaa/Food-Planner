using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            DialogResult response;
            if(txtPassword.Text == Convert.ToString(txtPassword.Tag))
            {
                MessageBox.Show("You've passed security!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                response = MessageBox.Show("Incorrect Password", "Access Denied", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if(response == DialogResult.Retry)
                {
                    txtPassword.SelectionStart = 0;
                    txtPassword.SelectionLength = txtPassword.Text.Length;
                }
                else
                {
                    this.Close();
                }
            }
            txtPassword.Focus();
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {
            this.Show();
            txtPassword.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
