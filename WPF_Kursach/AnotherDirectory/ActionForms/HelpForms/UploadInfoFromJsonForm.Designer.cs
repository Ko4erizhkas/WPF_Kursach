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
            components = new System.ComponentModel.Container();
            UploadInfoButton_1 = new Button();
            UploadInfoLabel_1 = new Label();
            UploadInfoTextBox_1 = new TextBox();
            UploadInfoLabel_2 = new Label();
            dataGridView1 = new DataGridView();
            doctorBindingSource = new BindingSource(components);
            patientBindingSource = new BindingSource(components);
            listBox1 = new ListBox();
            doctorBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource1).BeginInit();
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
            // UploadInfoLabel_2
            // 
            UploadInfoLabel_2.AutoSize = true;
            UploadInfoLabel_2.Location = new Point(143, 103);
            UploadInfoLabel_2.Name = "UploadInfoLabel_2";
            UploadInfoLabel_2.Size = new Size(197, 15);
            UploadInfoLabel_2.TabIndex = 4;
            UploadInfoLabel_2.Text = "Полученная информация в файле";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1145, 150);
            dataGridView1.TabIndex = 5;
            // 
            // doctorBindingSource
            // 
            doctorBindingSource.DataSource = typeof(AnotherDirectory.ControlClasses.Doctor);
            // 
            // patientBindingSource
            // 
            patientBindingSource.DataSource = typeof(AnotherDirectory.ControlClasses.Patient);
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 304);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(840, 244);
            listBox1.TabIndex = 7;
            // 
            // doctorBindingSource1
            // 
            doctorBindingSource1.DataSource = typeof(AnotherDirectory.ControlClasses.Doctor);
            // 
            // UploadInfoFromJsonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 578);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Controls.Add(UploadInfoLabel_2);
            Controls.Add(UploadInfoTextBox_1);
            Controls.Add(UploadInfoLabel_1);
            Controls.Add(UploadInfoButton_1);
            Name = "UploadInfoFromJsonForm";
            Text = "UploadInfoFromJsonForm";
            Load += UploadInfoFromJsonForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UploadInfoButton_1;
        private Label UploadInfoLabel_1;
        private TextBox UploadInfoTextBox_1;
        private Label UploadInfoLabel_2;
        private DataGridView dataGridView1;
        private BindingSource doctorBindingSource;
        private BindingSource patientBindingSource;
        private ListBox listBox1;
        private BindingSource doctorBindingSource1;
    }
}