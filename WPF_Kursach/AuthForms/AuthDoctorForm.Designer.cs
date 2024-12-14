namespace WPF_Kursach
{
    partial class AuthDoctorForm
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
            Label DFullNameLabel;
            Label DSpecLabel_1;
            Label DSurnameLabel_1;
            Label DExperienceLabel_1;
            Label DPhoneNumber_1;
            Label AuthDoctorLabel_1;
            DFullNameTextBox_1 = new TextBox();
            DSpecTextBox_1 = new TextBox();
            DSurnameTextBox_1 = new TextBox();
            DExperienceTextBox_1 = new TextBox();
            DPhoneNumberTextBox_1 = new TextBox();
            AuthDoctorButtom_1 = new Button();
            DFullNameLabel = new Label();
            DSpecLabel_1 = new Label();
            DSurnameLabel_1 = new Label();
            DExperienceLabel_1 = new Label();
            DPhoneNumber_1 = new Label();
            AuthDoctorLabel_1 = new Label();
            SuspendLayout();
            // 
            // DFullNameLabel
            // 
            DFullNameLabel.AutoSize = true;
            DFullNameLabel.Font = new Font("Segoe UI", 9F);
            DFullNameLabel.Location = new Point(12, 53);
            DFullNameLabel.Name = "DFullNameLabel";
            DFullNameLabel.Size = new Size(31, 15);
            DFullNameLabel.TabIndex = 1;
            DFullNameLabel.Text = "Имя";
            // 
            // DSpecLabel_1
            // 
            DSpecLabel_1.AutoSize = true;
            DSpecLabel_1.Font = new Font("Segoe UI", 9F);
            DSpecLabel_1.Location = new Point(11, 173);
            DSpecLabel_1.Name = "DSpecLabel_1";
            DSpecLabel_1.Size = new Size(92, 15);
            DSpecLabel_1.TabIndex = 4;
            DSpecLabel_1.Text = "Специальность";
            // 
            // DSurnameLabel_1
            // 
            DSurnameLabel_1.AutoSize = true;
            DSurnameLabel_1.Font = new Font("Segoe UI", 9F);
            DSurnameLabel_1.Location = new Point(12, 113);
            DSurnameLabel_1.Name = "DSurnameLabel_1";
            DSurnameLabel_1.Size = new Size(58, 15);
            DSurnameLabel_1.TabIndex = 6;
            DSurnameLabel_1.Text = "Фамилия";
            // 
            // DExperienceLabel_1
            // 
            DExperienceLabel_1.AutoSize = true;
            DExperienceLabel_1.Font = new Font("Segoe UI", 9F);
            DExperienceLabel_1.Location = new Point(11, 220);
            DExperienceLabel_1.Name = "DExperienceLabel_1";
            DExperienceLabel_1.Size = new Size(81, 15);
            DExperienceLabel_1.TabIndex = 8;
            DExperienceLabel_1.Text = "Опыт работы";
            // 
            // DPhoneNumber_1
            // 
            DPhoneNumber_1.AutoSize = true;
            DPhoneNumber_1.Font = new Font("Segoe UI", 9F);
            DPhoneNumber_1.Location = new Point(12, 278);
            DPhoneNumber_1.Name = "DPhoneNumber_1";
            DPhoneNumber_1.Size = new Size(101, 15);
            DPhoneNumber_1.TabIndex = 10;
            DPhoneNumber_1.Text = "Номер телефона";
            // 
            // AuthDoctorLabel_1
            // 
            AuthDoctorLabel_1.AutoSize = true;
            AuthDoctorLabel_1.Font = new Font("Segoe UI", 9F);
            AuthDoctorLabel_1.Location = new Point(26, 9);
            AuthDoctorLabel_1.Name = "AuthDoctorLabel_1";
            AuthDoctorLabel_1.Size = new Size(125, 15);
            AuthDoctorLabel_1.TabIndex = 2;
            AuthDoctorLabel_1.Text = "Авторизация доктора";
            // 
            // DFullNameTextBox_1
            // 
            DFullNameTextBox_1.Location = new Point(12, 81);
            DFullNameTextBox_1.Name = "DFullNameTextBox_1";
            DFullNameTextBox_1.Size = new Size(140, 23);
            DFullNameTextBox_1.TabIndex = 0;
            // 
            // DSpecTextBox_1
            // 
            DSpecTextBox_1.Location = new Point(12, 191);
            DSpecTextBox_1.Name = "DSpecTextBox_1";
            DSpecTextBox_1.Size = new Size(140, 23);
            DSpecTextBox_1.TabIndex = 3;
            // 
            // DSurnameTextBox_1
            // 
            DSurnameTextBox_1.Location = new Point(12, 141);
            DSurnameTextBox_1.Name = "DSurnameTextBox_1";
            DSurnameTextBox_1.Size = new Size(140, 23);
            DSurnameTextBox_1.TabIndex = 5;
            // 
            // DExperienceTextBox_1
            // 
            DExperienceTextBox_1.Location = new Point(11, 248);
            DExperienceTextBox_1.Name = "DExperienceTextBox_1";
            DExperienceTextBox_1.Size = new Size(140, 23);
            DExperienceTextBox_1.TabIndex = 7;
            // 
            // DPhoneNumberTextBox_1
            // 
            DPhoneNumberTextBox_1.Location = new Point(12, 306);
            DPhoneNumberTextBox_1.Name = "DPhoneNumberTextBox_1";
            DPhoneNumberTextBox_1.Size = new Size(140, 23);
            DPhoneNumberTextBox_1.TabIndex = 9;
            // 
            // AuthDoctorButtom_1
            // 
            AuthDoctorButtom_1.Location = new Point(12, 345);
            AuthDoctorButtom_1.Name = "AuthDoctorButtom_1";
            AuthDoctorButtom_1.Size = new Size(140, 50);
            AuthDoctorButtom_1.TabIndex = 11;
            AuthDoctorButtom_1.Text = "Зарегестировать доктора";
            AuthDoctorButtom_1.UseVisualStyleBackColor = true;
            AuthDoctorButtom_1.Click += AuthDoctorButtom_1_Click;
            // 
            // AuthDoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(163, 397);
            Controls.Add(AuthDoctorButtom_1);
            Controls.Add(DPhoneNumber_1);
            Controls.Add(DPhoneNumberTextBox_1);
            Controls.Add(DExperienceLabel_1);
            Controls.Add(DExperienceTextBox_1);
            Controls.Add(DSurnameLabel_1);
            Controls.Add(DSurnameTextBox_1);
            Controls.Add(DSpecLabel_1);
            Controls.Add(DSpecTextBox_1);
            Controls.Add(AuthDoctorLabel_1);
            Controls.Add(DFullNameLabel);
            Controls.Add(DFullNameTextBox_1);
            Name = "AuthDoctorForm";
            Text = "AuthDoctor";
            Load += AuthDoctorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DFullNameTextBox_1;
        private Label DFullNameLabel;
        private Label AuthDoctorLabel_1;
        private Label DSpecLabel_1;
        private TextBox DSpecTextBox_1;
        private Label DSurnameLabel_1;
        private TextBox DSurnameTextBox_1;
        private Label DExperienceLabel_1;
        private TextBox DExperienceTextBox_1;
        private Label DPhoneNumber_1;
        private TextBox DPhoneNumberTextBox_1;
        private Button AuthDoctorButtom_1;
    }
}