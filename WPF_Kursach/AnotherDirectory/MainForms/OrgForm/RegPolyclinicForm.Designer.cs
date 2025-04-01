namespace WPF_Kursach.AnotherDirectory.ActionForms.RegForms
{
    partial class RegPolyclinicForm
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
            RP_Label_1 = new Label();
            RP_TextBox_4 = new TextBox();
            RP_TextBox_2 = new TextBox();
            RP_TextBox_3 = new TextBox();
            RP_TextBox_1 = new TextBox();
            RP_Button_1 = new Button();
            SuspendLayout();
            // 
            // RP_Label_1
            // 
            RP_Label_1.AutoSize = true;
            RP_Label_1.Location = new Point(14, 9);
            RP_Label_1.Name = "RP_Label_1";
            RP_Label_1.Size = new Size(154, 15);
            RP_Label_1.TabIndex = 11;
            RP_Label_1.Text = "Регистрация поликлиники";
            // 
            // RP_TextBox_4
            // 
            RP_TextBox_4.Location = new Point(12, 125);
            RP_TextBox_4.Multiline = true;
            RP_TextBox_4.Name = "RP_TextBox_4";
            RP_TextBox_4.PlaceholderText = "Описание";
            RP_TextBox_4.Size = new Size(164, 99);
            RP_TextBox_4.TabIndex = 10;
            // 
            // RP_TextBox_2
            // 
            RP_TextBox_2.Location = new Point(12, 65);
            RP_TextBox_2.Name = "RP_TextBox_2";
            RP_TextBox_2.PlaceholderText = "Адрес";
            RP_TextBox_2.Size = new Size(164, 23);
            RP_TextBox_2.TabIndex = 9;
            // 
            // RP_TextBox_3
            // 
            RP_TextBox_3.Location = new Point(12, 95);
            RP_TextBox_3.Name = "RP_TextBox_3";
            RP_TextBox_3.PlaceholderText = "Вместимость";
            RP_TextBox_3.Size = new Size(164, 23);
            RP_TextBox_3.TabIndex = 8;
            // 
            // RP_TextBox_1
            // 
            RP_TextBox_1.Location = new Point(12, 35);
            RP_TextBox_1.Name = "RP_TextBox_1";
            RP_TextBox_1.PlaceholderText = "Название";
            RP_TextBox_1.Size = new Size(164, 23);
            RP_TextBox_1.TabIndex = 7;
            // 
            // RP_Button_1
            // 
            RP_Button_1.Location = new Point(14, 230);
            RP_Button_1.Name = "RP_Button_1";
            RP_Button_1.Size = new Size(75, 23);
            RP_Button_1.TabIndex = 6;
            RP_Button_1.Text = "ОК";
            RP_Button_1.UseVisualStyleBackColor = true;
            RP_Button_1.Click += RP_Button_1_Click;
            // 
            // RegPolyclinicForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(188, 256);
            Controls.Add(RP_Label_1);
            Controls.Add(RP_TextBox_4);
            Controls.Add(RP_TextBox_2);
            Controls.Add(RP_TextBox_3);
            Controls.Add(RP_TextBox_1);
            Controls.Add(RP_Button_1);
            Name = "RegPolyclinicForm";
            Text = "Регистрация поликлиники";
            Load += RegPolyclinicForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RP_Label_1;
        private TextBox RP_TextBox_4;
        private TextBox RP_TextBox_2;
        private TextBox RP_TextBox_3;
        private TextBox RP_TextBox_1;
        private Button RP_Button_1;
    }
}