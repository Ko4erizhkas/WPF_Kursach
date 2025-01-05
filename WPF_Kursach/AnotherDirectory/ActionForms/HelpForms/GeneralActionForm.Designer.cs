namespace WPF_Kursach.ActionForms
{
    partial class GeneralActionForm
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
            GeneralLabel = new Label();
            Polyclinic_Buttom = new Button();
            SuspendLayout();
            // 
            // GeneralLabel
            // 
            GeneralLabel.AutoSize = true;
            GeneralLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GeneralLabel.Location = new Point(181, 25);
            GeneralLabel.Name = "GeneralLabel";
            GeneralLabel.Size = new Size(374, 23);
            GeneralLabel.TabIndex = 0;
            GeneralLabel.Text = "Выберите тип медицинского учреждения";
            // 
            // Polyclinic_Buttom
            // 
            Polyclinic_Buttom.Location = new Point(12, 69);
            Polyclinic_Buttom.Name = "Polyclinic_Buttom";
            Polyclinic_Buttom.Size = new Size(149, 80);
            Polyclinic_Buttom.TabIndex = 1;
            Polyclinic_Buttom.Text = "Поликлиника";
            Polyclinic_Buttom.UseVisualStyleBackColor = true;
            // 
            // GeneralActionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Polyclinic_Buttom);
            Controls.Add(GeneralLabel);
            Name = "GeneralActionForm";
            Text = "Главная форма";
            Load += GeneralActionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GeneralLabel;
        private Button Polyclinic_Buttom;
    }
}