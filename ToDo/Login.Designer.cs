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
            label1 = new Label();
            UsernameInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            LoginButton = new Button();
            SignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(374, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 40);
            label1.TabIndex = 0;
            label1.Text = "Nova";
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(343, 153);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(152, 23);
            UsernameInput.TabIndex = 1;
            // 
            // label2
            // 
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
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            label3.Location = new Point(368, 217);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(343, 281);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Top;
            LoginButton.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
            LoginButton.Location = new Point(305, 344);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(79, 40);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            SignUp.Anchor = AnchorStyles.Top;
            SignUp.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold);
            SignUp.Location = new Point(450, 344);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(79, 40);
            SignUp.TabIndex = 6;
            SignUp.Text = "SIGN UP";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Click += SignUp_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(821, 457);
            Controls.Add(SignUp);
            Controls.Add(LoginButton);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(UsernameInput);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UsernameInput;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button LoginButton;
        private Button SignUp;
    }
}