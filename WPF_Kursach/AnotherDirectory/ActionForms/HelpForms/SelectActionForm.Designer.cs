namespace WPF_Kursach
{
    partial class SelectActionForm
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
            AddDoctorButtom = new Button();
            AddPatient = new Button();
            CloseButtom = new Button();
            SuspendLayout();
            // 
            // AddDoctorButtom
            // 
            AddDoctorButtom.Location = new Point(12, 12);
            AddDoctorButtom.Name = "AddDoctorButtom";
            AddDoctorButtom.Size = new Size(117, 68);
            AddDoctorButtom.TabIndex = 0;
            AddDoctorButtom.Text = "Зарегистрировать доктора";
            AddDoctorButtom.UseVisualStyleBackColor = true;
            AddDoctorButtom.Click += AddDoctorButtom_Click;
            // 
            // AddPatient
            // 
            AddPatient.Location = new Point(135, 12);
            AddPatient.Name = "AddPatient";
            AddPatient.Size = new Size(106, 68);
            AddPatient.TabIndex = 1;
            AddPatient.Text = "Зарегистрировать пациента";
            AddPatient.UseVisualStyleBackColor = true;
            AddPatient.Click += AddPatientButtom_Click;
            // 
            // CloseButtom
            // 
            CloseButtom.Location = new Point(71, 106);
            CloseButtom.Name = "CloseButtom";
            CloseButtom.Size = new Size(106, 68);
            CloseButtom.TabIndex = 2;
            CloseButtom.Text = "Закрыть приложение";
            CloseButtom.UseVisualStyleBackColor = true;
            CloseButtom.Click += this.CloseButtom_Click;
            // 
            // SelectActionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 186);
            Controls.Add(CloseButtom);
            Controls.Add(AddPatient);
            Controls.Add(AddDoctorButtom);
            Name = "SelectActionForm";
            Text = "SelectAction";
            Load += SelectAction_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button AddDoctorButtom;
        private Button AddPatient;
        private Button CloseButtom;
    }
}