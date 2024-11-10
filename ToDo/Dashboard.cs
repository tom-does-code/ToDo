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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            await InitializeData();
        }

        private async void InitializeData()
        {
            User? user = User.CurrentUser;

            if (user != null)
            {
                async Task<bool> InitializeUser()
                {
                    await Task.Run(() =>
                    {
                        label3.Text = user.Username;
                        label4.Text = user.AccountNumber.ToString();
                        label5.Text = user.DateOfBirth;
                    });

                    return true;
                }

            } else
            {
                MessageBox.Show("User failed to initialize, please try again.");
                this.Close();
            }
        }
    }
}
