namespace WPF_Kursach.AnotherDirectory.ActionForms.RegForms
{
    partial class RegHospitalForm
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
            RH_Button_1 = new Button();
            RH_TextBox_1 = new TextBox();
            RH_TextBox_3 = new TextBox();
            RH_TextBox_2 = new TextBox();
            RH_TextBox_4 = new TextBox();
            RH_Label_1 = new Label();
            SuspendLayout();
            // 
            // RH_Button_1
            // 
            RH_Button_1.Location = new Point(12, 230);
            RH_Button_1.Name = "RH_Button_1";
            RH_Button_1.Size = new Size(75, 23);
            RH_Button_1.TabIndex = 0;
            RH_Button_1.Text = "ОК";
            RH_Button_1.UseVisualStyleBackColor = true;
            // 
            // RH_TextBox_1
            // 
            RH_TextBox_1.Location = new Point(10, 35);
            RH_TextBox_1.Name = "RH_TextBox_1";
            RH_TextBox_1.PlaceholderText = "Название";
            RH_TextBox_1.Size = new Size(164, 23);
            RH_TextBox_1.TabIndex = 1;
            // 
            // RH_TextBox_3
            // 
            RH_TextBox_3.Location = new Point(10, 95);
            RH_TextBox_3.Name = "RH_TextBox_3";
            RH_TextBox_3.PlaceholderText = "Вместимость";
            RH_TextBox_3.Size = new Size(164, 23);
            RH_TextBox_3.TabIndex = 2;
            // 
            // RH_TextBox_2
            // 
            RH_TextBox_2.Location = new Point(10, 65);
            RH_TextBox_2.Name = "RH_TextBox_2";
            RH_TextBox_2.PlaceholderText = "Адрес";
            RH_TextBox_2.Size = new Size(164, 23);
            RH_TextBox_2.TabIndex = 3;
            // 
            // RH_TextBox_4
            // 
            RH_TextBox_4.Location = new Point(10, 125);
            RH_TextBox_4.Multiline = true;
            RH_TextBox_4.Name = "RH_TextBox_4";
            RH_TextBox_4.PlaceholderText = "Описание";
            RH_TextBox_4.Size = new Size(164, 99);
            RH_TextBox_4.TabIndex = 4;
            // 
            // RH_Label_1
            // 
            RH_Label_1.AutoSize = true;
            RH_Label_1.Location = new Point(23, 9);
            RH_Label_1.Name = "RH_Label_1";
            RH_Label_1.Size = new Size(135, 15);
            RH_Label_1.TabIndex = 5;
            RH_Label_1.Text = "Регистрация госпиталя";
            // 
            // RegHospitalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(183, 258);
            Controls.Add(RH_Label_1);
            Controls.Add(RH_TextBox_4);
            Controls.Add(RH_TextBox_2);
            Controls.Add(RH_TextBox_3);
            Controls.Add(RH_TextBox_1);
            Controls.Add(RH_Button_1);
            Name = "RegHospitalForm";
            Text = "Регистрация госпиталя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RH_Button_1;
        private TextBox RH_TextBox_1;
        private TextBox RH_TextBox_3;
        private TextBox RH_TextBox_2;
        private TextBox RH_TextBox_4;
        private Label RH_Label_1;
    }
}