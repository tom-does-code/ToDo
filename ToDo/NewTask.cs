using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserModel;

namespace ToDo
{
    public partial class NewTask : Form
    {
        public event EventHandler? TaskSubmitted;
        public NewTask()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TaskInput.Text) || string.IsNullOrEmpty(DueInput.Text) || PriorityInput.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string? selectedPriority = PriorityInput?.SelectedItem?.ToString();

            if (selectedPriority == null)
            {
                MessageBox.Show("Please select a priority.");
                return;
            }

            DatabaseModel dbMod = new DatabaseModel();

            Random random = new Random();

            string taskText = TaskInput.Text;
            string dueDate = DueInput.Value.ToString("yyyy-MM-dd");

                int TaskId = (int)random.Next(10000000, 100000000);
                bool success = false;
                int tries = 0;

                while (success == false && tries < 10)
                {

                    success = !dbMod.CheckIfTaskIdExist(TaskId);
                    tries++;

                    TaskId = (int)random.Next(10000000, 100000000);
                }

                dbMod.CreateTaskInput(taskText, dueDate, selectedPriority, TaskId);
            MessageBox.Show("Created.");

            Landing.Instance?.Close();

            Landing newForm = new Landing();
            newForm.Show();

            Thread.Sleep(1000);
            this.Close();
        }
    }
}
