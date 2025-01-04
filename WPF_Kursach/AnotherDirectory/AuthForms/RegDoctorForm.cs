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
            string D_SpecName = D_SpecTextBox_1.Text;
            string D_PhoneNumber = D_PhoneNumberTextBox_1.Text;
            string D_Gender = D_GenderTextBox_1.Text;
            string D_Address = D_AddressTextBox_1.Text;
            string D_MedInst = D_MedInstTextBox_1.Text;
            string D_MiddleName = D_MiddleNameTextBox_1.Text;
            string D_EmailAddress = D_EmailAddressTextBox_1.Text;

            DateTime D_DateBirth = D_DateTimePicker_1.Value;
            uint D_Age = Convert.ToUInt32(D_YearsTextBox_1.Text);
            int D_ExpYears = Convert.ToInt32(D_ExpTextBox_1.Text);
            decimal D_Salary = Convert.ToDecimal(D_SalaryTextBox_1.Text);
            var NewDoctor = new Doctor(D_FullName, D_Surname,D_MiddleName, 
                                       D_SpecName, D_ExpYears, D_PhoneNumber,
                                       D_DateBirth, D_Gender, D_Address, D_EmailAddress, D_Age);

            generatorFiles.GenerateFile(@"E:\Курсач\Doctor", "Doctor", NewDoctor);

            this.Close();
            MessageBox.Show("Данные успешно сохранены!", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
