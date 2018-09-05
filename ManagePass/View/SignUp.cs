using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerPass
{

    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();
        }

        private void tbNIckname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ControllerSignUp controllerSignUp = new ControllerSignUp();
            controllerSignUp.AddPass(tbLogin.Text, tbPassword.Text);
        }
    }
}
