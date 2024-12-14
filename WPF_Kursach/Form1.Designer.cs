namespace WPF_Kursach
{
    partial class Form1
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
            AuthTextBox_1 = new TextBox();
            AuthTextBox_2 = new TextBox();
            AuthButton_1 = new Button();
            AuthDoctorLabel_1 = new Label();
            AuthName_1 = new Label();
            AuthSurName_1 = new Label();
            AuthSpec_2 = new Label();
            AuthExp_1 = new Label();
            AuthTextBox_4 = new TextBox();
            AuthTextBox_3 = new TextBox();
            SuspendLayout();
            // 
            // AuthTextBox_1
            // 
            AuthTextBox_1.Location = new Point(182, 83);
            AuthTextBox_1.Name = "AuthTextBox_1";
            AuthTextBox_1.Size = new Size(221, 23);
            AuthTextBox_1.TabIndex = 0;
            AuthTextBox_1.TextChanged += AuthTextBox_1_TextChanged;
            // 
            // AuthTextBox_2
            // 
            AuthTextBox_2.Location = new Point(182, 127);
            AuthTextBox_2.Name = "AuthTextBox_2";
            AuthTextBox_2.Size = new Size(221, 23);
            AuthTextBox_2.TabIndex = 1;
            AuthTextBox_2.TextChanged += AuthTextBox_2_TextChanged;
            // 
            // AuthButton_1
            // 
            AuthButton_1.BackColor = SystemColors.ButtonHighlight;
            AuthButton_1.Cursor = Cursors.IBeam;
            AuthButton_1.Location = new Point(202, 259);
            AuthButton_1.Name = "AuthButton_1";
            AuthButton_1.Size = new Size(150, 41);
            AuthButton_1.TabIndex = 2;
            AuthButton_1.Text = "Авторизироваться";
            AuthButton_1.UseVisualStyleBackColor = false;
            AuthButton_1.Click += AuthButton_1_Click;
            // 
            // AuthDoctorLabel_1
            // 
            AuthDoctorLabel_1.AutoSize = true;
            AuthDoctorLabel_1.Location = new Point(239, 9);
            AuthDoctorLabel_1.Name = "AuthDoctorLabel_1";
            AuthDoctorLabel_1.Size = new Size(113, 15);
            AuthDoctorLabel_1.TabIndex = 3;
            AuthDoctorLabel_1.Text = "Авторизация врача";
            AuthDoctorLabel_1.Click += AuthLabel_1_Click;
            // 
            // AuthName_1
            // 
            AuthName_1.AutoSize = true;
            AuthName_1.Location = new Point(266, 109);
            AuthName_1.Name = "AuthName_1";
            AuthName_1.Size = new Size(31, 15);
            AuthName_1.TabIndex = 4;
            AuthName_1.Text = "Имя";
            AuthName_1.Click += label1_Click;
            // 
            // AuthSurName_1
            // 
            AuthSurName_1.AutoSize = true;
            AuthSurName_1.Location = new Point(253, 65);
            AuthSurName_1.Name = "AuthSurName_1";
            AuthSurName_1.Size = new Size(58, 15);
            AuthSurName_1.TabIndex = 5;
            AuthSurName_1.Text = "Фамилия";
            // 
            // AuthSpec_2
            // 
            AuthSpec_2.AutoSize = true;
            AuthSpec_2.Location = new Point(239, 153);
            AuthSpec_2.Name = "AuthSpec_2";
            AuthSpec_2.Size = new Size(92, 15);
            AuthSpec_2.TabIndex = 7;
            AuthSpec_2.Text = "Специальность";
            // 
            // AuthExp_1
            // 
            AuthExp_1.AutoSize = true;
            AuthExp_1.Location = new Point(239, 198);
            AuthExp_1.Name = "AuthExp_1";
            AuthExp_1.Size = new Size(90, 15);
            AuthExp_1.TabIndex = 9;
            AuthExp_1.Text = "Опыт работы   ";
            // 
            // AuthTextBox_4
            // 
            AuthTextBox_4.Location = new Point(182, 216);
            AuthTextBox_4.Name = "AuthTextBox_4";
            AuthTextBox_4.Size = new Size(221, 23);
            AuthTextBox_4.TabIndex = 8;
            AuthTextBox_4.TextChanged += AuthTextBox_4_TextChanged;
            // 
            // AuthTextBox_3
            // 
            AuthTextBox_3.Location = new Point(182, 171);
            AuthTextBox_3.Name = "AuthTextBox_3";
            AuthTextBox_3.Size = new Size(221, 23);
            AuthTextBox_3.TabIndex = 10;
            AuthTextBox_3.TextChanged += AuthTextBox_3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 381);
            Controls.Add(AuthTextBox_3);
            Controls.Add(AuthExp_1);
            Controls.Add(AuthTextBox_4);
            Controls.Add(AuthSpec_2);
            Controls.Add(AuthSurName_1);
            Controls.Add(AuthName_1);
            Controls.Add(AuthDoctorLabel_1);
            Controls.Add(AuthButton_1);
            Controls.Add(AuthTextBox_2);
            Controls.Add(AuthTextBox_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AuthTextBox_1;
        private TextBox AuthTextBox_2;
        private Button AuthButton_1;
        private Label AuthDoctorLabel_1;
        private Label AuthName_1;
        private Label AuthSurName_1;
        private Label AuthSpec_2;
        private Label AuthExp_1;
        private TextBox AuthTextBox_4;
        private TextBox AuthTextBox_3;
    }
}
