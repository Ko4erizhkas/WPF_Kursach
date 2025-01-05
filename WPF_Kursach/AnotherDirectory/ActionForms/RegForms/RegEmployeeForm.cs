using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPF_Kursach.AnotherDirectory.ControlDirectory;

namespace WPF_Kursach.AnotherDirectory.ActionForms.RegForms
{
    public partial class RegEmployeeForm : Form
    {
        public RegEmployeeForm()
        {
            InitializeComponent();
        }

        private void RegEmployee_Load(object sender, EventArgs e)
        {

        }

        private void Emp_RegButton_1_Click(object sender, EventArgs e)
        {
            GeneratorFiles generatorFiles = new GeneratorFiles();

            string Emp_ID = Emp_IdTextBox_1.Text;
            string Emp_Surname = Emp_SurnameTextBox_1.Text;
            string Emp_FullName = Emp_FullNameTextBox_1.Text;
            string Emp_MiddleName = Emp_MiddleNameTextBox_1.Text;
            string Emp_PhoneNumber = Emp_PhoneNumberTextBox_1.Text;
            string Emp_Snils = Emp_SnilsTextBox_1.Text;


            string Emp_Degree;
            if (Emp_DegreeComboBox_1.SelectedItem != null)
            {
                Emp_Degree = Emp_DegreeComboBox_1.SelectedItem.ToString();
            }
            else 
            {
                Emp_Degree = string.Empty;
                MessageBox.Show("Ошибка: NullReferenceException \n Введена пустая строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new NullReferenceException("Emp_Degree is null!");
            }

            string Emp_Spec;
            if (Emp_SpecComboBox_1.SelectedItem != null)
            {
                Emp_Spec = Emp_SpecComboBox_1.SelectedItem.ToString();   
            }
            else
            {
                Emp_Spec = string.Empty;
                MessageBox.Show("Ошибка: NullReferenceException \n Введена пустая строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new NullReferenceException("Emp_Spec is null!");
            }

            var NewEmployee = new Employee(Emp_FullName, Emp_Surname, Emp_MiddleName, 
                                           Emp_Spec, Emp_ID, Emp_PhoneNumber, 
                                           Emp_Degree, Emp_Snils);

            generatorFiles.GenerateFile(@"E:\Курсач\Employee", "Employee", NewEmployee);
            this.Close();
            MessageBox.Show("Данные успешно сохранены", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
