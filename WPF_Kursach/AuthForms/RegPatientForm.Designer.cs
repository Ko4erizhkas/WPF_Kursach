namespace WPF_Kursach
{
    partial class RegPatientForm
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
            Label P_PhoneNumber_1;
            Label P_AddressLabel_1;
            Label P_SurnameLabel_1;
            Label P_GenderLabel_1;
            Label RegPatientLabel_1;
            Label P_FullNameLabel;
            Label P_MedInstLabel_1;
            Label PCurrentDoctorLabel_1;
            Label P_DoctorFullNameLabel_1;
            Label P_DoctorSurnameLabel_1;
            Label P_AgeLabel_1;
            Label P_DateBirthLabel_1;
            RegPatientButtom_1 = new Button();
            P_PhoneNumberTextBox_1 = new TextBox();
            P_AddressTextBox_1 = new TextBox();
            P_SurnameTextBox_1 = new TextBox();
            P_GenderTextBox_1 = new TextBox();
            P_FullNameTextBox_1 = new TextBox();
            P_MedInstTextBox1 = new TextBox();
            P_DoctorFullNameTextBox_1 = new TextBox();
            P_DoctorSurnameTextBox_1 = new TextBox();
            P_AgeTextBox_1 = new TextBox();
            P_DateBirthTextBox_1 = new TextBox();
            P_PhoneNumber_1 = new Label();
            P_AddressLabel_1 = new Label();
            P_SurnameLabel_1 = new Label();
            P_GenderLabel_1 = new Label();
            RegPatientLabel_1 = new Label();
            P_FullNameLabel = new Label();
            P_MedInstLabel_1 = new Label();
            PCurrentDoctorLabel_1 = new Label();
            P_DoctorFullNameLabel_1 = new Label();
            P_DoctorSurnameLabel_1 = new Label();
            P_AgeLabel_1 = new Label();
            P_DateBirthLabel_1 = new Label();
            SuspendLayout();
            // 
            // P_PhoneNumber_1
            // 
            P_PhoneNumber_1.AutoSize = true;
            P_PhoneNumber_1.Font = new Font("Segoe UI", 9F);
            P_PhoneNumber_1.Location = new Point(11, 167);
            P_PhoneNumber_1.Name = "P_PhoneNumber_1";
            P_PhoneNumber_1.Size = new Size(101, 15);
            P_PhoneNumber_1.TabIndex = 22;
            P_PhoneNumber_1.Text = "Номер телефона";
            // 
            // P_AddressLabel_1
            // 
            P_AddressLabel_1.AutoSize = true;
            P_AddressLabel_1.Font = new Font("Segoe UI", 9F);
            P_AddressLabel_1.Location = new Point(165, 107);
            P_AddressLabel_1.Name = "P_AddressLabel_1";
            P_AddressLabel_1.Size = new Size(112, 15);
            P_AddressLabel_1.TabIndex = 20;
            P_AddressLabel_1.Text = "Адрес проживания";
            // 
            // P_SurnameLabel_1
            // 
            P_SurnameLabel_1.AutoSize = true;
            P_SurnameLabel_1.Font = new Font("Segoe UI", 9F);
            P_SurnameLabel_1.Location = new Point(12, 107);
            P_SurnameLabel_1.Name = "P_SurnameLabel_1";
            P_SurnameLabel_1.Size = new Size(58, 15);
            P_SurnameLabel_1.TabIndex = 18;
            P_SurnameLabel_1.Text = "Фамилия";
            // 
            // P_GenderLabel_1
            // 
            P_GenderLabel_1.AutoSize = true;
            P_GenderLabel_1.Font = new Font("Segoe UI", 9F);
            P_GenderLabel_1.Location = new Point(166, 53);
            P_GenderLabel_1.Name = "P_GenderLabel_1";
            P_GenderLabel_1.Size = new Size(30, 15);
            P_GenderLabel_1.TabIndex = 16;
            P_GenderLabel_1.Text = "Пол";
            // 
            // RegPatientLabel_1
            // 
            RegPatientLabel_1.AutoSize = true;
            RegPatientLabel_1.Font = new Font("Segoe UI", 9F);
            RegPatientLabel_1.Location = new Point(79, 27);
            RegPatientLabel_1.Name = "RegPatientLabel_1";
            RegPatientLabel_1.Size = new Size(130, 15);
            RegPatientLabel_1.TabIndex = 14;
            RegPatientLabel_1.Text = "Регистрация пациента";
            // 
            // P_FullNameLabel
            // 
            P_FullNameLabel.AutoSize = true;
            P_FullNameLabel.Font = new Font("Segoe UI", 9F);
            P_FullNameLabel.Location = new Point(12, 53);
            P_FullNameLabel.Name = "P_FullNameLabel";
            P_FullNameLabel.Size = new Size(31, 15);
            P_FullNameLabel.TabIndex = 13;
            P_FullNameLabel.Text = "Имя";
            // 
            // P_MedInstLabel_1
            // 
            P_MedInstLabel_1.AutoSize = true;
            P_MedInstLabel_1.Font = new Font("Segoe UI", 9F);
            P_MedInstLabel_1.Location = new Point(10, 226);
            P_MedInstLabel_1.Name = "P_MedInstLabel_1";
            P_MedInstLabel_1.Size = new Size(133, 15);
            P_MedInstLabel_1.TabIndex = 25;
            P_MedInstLabel_1.Text = "Название организации";
            // 
            // PCurrentDoctorLabel_1
            // 
            PCurrentDoctorLabel_1.AutoSize = true;
            PCurrentDoctorLabel_1.Font = new Font("Segoe UI", 9F);
            PCurrentDoctorLabel_1.Location = new Point(333, 27);
            PCurrentDoctorLabel_1.Name = "PCurrentDoctorLabel_1";
            PCurrentDoctorLabel_1.Size = new Size(88, 15);
            PCurrentDoctorLabel_1.TabIndex = 26;
            PCurrentDoctorLabel_1.Text = "Лечащий врач";
            // 
            // P_DoctorFullNameLabel_1
            // 
            P_DoctorFullNameLabel_1.AutoSize = true;
            P_DoctorFullNameLabel_1.Font = new Font("Segoe UI", 9F);
            P_DoctorFullNameLabel_1.Location = new Point(328, 53);
            P_DoctorFullNameLabel_1.Name = "P_DoctorFullNameLabel_1";
            P_DoctorFullNameLabel_1.Size = new Size(66, 15);
            P_DoctorFullNameLabel_1.TabIndex = 28;
            P_DoctorFullNameLabel_1.Text = "Имя врача";
            // 
            // P_DoctorSurnameLabel_1
            // 
            P_DoctorSurnameLabel_1.AutoSize = true;
            P_DoctorSurnameLabel_1.Font = new Font("Segoe UI", 9F);
            P_DoctorSurnameLabel_1.Location = new Point(328, 107);
            P_DoctorSurnameLabel_1.Name = "P_DoctorSurnameLabel_1";
            P_DoctorSurnameLabel_1.Size = new Size(93, 15);
            P_DoctorSurnameLabel_1.TabIndex = 30;
            P_DoctorSurnameLabel_1.Text = "Фамилия врача";
            // 
            // P_AgeLabel_1
            // 
            P_AgeLabel_1.AutoSize = true;
            P_AgeLabel_1.Font = new Font("Segoe UI", 9F);
            P_AgeLabel_1.Location = new Point(166, 167);
            P_AgeLabel_1.Name = "P_AgeLabel_1";
            P_AgeLabel_1.Size = new Size(50, 15);
            P_AgeLabel_1.TabIndex = 33;
            P_AgeLabel_1.Text = "Возраст";
            // 
            // P_DateBirthLabel_1
            // 
            P_DateBirthLabel_1.AutoSize = true;
            P_DateBirthLabel_1.Font = new Font("Segoe UI", 9F);
            P_DateBirthLabel_1.Location = new Point(166, 226);
            P_DateBirthLabel_1.Name = "P_DateBirthLabel_1";
            P_DateBirthLabel_1.Size = new Size(151, 15);
            P_DateBirthLabel_1.TabIndex = 35;
            P_DateBirthLabel_1.Text = "Дата рождения (дд.ММ.гг)";
            // 
            // RegPatientButtom_1
            // 
            RegPatientButtom_1.Location = new Point(166, 304);
            RegPatientButtom_1.Name = "RegPatientButtom_1";
            RegPatientButtom_1.Size = new Size(140, 50);
            RegPatientButtom_1.TabIndex = 23;
            RegPatientButtom_1.Text = "Зарегестировать пациента";
            RegPatientButtom_1.UseVisualStyleBackColor = true;
            RegPatientButtom_1.Click += RegPatientButtom_1_Click;
            // 
            // P_PhoneNumberTextBox_1
            // 
            P_PhoneNumberTextBox_1.Location = new Point(12, 200);
            P_PhoneNumberTextBox_1.Name = "P_PhoneNumberTextBox_1";
            P_PhoneNumberTextBox_1.Size = new Size(140, 23);
            P_PhoneNumberTextBox_1.TabIndex = 21;
            // 
            // P_AddressTextBox_1
            // 
            P_AddressTextBox_1.Location = new Point(166, 138);
            P_AddressTextBox_1.Name = "P_AddressTextBox_1";
            P_AddressTextBox_1.Size = new Size(140, 23);
            P_AddressTextBox_1.TabIndex = 31;
            // 
            // P_SurnameTextBox_1
            // 
            P_SurnameTextBox_1.Location = new Point(12, 141);
            P_SurnameTextBox_1.Name = "P_SurnameTextBox_1";
            P_SurnameTextBox_1.Size = new Size(140, 23);
            P_SurnameTextBox_1.TabIndex = 17;
            // 
            // P_GenderTextBox_1
            // 
            P_GenderTextBox_1.Location = new Point(166, 81);
            P_GenderTextBox_1.Name = "P_GenderTextBox_1";
            P_GenderTextBox_1.Size = new Size(140, 23);
            P_GenderTextBox_1.TabIndex = 15;
            // 
            // P_FullNameTextBox_1
            // 
            P_FullNameTextBox_1.Location = new Point(12, 81);
            P_FullNameTextBox_1.Name = "P_FullNameTextBox_1";
            P_FullNameTextBox_1.Size = new Size(140, 23);
            P_FullNameTextBox_1.TabIndex = 12;
            // 
            // P_MedInstTextBox1
            // 
            P_MedInstTextBox1.Location = new Point(10, 253);
            P_MedInstTextBox1.Name = "P_MedInstTextBox1";
            P_MedInstTextBox1.Size = new Size(140, 23);
            P_MedInstTextBox1.TabIndex = 24;
            // 
            // P_DoctorFullNameTextBox_1
            // 
            P_DoctorFullNameTextBox_1.Location = new Point(328, 81);
            P_DoctorFullNameTextBox_1.Name = "P_DoctorFullNameTextBox_1";
            P_DoctorFullNameTextBox_1.Size = new Size(140, 23);
            P_DoctorFullNameTextBox_1.TabIndex = 27;
            // 
            // P_DoctorSurnameTextBox_1
            // 
            P_DoctorSurnameTextBox_1.Location = new Point(328, 138);
            P_DoctorSurnameTextBox_1.Name = "P_DoctorSurnameTextBox_1";
            P_DoctorSurnameTextBox_1.Size = new Size(140, 23);
            P_DoctorSurnameTextBox_1.TabIndex = 29;
            // 
            // P_AgeTextBox_1
            // 
            P_AgeTextBox_1.Location = new Point(165, 200);
            P_AgeTextBox_1.Name = "P_AgeTextBox_1";
            P_AgeTextBox_1.Size = new Size(140, 23);
            P_AgeTextBox_1.TabIndex = 32;
            // 
            // P_DateBirthTextBox_1
            // 
            P_DateBirthTextBox_1.Location = new Point(166, 253);
            P_DateBirthTextBox_1.Name = "P_DateBirthTextBox_1";
            P_DateBirthTextBox_1.Size = new Size(140, 23);
            P_DateBirthTextBox_1.TabIndex = 34;
            // 
            // RegPatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 386);
            Controls.Add(P_DateBirthLabel_1);
            Controls.Add(P_DateBirthTextBox_1);
            Controls.Add(P_AgeLabel_1);
            Controls.Add(P_AgeTextBox_1);
            Controls.Add(P_DoctorSurnameLabel_1);
            Controls.Add(P_DoctorSurnameTextBox_1);
            Controls.Add(P_DoctorFullNameLabel_1);
            Controls.Add(P_DoctorFullNameTextBox_1);
            Controls.Add(PCurrentDoctorLabel_1);
            Controls.Add(P_MedInstLabel_1);
            Controls.Add(P_MedInstTextBox1);
            Controls.Add(RegPatientButtom_1);
            Controls.Add(P_PhoneNumber_1);
            Controls.Add(P_PhoneNumberTextBox_1);
            Controls.Add(P_AddressLabel_1);
            Controls.Add(P_AddressTextBox_1);
            Controls.Add(P_SurnameLabel_1);
            Controls.Add(P_SurnameTextBox_1);
            Controls.Add(P_GenderLabel_1);
            Controls.Add(P_GenderTextBox_1);
            Controls.Add(RegPatientLabel_1);
            Controls.Add(P_FullNameLabel);
            Controls.Add(P_FullNameTextBox_1);
            Name = "RegPatientForm";
            Text = "AuthPatient";
            Load += AuthPatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegPatientButtom_1;
        private TextBox P_PhoneNumberTextBox_1;
        private TextBox P_AddressTextBox_1;
        private TextBox P_SurnameTextBox_1;
        private TextBox P_GenderTextBox_1;
        private TextBox P_FullNameTextBox_1;
        private TextBox P_MedInstTextBox1;
        private TextBox P_DoctorFullNameTextBox_1;
        private TextBox P_DoctorSurnameTextBox_1;
        private TextBox P_AgeTextBox_1;
        private TextBox P_DateBirthTextBox_1;
    }
}