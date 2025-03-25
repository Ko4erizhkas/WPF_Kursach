using WPF_Kursach.AnotherDirectory.ControlClasses;

namespace WPF_Kursach
{
    public partial class RegPatientForm : Form
    {
        public RegPatientForm()
        {
            InitializeComponent();
            P_GenderComboBox_1.SelectedIndex = 0;
        }

        private void AuthPatient_Load(object sender, EventArgs e) { }

        private void RegPatientButtom_1_Click(object sender, EventArgs e)
        {
            GeneratorFiles generatorFiles = new GeneratorFiles();


            string P_FullName = P_FullNameTextBox_1.Text;
            string P_Surname = P_SurnameTextBox_1.Text;
            string P_MiddleName = P_MiddleNameTextBox_1.Text;
            string P_PhoneNumber = P_PhoneNumberTextBox_1.Text;
            string P_EmailAddress = P_EmailTextBox1.Text;
            string P_DoctorFullName = P_DoctorFullNameTextBox_1.Text;
            string P_DoctorSurname = P_DoctorSurnameTextBox_1.Text;
            string P_DoctorMiddleName = P_DoctorMiddleNameTextBox_1.Text;


            int P_Age = Convert.ToInt32(P_AgeTextBox_1.Text);

            DateOnly P_DateBirth = DateOnly.FromDateTime(P_DateTimePicker_1.Value);
            Doctor P_CurrentDoctor = new Doctor(P_DoctorFullName,P_DoctorSurname, P_DoctorMiddleName, null, null,null,null,null);

            string? P_Gender;
            if (P_GenderComboBox_1.SelectedItem != null)
            {
                P_Gender = P_GenderComboBox_1.SelectedItem.ToString();
            }
            else
            {
                P_Gender = string.Empty;
                MessageBox.Show(
                    "Ошибка: NullReferenceException" +
                    " \n Введена пустая строка!",
                    "Ошибка!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                throw new NullReferenceException("P_Gender is null!");
            }
            if (P_Age < 0)
            {
                MessageBox.Show("Введено некоректное значение! Установлено значение по умолчанию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            var NewPatient = new Patient(P_FullName, P_Surname, P_MiddleName, P_DateBirth,
                                         P_Gender, P_PhoneNumber,
                                         P_EmailAddress, P_Age, P_CurrentDoctor);

            generatorFiles.GenerateFile(@"E:\Курсач\Patient", "Patient", NewPatient);

            this.Close();
            MessageBox.Show(
                "Данные успешно сохранены!",
                "Готово!", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
