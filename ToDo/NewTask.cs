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

            DatabaseModel dbMod = new DatabaseModel();

            string taskText = TaskInput.Text;
            string dueDate = DueInput.Value.ToString("yyyy-MM-dd");

            dbMod.CreateTaskInput(taskText, dueDate, selectedPriority?.ToLower());
            MessageBox.Show("Created.");

            TaskSubmitted?.Invoke(this, EventArgs.Empty);

            Landing.Instance?.Close();

            Landing newForm = new Landing();
            newForm.Show();

            Thread.Sleep(1000);
            this.Close();
        }
    }
}
