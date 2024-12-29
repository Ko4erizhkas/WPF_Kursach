using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPF_Kursach.ControlDirectory;

namespace WPF_Kursach
{
    public partial class RegPatientForm : Form
    {
        public RegPatientForm()
        {
            InitializeComponent();
        }

        private void AuthPatient_Load(object sender, EventArgs e) { }

        private void RegPatientButtom_1_Click(object sender, EventArgs e)
        {
            GeneratorFiles generatorFiles = new GeneratorFiles();

            string P_FullName = P_FullNameTextBox_1.Text;
            string P_Surname = P_SurnameTextBox_1.Text;
            string P_PhoneNumber = P_PhoneNumberTextBox_1.Text;
            string P_MedInst = P_MedInstTextBox1.Text;
            string P_Gender = P_GenderTextBox_1.Text;
            string P_Address = P_AddressTextBox_1.Text;
            uint P_Age = Convert.ToUInt32(P_AgeTextBox_1.Text);
            string P_DateBirth = P_DateBirthTextBox_1.Text;
            var NewPatient = new Patient(P_FullName, P_Surname,P_DateBirth, 
                                          P_Gender, P_Address,P_PhoneNumber,
                                          P_MedInst, P_Age);
            
            generatorFiles.GenerateFile(@"E:\Курсач\Patient", "Patient", NewPatient);
        }
    }
}
