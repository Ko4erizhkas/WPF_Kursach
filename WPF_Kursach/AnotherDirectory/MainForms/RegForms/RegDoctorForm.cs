using WPF_Kursach.AnotherDirectory.ControlClasses;

namespace WPF_Kursach
{
    public partial class RegDoctorForm : Form
    {
        private GeneratorFiles gf = new GeneratorFiles();
        static private readonly string path = AppDomain.CurrentDomain.BaseDirectory;
        static private readonly string relativePath = @"AnotherDirectory\DataBase\DoctorData";
        static private readonly string absolutePath = Path.Combine(path, relativePath);
        public RegDoctorForm()
        {
            InitializeComponent();
        }
        private void AuthDoctorForm_Load(object sender, EventArgs e)
        {
        }
        private void AuthDoctorButtom_1_Click(object sender, EventArgs e)
        {
            GeneratorFiles generatorFiles = new GeneratorFiles();

            string D_FullName = D_FullNameTextBox_1.Text;
            string D_Surname = D_SurnameTextBox_1.Text;
            string D_MiddleName = D_MiddleNameTextBox_1.Text;
            string D_PhoneNumber = D_PhoneNumberTextBox_1.Text;
            string D_Gender = D_GenderTextBox_1.Text;
            string D_Address = D_AddressTextBox_1.Text;
            string D_Description = D_DescriptionTextBox_1.Text;
            string D_Id = D_IdTextBox_1.Text;

            string D_SpecName;
            string D_MedArea;
            string D_MedBranch;
            string D_Degree;
            string D_MedRank;

            if (D_SpecComboBox_1.SelectedItem != null)
            {
                D_SpecName = D_SpecComboBox_1.SelectedItem.ToString();
            }
            else
            {
                
                MessageBox.Show("Ошибка: NullReferenceException \n Введена пустая строка! Присвоено значение по умолчанию!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new NullReferenceException("D_SpecComboBox_1.SelectedItem is null!");
            }
            if (D_MedAreaComboBox_1.SelectedItem != null)
            {
                D_MedArea = D_MedAreaComboBox_1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка: NullReferenceException \n Введена пустая строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new NullReferenceException("D_MedAreaComboBox_1.SelectedItem is null!");
            }
            if (D_MedBranchComboBox_1.SelectedItem != null)
            {
                D_MedBranch = D_MedBranchComboBox_1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка: NullReferenceException \n Введена пустая строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new NullReferenceException("D_MedBranchComboBox_1.SelectedItem is null!");
            }
            if (D_DegreeComboBox_1.SelectedItem != null)
            {
                D_Degree = D_DegreeComboBox_1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка: NullReferenceException \n Введена пустая строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new NullReferenceException("D_DegreeComboBox_1.SelectedItem is null!");
            }
            if (D_MedRankComboBox_1.SelectedItem != null)
            {
                D_MedRank = D_MedRankComboBox_1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка: NullReferenceException \n Введена пустая строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new NullReferenceException("D_MedRankComboBox_1.SelectedItem is null!");
            }
            decimal D_Salary = Convert.ToDecimal(D_SalaryTextBox_1.Text);
            var NewDoctor = new Doctor(D_FullName, D_Surname, D_MiddleName,
                                       D_SpecName, D_Id, D_PhoneNumber,
                                       D_Degree, D_MedArea,
                                       D_MedBranch, D_MedRank ,D_Description, D_Salary);

            gf.LoadDataJson(absolutePath, "Doctor", NewDoctor);

            this.Close();
            MessageBox.Show("Данные успешно сохранены!", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void D_CloseButton_1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
