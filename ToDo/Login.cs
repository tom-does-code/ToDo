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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            SignUp signForm = new SignUp();

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == signForm.GetType())
                {
                    openForm.BringToFront();
                    return;
                }
            }

            signForm.Show();
        }
    }
}
