namespace WPF_Kursach.ActionForms
{
    partial class RegOrganization
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
            RegOrgLabel_1 = new Label();
            RegOrgButton_1 = new Button();
            RegOrg_NameTextBox_1 = new TextBox();
            RegOrg_AddressTextBox_1 = new TextBox();
            RegOrg_DescTextBox_1 = new TextBox();
            RegOrg_DescLabel_1 = new Label();
            RegOrg_AddressLabel_1 = new Label();
            RegOrg_NameLabel_1 = new Label();
            SuspendLayout();
            // 
            // RegOrgLabel_1
            // 
            RegOrgLabel_1.AutoSize = true;
            RegOrgLabel_1.Location = new Point(48, 9);
            RegOrgLabel_1.Name = "RegOrgLabel_1";
            RegOrgLabel_1.Size = new Size(150, 15);
            RegOrgLabel_1.TabIndex = 3;
            RegOrgLabel_1.Text = "Регистрация организации";
            // 
            // RegOrgButton_1
            // 
            RegOrgButton_1.Location = new Point(48, 295);
            RegOrgButton_1.Name = "RegOrgButton_1";
            RegOrgButton_1.Size = new Size(126, 42);
            RegOrgButton_1.TabIndex = 4;
            RegOrgButton_1.Text = "Зарегестирировать";
            RegOrgButton_1.UseVisualStyleBackColor = true;
            // 
            // RegOrg_NameTextBox_1
            // 
            RegOrg_NameTextBox_1.Location = new Point(12, 73);
            RegOrg_NameTextBox_1.Name = "RegOrg_NameTextBox_1";
            RegOrg_NameTextBox_1.Size = new Size(211, 23);
            RegOrg_NameTextBox_1.TabIndex = 5;
            // 
            // RegOrg_AddressTextBox_1
            // 
            RegOrg_AddressTextBox_1.Location = new Point(12, 126);
            RegOrg_AddressTextBox_1.Name = "RegOrg_AddressTextBox_1";
            RegOrg_AddressTextBox_1.Size = new Size(211, 23);
            RegOrg_AddressTextBox_1.TabIndex = 6;
            // 
            // RegOrg_DescTextBox_1
            // 
            RegOrg_DescTextBox_1.Location = new Point(12, 183);
            RegOrg_DescTextBox_1.Multiline = true;
            RegOrg_DescTextBox_1.Name = "RegOrg_DescTextBox_1";
            RegOrg_DescTextBox_1.Size = new Size(211, 85);
            RegOrg_DescTextBox_1.TabIndex = 7;
            // 
            // RegOrg_DescLabel_1
            // 
            RegOrg_DescLabel_1.AutoSize = true;
            RegOrg_DescLabel_1.Location = new Point(12, 165);
            RegOrg_DescLabel_1.Name = "RegOrg_DescLabel_1";
            RegOrg_DescLabel_1.Size = new Size(62, 15);
            RegOrg_DescLabel_1.TabIndex = 8;
            RegOrg_DescLabel_1.Text = "Описание";
            // 
            // RegOrg_AddressLabel_1
            // 
            RegOrg_AddressLabel_1.AutoSize = true;
            RegOrg_AddressLabel_1.Location = new Point(12, 108);
            RegOrg_AddressLabel_1.Name = "RegOrg_AddressLabel_1";
            RegOrg_AddressLabel_1.Size = new Size(114, 15);
            RegOrg_AddressLabel_1.TabIndex = 9;
            RegOrg_AddressLabel_1.Text = "Адрес организации";
            // 
            // RegOrg_NameLabel_1
            // 
            RegOrg_NameLabel_1.AutoSize = true;
            RegOrg_NameLabel_1.Location = new Point(12, 55);
            RegOrg_NameLabel_1.Name = "RegOrg_NameLabel_1";
            RegOrg_NameLabel_1.Size = new Size(133, 15);
            RegOrg_NameLabel_1.TabIndex = 10;
            RegOrg_NameLabel_1.Text = "Название организации";
            // 
            // RegOrganization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 395);
            Controls.Add(RegOrg_NameLabel_1);
            Controls.Add(RegOrg_AddressLabel_1);
            Controls.Add(RegOrg_DescLabel_1);
            Controls.Add(RegOrg_DescTextBox_1);
            Controls.Add(RegOrg_AddressTextBox_1);
            Controls.Add(RegOrg_NameTextBox_1);
            Controls.Add(RegOrgButton_1);
            Controls.Add(RegOrgLabel_1);
            Name = "RegOrganization";
            Text = "RegOrganization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RegOrgLabel_1;
        private Button RegOrgButton_1;
        private TextBox RegOrg_NameTextBox_1;
        private TextBox RegOrg_AddressTextBox_1;
        private TextBox RegOrg_DescTextBox_1;
        private Label RegOrg_DescLabel_1;
        private Label RegOrg_AddressLabel_1;
        private Label RegOrg_NameLabel_1;
    }
}