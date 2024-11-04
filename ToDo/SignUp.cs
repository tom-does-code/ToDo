using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpConf_Click(object sender, EventArgs e)
        {
            string userInput = UsernameInput.Text;

            string passwordInput = PasswordInput.Text;

            if (userInput != "" && passwordInput != "")
            {

            }
        }
    }
}
