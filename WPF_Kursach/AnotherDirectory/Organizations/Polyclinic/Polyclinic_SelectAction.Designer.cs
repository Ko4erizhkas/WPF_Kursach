namespace WPF_Kursach.Polyclinic
{
    partial class Polyclinic_RegPatient
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
            Polyclinic_AddPatient = new Button();
            SuspendLayout();
            // 
            // Polyclinic_AddPatient
            // 
            Polyclinic_AddPatient.Location = new Point(12, 12);
            Polyclinic_AddPatient.Name = "Polyclinic_AddPatient";
            Polyclinic_AddPatient.Size = new Size(106, 68);
            Polyclinic_AddPatient.TabIndex = 2;
            Polyclinic_AddPatient.Text = "Зарегистрировать пациента";
            Polyclinic_AddPatient.UseVisualStyleBackColor = true;
            Polyclinic_AddPatient.Click += Polyclinic_AddPatient_Click;
            // 
            // Polyclinic_RegPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 241);
            Controls.Add(Polyclinic_AddPatient);
            Name = "Polyclinic_RegPatient";
            Text = "Регистрация ";
            ResumeLayout(false);
        }

        #endregion

        private Button Polyclinic_AddPatient;
    }
}