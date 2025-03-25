namespace WPF_Kursach.ActionForms
{
    partial class SelectOrganizationForm
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
            SelectPolyButton_1 = new Button();
            SelectHospitalButton_1 = new Button();
            SelectOrgLabel_1 = new Label();
            SuspendLayout();
            // 
            // SelectPolyButton_1
            // 
            SelectPolyButton_1.Location = new Point(10, 40);
            SelectPolyButton_1.Name = "SelectPolyButton_1";
            SelectPolyButton_1.Size = new Size(93, 42);
            SelectPolyButton_1.TabIndex = 0;
            SelectPolyButton_1.Text = "Поликлиника";
            SelectPolyButton_1.UseVisualStyleBackColor = true;
            SelectPolyButton_1.Click += SelectPolyButton_1_Click;
            // 
            // SelectHospitalButton_1
            // 
            SelectHospitalButton_1.Location = new Point(110, 40);
            SelectHospitalButton_1.Name = "SelectHospitalButton_1";
            SelectHospitalButton_1.Size = new Size(96, 42);
            SelectHospitalButton_1.TabIndex = 1;
            SelectHospitalButton_1.Text = "Госпиталь";
            SelectHospitalButton_1.UseVisualStyleBackColor = true;
            // 
            // SelectOrgLabel_1
            // 
            SelectOrgLabel_1.AutoSize = true;
            SelectOrgLabel_1.Location = new Point(30, 10);
            SelectOrgLabel_1.Name = "SelectOrgLabel_1";
            SelectOrgLabel_1.Size = new Size(157, 15);
            SelectOrgLabel_1.TabIndex = 2;
            SelectOrgLabel_1.Text = "Выберите тип организации";
            // 
            // SelectOrganizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 111);
            Controls.Add(SelectOrgLabel_1);
            Controls.Add(SelectHospitalButton_1);
            Controls.Add(SelectPolyButton_1);
            Name = "SelectOrganizationForm";
            Text = "Выбор организации";
            Load += SelectOrganizationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SelectPolyButton_1;
        private Button SelectHospitalButton_1;
        private Label SelectOrgLabel_1;
    }
}