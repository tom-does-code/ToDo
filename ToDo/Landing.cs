using System;
using System.Windows.Forms;

namespace ToDo
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            NewTask secondForm = new NewTask();

            secondForm.Show();
        }
    }
}
