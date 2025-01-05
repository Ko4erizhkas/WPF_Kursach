namespace WPF_Kursach.ActionForms
{
    partial class UploadInfoFromJsonForm
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
            UploadInfoButton_1 = new Button();
            UploadInfoLabel_1 = new Label();
            UploadInfoTextBox_1 = new TextBox();
            UploadInfoListBox_1 = new ListBox();
            UploadInfoLabel_2 = new Label();
            SuspendLayout();
            // 
            // UploadInfoButton_1
            // 
            UploadInfoButton_1.Location = new Point(176, 66);
            UploadInfoButton_1.Name = "UploadInfoButton_1";
            UploadInfoButton_1.Size = new Size(124, 23);
            UploadInfoButton_1.TabIndex = 0;
            UploadInfoButton_1.Text = "Загрузить ";
            UploadInfoButton_1.UseVisualStyleBackColor = true;
            UploadInfoButton_1.Click += UploadInfoButton_1_Click;
            // 
            // UploadInfoLabel_1
            // 
            UploadInfoLabel_1.AutoSize = true;
            UploadInfoLabel_1.Location = new Point(176, 9);
            UploadInfoLabel_1.Name = "UploadInfoLabel_1";
            UploadInfoLabel_1.Size = new Size(124, 15);
            UploadInfoLabel_1.TabIndex = 1;
            UploadInfoLabel_1.Text = "Введите путь к файлу";
            // 
            // UploadInfoTextBox_1
            // 
            UploadInfoTextBox_1.Location = new Point(150, 37);
            UploadInfoTextBox_1.Name = "UploadInfoTextBox_1";
            UploadInfoTextBox_1.Size = new Size(190, 23);
            UploadInfoTextBox_1.TabIndex = 2;
            // 
            // UploadInfoListBox_1
            // 
            UploadInfoListBox_1.FormattingEnabled = true;
            UploadInfoListBox_1.ItemHeight = 15;
            UploadInfoListBox_1.Location = new Point(12, 131);
            UploadInfoListBox_1.Name = "UploadInfoListBox_1";
            UploadInfoListBox_1.Size = new Size(1238, 289);
            UploadInfoListBox_1.TabIndex = 3;
            // 
            // UploadInfoLabel_2
            // 
            UploadInfoLabel_2.AutoSize = true;
            UploadInfoLabel_2.Location = new Point(143, 103);
            UploadInfoLabel_2.Name = "UploadInfoLabel_2";
            UploadInfoLabel_2.Size = new Size(197, 15);
            UploadInfoLabel_2.TabIndex = 4;
            UploadInfoLabel_2.Text = "Полученная информация в файле";
            // 
            // UploadInfoFromJsonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 578);
            Controls.Add(UploadInfoLabel_2);
            Controls.Add(UploadInfoListBox_1);
            Controls.Add(UploadInfoTextBox_1);
            Controls.Add(UploadInfoLabel_1);
            Controls.Add(UploadInfoButton_1);
            Name = "UploadInfoFromJsonForm";
            Text = "UploadInfoFromJsonForm";
            Load += UploadInfoFromJsonForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UploadInfoButton_1;
        private Label UploadInfoLabel_1;
        private TextBox UploadInfoTextBox_1;
        private ListBox UploadInfoListBox_1;
        private Label UploadInfoLabel_2;
    }
}