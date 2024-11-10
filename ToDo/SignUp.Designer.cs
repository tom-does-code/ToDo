namespace ToDo
{
    partial class SignUp
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
            label3 = new Label();
            PasswordInput = new TextBox();
            label2 = new Label();
            UsernameInput = new TextBox();
            label1 = new Label();
            label4 = new Label();
            DateOfBirthInput = new DateTimePicker();
            SignUpConf = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            label3.Location = new Point(358, 189);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(332, 247);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(152, 23);
            PasswordInput.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            label2.Location = new Point(355, 90);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(332, 136);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(152, 23);
            UsernameInput.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(363, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 40);
            label1.TabIndex = 5;
            label1.Text = "Nova";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            label4.Location = new Point(340, 290);
            label4.Name = "label4";
            label4.Size = new Size(137, 28);
            label4.TabIndex = 11;
            label4.Text = "Date of Birth";
            // 
            // DateOfBirthInput
            // 
            DateOfBirthInput.Location = new Point(308, 352);
            DateOfBirthInput.Name = "DateOfBirthInput";
            DateOfBirthInput.Size = new Size(200, 23);
            DateOfBirthInput.TabIndex = 12;
            DateOfBirthInput.Value = new DateTime(2024, 11, 4, 0, 0, 0, 0);
            // 
            // SignUpConf
            // 
            SignUpConf.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpConf.Location = new Point(355, 396);
            SignUpConf.Name = "SignUpConf";
            SignUpConf.Size = new Size(104, 42);
            SignUpConf.TabIndex = 13;
            SignUpConf.Text = "SIGN UP";
            SignUpConf.UseVisualStyleBackColor = true;
            SignUpConf.Click += SignUpConf_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.75F, FontStyle.Bold);
            label5.Location = new Point(371, 58);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 14;
            label5.Text = "SIGN UP";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(SignUpConf);
            Controls.Add(DateOfBirthInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PasswordInput);
            Controls.Add(label2);
            Controls.Add(UsernameInput);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox PasswordInput;
        private Label label2;
        private TextBox UsernameInput;
        private Label label1;
        private Label label4;
        private DateTimePicker DateOfBirthInput;
        private Button SignUpConf;
        private Label label5;
    }
}