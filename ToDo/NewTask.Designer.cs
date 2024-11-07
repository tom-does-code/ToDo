namespace ToDo
{
    partial class NewTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TaskInput = new TextBox();
            Submit = new Button();
            Title1 = new Label();
            DueInput = new DateTimePicker();
            panel1 = new Panel();
            PriorityInput = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TaskInput
            // 
            TaskInput.Anchor = AnchorStyles.None;
            TaskInput.BackColor = Color.DarkGray;
            TaskInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TaskInput.ForeColor = Color.White;
            TaskInput.Location = new Point(81, 110);
            TaskInput.Multiline = true;
            TaskInput.Name = "TaskInput";
            TaskInput.Size = new Size(176, 38);
            TaskInput.TabIndex = 0;
            // 
            // Submit
            // 
            Submit.Anchor = AnchorStyles.None;
            Submit.BackColor = Color.MediumSeaGreen;
            Submit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit.ForeColor = Color.White;
            Submit.Location = new Point(105, 400);
            Submit.Name = "Submit";
            Submit.Size = new Size(118, 45);
            Submit.TabIndex = 2;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // Title1
            // 
            Title1.Anchor = AnchorStyles.Top;
            Title1.AutoSize = true;
            Title1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title1.Location = new Point(0, 9);
            Title1.Name = "Title1";
            Title1.Size = new Size(147, 40);
            Title1.TabIndex = 3;
            Title1.Text = "New Task";
            Title1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DueInput
            // 
            DueInput.Location = new Point(81, 221);
            DueInput.Name = "DueInput";
            DueInput.Size = new Size(176, 23);
            DueInput.TabIndex = 6;
            DueInput.Value = new DateTime(2024, 11, 7, 0, 0, 0, 0);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(PriorityInput);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(DueInput);
            panel1.Controls.Add(Submit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TaskInput);
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 455);
            panel1.TabIndex = 7;
            // 
            // PriorityInput
            // 
            PriorityInput.FormattingEnabled = true;
            PriorityInput.Items.AddRange(new object[] { "Low", "Medium", "High" });
            PriorityInput.Location = new Point(81, 331);
            PriorityInput.Name = "PriorityInput";
            PriorityInput.Size = new Size(176, 23);
            PriorityInput.TabIndex = 12;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(81, 291);
            label5.Name = "label5";
            label5.Size = new Size(95, 31);
            label5.TabIndex = 11;
            label5.Text = "Priority";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(81, 180);
            label4.Name = "label4";
            label4.Size = new Size(89, 31);
            label4.TabIndex = 10;
            label4.Text = "Due by";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(81, 69);
            label3.Name = "label3";
            label3.Size = new Size(62, 31);
            label3.TabIndex = 9;
            label3.Text = "Title";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(95, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 40);
            label2.TabIndex = 8;
            label2.Text = "New Task";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NewTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(904, 518);
            Controls.Add(panel1);
            Controls.Add(Title1);
            Name = "NewTask";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TaskInput;
        private Button Submit;
        private Label Title1;
        private DateTimePicker DueInput;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private ComboBox PriorityInput;
    }
}