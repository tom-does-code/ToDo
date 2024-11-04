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
            TitleInput = new TextBox();
            InfoInput = new TextBox();
            Submit = new Button();
            Title1 = new Label();
            Title2 = new Label();
            SuspendLayout();
            // 
            // TitleInput
            // 
            TitleInput.Anchor = AnchorStyles.None;
            TitleInput.BackColor = SystemColors.WindowFrame;
            TitleInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TitleInput.ForeColor = Color.White;
            TitleInput.Location = new Point(345, 85);
            TitleInput.Multiline = true;
            TitleInput.Name = "TitleInput";
            TitleInput.Size = new Size(229, 54);
            TitleInput.TabIndex = 0;
            // 
            // InfoInput
            // 
            InfoInput.Anchor = AnchorStyles.None;
            InfoInput.BackColor = SystemColors.WindowFrame;
            InfoInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InfoInput.ForeColor = Color.White;
            InfoInput.Location = new Point(345, 215);
            InfoInput.Multiline = true;
            InfoInput.Name = "InfoInput";
            InfoInput.Size = new Size(229, 95);
            InfoInput.TabIndex = 1;
            // 
            // Submit
            // 
            Submit.Anchor = AnchorStyles.None;
            Submit.Location = new Point(388, 350);
            Submit.Name = "Submit";
            Submit.Size = new Size(143, 53);
            Submit.TabIndex = 2;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            // 
            // Title1
            // 
            Title1.Anchor = AnchorStyles.Top;
            Title1.AutoSize = true;
            Title1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title1.Location = new Point(383, 9);
            Title1.Name = "Title1";
            Title1.Size = new Size(153, 40);
            Title1.TabIndex = 3;
            Title1.Text = "Note Title";
            Title1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Title2
            // 
            Title2.Anchor = AnchorStyles.Top;
            Title2.AutoSize = true;
            Title2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title2.Location = new Point(335, 156);
            Title2.Name = "Title2";
            Title2.Size = new Size(250, 40);
            Title2.TabIndex = 4;
            Title2.Text = "Note Description";
            Title2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NewTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(904, 518);
            Controls.Add(Title2);
            Controls.Add(Title1);
            Controls.Add(Submit);
            Controls.Add(InfoInput);
            Controls.Add(TitleInput);
            Name = "NewTask";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleInput;
        private TextBox InfoInput;
        private Button Submit;
        private Label Title1;
        private Label Title2;
    }
}