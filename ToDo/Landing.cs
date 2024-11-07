using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using Encryption;
using Microsoft.IdentityModel.Tokens;
using UserModel;

namespace ToDo
{
    public partial class Landing : Form
    {
        private string connectionString = "Server=DESKTOP-G4EE8OT;Database=Nova;Trusted_Connection=True;TrustServerCertificate=True;";

        public static Landing? Instance { get; private set; }

        public Landing()
        {
            InitializeComponent();
            Instance = this;
            InitRefresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            NewTask secondForm = new NewTask();

            secondForm.Show();
        }

        private void InitializeTaskList()
        {
            if (User.CurrentUser == null || string.IsNullOrEmpty(User.CurrentUser.Username))
            {
                MessageBox.Show("User not logged in, please restart and try again.");
                return;
            }

            DatabaseModel usMod = new DatabaseModel();

            FlowLayoutPanel taskPanel = new FlowLayoutPanel
            {
                Location = new Point(18, 275),
                Size = new Size(300, 300),
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };

            this.Controls.Add(taskPanel);

            string query = "SELECT ListTitle, DueDate, Priority FROM dbo.ListData WHERE UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", usMod.ReturnAccountNumber(User.CurrentUser.Username));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        taskPanel.Controls.Clear();

                        while (reader.Read())
                        {
                            Color backColor = Color.FromArgb(255, 255, 255);

                            if (reader["Priority"].ToString() == "high")
                            {
                                backColor = Color.FromArgb(178, 34, 34);
                            }
                            else if (reader["Priority"].ToString() == "medium")
                            {
                                backColor = Color.FromArgb(255, 165, 0);
                            }
                            else if (reader["Priority"].ToString() == "low")
                            {
                                backColor = Color.FromArgb(34, 139, 34);
                            }

                            Label taskLabel = new Label
                            {
                                Text = reader["ListTitle"].ToString(),
                                AutoSize = true,
                                Font = new System.Drawing.Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0),
                                ForeColor = backColor,
                                Location = new Point(0, 0),
                                Name = "taskLabel",
                                Size = new Size(300, 30),
                                TabIndex = 0
                            };

                            Label dueLabel = new Label
                            {
                                Text = "Complete By: " + reader["DueDate"],
                                AutoSize = true,
                                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                                ForeColor = Color.Black,
                                Location = new Point(0, 0),
                                Name = "dueLabel",
                                Size = new Size(300, 30),
                                TabIndex = 0
                            };


                            Button completeButton = new Button
                            {
                                Text = "Complete",
                                AutoSize = true,
                                Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                                ForeColor = Color.White,
                                BackColor = Color.MediumSeaGreen,
                                Location = new Point(0, 0),
                                Name = "completeButton",
                                Size = new Size(150, 30),
                                TabIndex = 0
                            };

                            taskPanel.Controls.Add(taskLabel);
                            taskPanel.Controls.Add(dueLabel);
                            taskPanel.Controls.Add(completeButton);
                        }
                    }
                }
            }
        }

        public void InitRefresh()
        {
            InitializeTaskList();
        }

        private void OpenNewTaskForm()
        {
            NewTask newTaskForm = new NewTask();

            newTaskForm.TaskSubmitted += NewTaskForm_TaskSubmitted;

            newTaskForm.Show();
        }

        private void NewTaskForm_TaskSubmitted(object? sender, EventArgs e)
        {
            InitRefresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NewTask newtaskForm = new NewTask();

            newtaskForm.Show();
        }
    }
}
