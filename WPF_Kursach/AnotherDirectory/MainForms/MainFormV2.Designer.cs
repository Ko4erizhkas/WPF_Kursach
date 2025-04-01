namespace WPF_Kursach.AnotherDirectory.MainForms
{
    partial class MainFormV2
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
            DoctorButton = new Button();
            PatientButton = new Button();
            HospitalButton = new Button();
            PolyclinicButton = new Button();
            LoadPatientDataButton = new Button();
            PatientDataGridView = new DataGridView();
            DoctorDataGridView = new DataGridView();
            PolyclinicDataGridView = new DataGridView();
            HospitalDataGridView = new DataGridView();
            DataGridLabel1 = new Label();
            DataGridLabel2 = new Label();
            DataGridLabel3 = new Label();
            LoadDoctorDataButton = new Button();
            LoadHospitalDataButton = new Button();
            LoadPolyclinicDataButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PatientDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoctorDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PolyclinicDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HospitalDataGridView).BeginInit();
            SuspendLayout();
            // 
            // DoctorButton
            // 
            DoctorButton.Location = new Point(688, 287);
            DoctorButton.Name = "DoctorButton";
            DoctorButton.Size = new Size(220, 23);
            DoctorButton.TabIndex = 0;
            DoctorButton.Text = "Добавить доктора";
            DoctorButton.UseVisualStyleBackColor = true;
            DoctorButton.Click += DoctorButton_Click;
            // 
            // PatientButton
            // 
            PatientButton.Location = new Point(118, 287);
            PatientButton.Name = "PatientButton";
            PatientButton.Size = new Size(220, 23);
            PatientButton.TabIndex = 1;
            PatientButton.Text = "Добавить пациента";
            PatientButton.UseVisualStyleBackColor = true;
            PatientButton.Click += PatientButton_Click;
            // 
            // HospitalButton
            // 
            HospitalButton.Location = new Point(118, 186);
            HospitalButton.Name = "HospitalButton";
            HospitalButton.Size = new Size(240, 23);
            HospitalButton.TabIndex = 2;
            HospitalButton.Text = "Добавить госпиталь";
            HospitalButton.UseVisualStyleBackColor = true;
            HospitalButton.Click += HospitalButton_Click;
            // 
            // PolyclinicButton
            // 
            PolyclinicButton.Location = new Point(668, 186);
            PolyclinicButton.Name = "PolyclinicButton";
            PolyclinicButton.Size = new Size(240, 23);
            PolyclinicButton.TabIndex = 3;
            PolyclinicButton.Text = "Добавить поликлиннику";
            PolyclinicButton.UseVisualStyleBackColor = true;
            PolyclinicButton.Click += PolyclinicButton_Click;
            // 
            // LoadPatientDataButton
            // 
            LoadPatientDataButton.Location = new Point(118, 316);
            LoadPatientDataButton.Name = "LoadPatientDataButton";
            LoadPatientDataButton.Size = new Size(220, 23);
            LoadPatientDataButton.TabIndex = 4;
            LoadPatientDataButton.Text = "Загрузить информацию о пациентах";
            LoadPatientDataButton.UseVisualStyleBackColor = true;
            LoadPatientDataButton.Click += LoadPatientDataButton_Click;
            // 
            // PatientDataGridView
            // 
            PatientDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientDataGridView.Location = new Point(12, 347);
            PatientDataGridView.Name = "PatientDataGridView";
            PatientDataGridView.Size = new Size(497, 158);
            PatientDataGridView.TabIndex = 6;
            // 
            // DoctorDataGridView
            // 
            DoctorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DoctorDataGridView.Location = new Point(549, 347);
            DoctorDataGridView.Name = "DoctorDataGridView";
            DoctorDataGridView.Size = new Size(497, 158);
            DoctorDataGridView.TabIndex = 7;
            // 
            // PolyclinicDataGridView
            // 
            PolyclinicDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PolyclinicDataGridView.Location = new Point(582, 30);
            PolyclinicDataGridView.Name = "PolyclinicDataGridView";
            PolyclinicDataGridView.Size = new Size(464, 150);
            PolyclinicDataGridView.TabIndex = 8;
            // 
            // HospitalDataGridView
            // 
            HospitalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HospitalDataGridView.Location = new Point(12, 30);
            HospitalDataGridView.Name = "HospitalDataGridView";
            HospitalDataGridView.Size = new Size(518, 150);
            HospitalDataGridView.TabIndex = 9;
            // 
            // DataGridLabel1
            // 
            DataGridLabel1.AutoSize = true;
            DataGridLabel1.Location = new Point(485, 9);
            DataGridLabel1.Name = "DataGridLabel1";
            DataGridLabel1.Size = new Size(152, 15);
            DataGridLabel1.TabIndex = 10;
            DataGridLabel1.Text = "Госпиталь\\Поликлинника";
            // 
            // DataGridLabel2
            // 
            DataGridLabel2.AutoSize = true;
            DataGridLabel2.Location = new Point(176, 269);
            DataGridLabel2.Name = "DataGridLabel2";
            DataGridLabel2.Size = new Size(109, 15);
            DataGridLabel2.TabIndex = 11;
            DataGridLabel2.Text = "Список пациентов";
            // 
            // DataGridLabel3
            // 
            DataGridLabel3.AutoSize = true;
            DataGridLabel3.Location = new Point(746, 269);
            DataGridLabel3.Name = "DataGridLabel3";
            DataGridLabel3.Size = new Size(102, 15);
            DataGridLabel3.TabIndex = 12;
            DataGridLabel3.Text = "Список докторов";
            // 
            // LoadDoctorDataButton
            // 
            LoadDoctorDataButton.Location = new Point(688, 316);
            LoadDoctorDataButton.Name = "LoadDoctorDataButton";
            LoadDoctorDataButton.Size = new Size(220, 23);
            LoadDoctorDataButton.TabIndex = 13;
            LoadDoctorDataButton.Text = "Загрузить информацию о докторах";
            LoadDoctorDataButton.UseVisualStyleBackColor = true;
            LoadDoctorDataButton.Click += LoadDoctorDataButton_Click;
            // 
            // LoadHospitalDataButton
            // 
            LoadHospitalDataButton.Location = new Point(118, 215);
            LoadHospitalDataButton.Name = "LoadHospitalDataButton";
            LoadHospitalDataButton.Size = new Size(241, 23);
            LoadHospitalDataButton.TabIndex = 14;
            LoadHospitalDataButton.Text = "Загрузить информацию о госпиталях";
            LoadHospitalDataButton.UseVisualStyleBackColor = true;
            LoadHospitalDataButton.Click += LoadHospitalDataButton_Click;
            // 
            // LoadPolyclinicDataButton
            // 
            LoadPolyclinicDataButton.Location = new Point(668, 215);
            LoadPolyclinicDataButton.Name = "LoadPolyclinicDataButton";
            LoadPolyclinicDataButton.Size = new Size(240, 23);
            LoadPolyclinicDataButton.TabIndex = 15;
            LoadPolyclinicDataButton.Text = "Загрузить информацию о поликлиниках";
            LoadPolyclinicDataButton.UseVisualStyleBackColor = true;
            LoadPolyclinicDataButton.Click += LoadPolyclinicDataButton_Click;
            // 
            // MainFormV2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 519);
            Controls.Add(LoadPolyclinicDataButton);
            Controls.Add(LoadHospitalDataButton);
            Controls.Add(LoadDoctorDataButton);
            Controls.Add(DataGridLabel3);
            Controls.Add(DataGridLabel2);
            Controls.Add(DataGridLabel1);
            Controls.Add(HospitalDataGridView);
            Controls.Add(PolyclinicDataGridView);
            Controls.Add(DoctorDataGridView);
            Controls.Add(PatientDataGridView);
            Controls.Add(LoadPatientDataButton);
            Controls.Add(PolyclinicButton);
            Controls.Add(HospitalButton);
            Controls.Add(PatientButton);
            Controls.Add(DoctorButton);
            Name = "MainFormV2";
            Text = "MainFormV2";
            Load += MainFormV2_Load;
            ((System.ComponentModel.ISupportInitialize)PatientDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoctorDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)PolyclinicDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)HospitalDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DoctorButton;
        private Button PatientButton;
        private Button HospitalButton;
        private Button PolyclinicButton;
        private Button LoadPatientDataButton;
        private DataGridView PatientDataGridView;
        private DataGridView DoctorDataGridView;
        private DataGridView PolyclinicDataGridView;
        private DataGridView HospitalDataGridView;
        private Label DataGridLabel1;
        private Label DataGridLabel2;
        private Label DataGridLabel3;
        private Button LoadDoctorDataButton;
        private Button LoadHospitalDataButton;
        private Button LoadPolyclinicDataButton;
    }
}