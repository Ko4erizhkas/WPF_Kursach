using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using WPF_Kursach.AnotherDirectory.ControlDirectory;

namespace WPF_Kursach
{
    public partial class RegDoctorForm : Form
    {
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
            string D_Snils = D_SnilsTextBox_1.Text;
            string D_Id = D_IdTextBox_1.Text;

            string D_SpecName;
            string D_MedArea;
            string D_MedBranch;
            string D_Degree;

            if (D_SpecComboBox_1.SelectedItem != null)
            {
                D_SpecName = D_SpecComboBox_1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка: NullReferenceException \n Введена пустая строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new NullReferenceException("D_SpecName is null!");
            }
            if (D_MedAreaComboBox_1.SelectedItem != null)
            {
                D_MedArea = D_MedAreaComboBox_1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка: NullReferenceException \n Введена пустая строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new NullReferenceException("D_MedArea is null!");
            }
            if (D_MedBranchComboBox_1.SelectedItem != null)
            {
                D_MedBranch = D_MedBranchComboBox_1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка: NullReferenceException \n Введена пустая строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new NullReferenceException("D_MedBranch is null!");
            }
            if (D_DegreeComboBox_1.SelectedItem != null)
            {
                D_Degree = D_DegreeComboBox_1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка: NullReferenceException \n Введена пустая строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new NullReferenceException("D_DegreeComboBox_1 is null!");
            }

            decimal D_Salary = Convert.ToDecimal(D_SalaryTextBox_1.Text);
            var NewDoctor = new Doctor(D_FullName, D_Surname, D_MiddleName,
                                       D_SpecName, D_Id, D_PhoneNumber,
                                       D_Degree, D_Snils, D_MedArea,
                                       D_MedBranch, D_Description, D_Salary);

            generatorFiles.GenerateFile(@"E:\Курсач\Doctor", "Doctor", NewDoctor);

            this.Close();
            MessageBox.Show("Данные успешно сохранены!", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void D_CloseButton_1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
