using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserModel;

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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            DatabaseModel usMod = new DatabaseModel();

            string userinput = UsernameInput.Text;
            string passwordinput = PasswordInput.Text;

            bool result = usMod.Login(userinput, passwordinput);

            if (result == true)
            {
                MessageBox.Show("Signing in.");
                Thread.Sleep(2000);

                User.CurrentUser = new User
                {
                    Username = userinput,
                    Password = passwordinput,
                    AccountNumber = usMod.ReturnAccountNumber(userinput),
                    DateOfBirth = usMod.ReturnDOB(userinput)
                };

                Landing landingForm = new Landing();
                landingForm.Show();

                this.Hide();
            } else
            {
                MessageBox.Show("Account not found.");
            }
        }
    }
}
