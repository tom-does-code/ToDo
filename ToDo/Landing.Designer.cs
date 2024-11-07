namespace ToDo
{
    partial class Landing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(-1, -3);
            label1.Name = "label1";
            label1.Size = new Size(113, 50);
            label1.TabIndex = 0;
            label1.Text = "Nova";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(-1, 47);
            label2.Name = "label2";
            label2.Size = new Size(284, 30);
            label2.TabIndex = 1;
            label2.Text = "Manage your tasks efficiently";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(18, 154);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 42);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkGray;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(24, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(961, 33);
            textBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 121);
            label3.Name = "label3";
            label3.Size = new Size(135, 30);
            label3.TabIndex = 3;
            label3.Text = "Search Tasks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(18, 222);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 4;
            label4.Text = "My Tasks";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(885, 44);
            button1.Name = "button1";
            button1.Size = new Size(119, 44);
            button1.TabIndex = 5;
            button1.Text = "NEW TASK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Landing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1039, 558);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Landing";
            Text = "Nova";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
