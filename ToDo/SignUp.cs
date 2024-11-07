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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpConf_Click(object sender, EventArgs e)
        {
            DatabaseModel dbModel = new DatabaseModel();

            Random random = new Random();

            string userInput = UsernameInput.Text;

            string passwordInput = PasswordInput.Text;

            string DOB = DateOfBirthInput.Value.ToString();

            if (userInput != "" && passwordInput != "")
            {
                if (dbModel.CheckIfUserExist(userInput) == false)
                {
                    int accountGenNumb = (int)random.Next(10000000, 100000000);
                    bool success = false;
                    int tries = 0;

                    while (success == false && tries < 10)
                    {

                        success = !dbModel.CheckIfAccountNumberExist(accountGenNumb);
                        tries++;

                        accountGenNumb = (int)random.Next(10000000, 100000000);
                    }

                    if (success == true)
                    {
                        dbModel.RegisterUser(userInput, passwordInput, accountGenNumb, DOB);
                        MessageBox.Show("User registered successfully.");
                    } else
                    {
                        MessageBox.Show($"Account number {accountGenNumb} already exists.");
                    }
                } else
                {
                    MessageBox.Show("User already exists.");
                }
            }
        }
    }
}
