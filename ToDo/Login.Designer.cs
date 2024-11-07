namespace ToDo
{
    partial class Login
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
            UsernameInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            PasswordInput = new TextBox();
            LoginButton = new Button();
            SignUp = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // UsernameInput
            // 
            UsernameInput.Anchor = AnchorStyles.Top;
            UsernameInput.BackColor = Color.PowderBlue;
            UsernameInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameInput.ForeColor = Color.White;
            UsernameInput.Location = new Point(343, 153);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(152, 27);
            UsernameInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            label2.Location = new Point(366, 106);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            label3.Location = new Point(368, 217);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // PasswordInput
            // 
            PasswordInput.Anchor = AnchorStyles.Top;
            PasswordInput.BackColor = Color.PowderBlue;
            PasswordInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordInput.ForeColor = Color.White;
            PasswordInput.Location = new Point(343, 281);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(152, 27);
            PasswordInput.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Top;
            LoginButton.BackColor = Color.MediumSeaGreen;
            LoginButton.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(305, 344);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(79, 40);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // SignUp
            // 
            SignUp.Anchor = AnchorStyles.Top;
            SignUp.BackColor = Color.MediumSlateBlue;
            SignUp.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold);
            SignUp.ForeColor = Color.White;
            SignUp.Location = new Point(450, 344);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(79, 40);
            SignUp.TabIndex = 6;
            SignUp.Text = "SIGN UP";
            SignUp.UseVisualStyleBackColor = false;
            SignUp.Click += SignUp_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(277, 51);
            label4.Name = "label4";
            label4.Size = new Size(284, 30);
            label4.TabIndex = 8;
            label4.Text = "Manage your tasks efficiently";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(362, 1);
            label5.Name = "label5";
            label5.Size = new Size(113, 50);
            label5.TabIndex = 7;
            label5.Text = "Nova";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(821, 457);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(SignUp);
            Controls.Add(LoginButton);
            Controls.Add(label3);
            Controls.Add(PasswordInput);
            Controls.Add(label2);
            Controls.Add(UsernameInput);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox UsernameInput;
        private Label label2;
        private Label label3;
        private TextBox PasswordInput;
        private Button LoginButton;
        private Button SignUp;
        private Label label4;
        private Label label5;
    }
}