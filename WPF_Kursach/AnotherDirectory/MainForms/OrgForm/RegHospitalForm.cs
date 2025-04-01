using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPF_Kursach.AnotherDirectory.ControlClasses;

namespace WPF_Kursach.AnotherDirectory.ActionForms.RegForms
{
    public partial class RegHospitalForm : Form
    {
        private GeneratorFiles gf = new GeneratorFiles();
        static private readonly string path = AppDomain.CurrentDomain.BaseDirectory;
        static private readonly string relativePath = @"AnotherDirectory\DataBase\HospitalData";
        static private readonly string absolutePath = Path.Combine(path, relativePath);
        public RegHospitalForm()
        {
            InitializeComponent();
        }
        private void RegHospitalForm_Load(object sender, EventArgs e)
        {
            
        }
        private void RH_Button_1_Click(object sender, EventArgs e)
        {
            string RH_NameOrg = RH_TextBox_1.Text;
            string RH_AddressOrg = RH_TextBox_2.Text;
            int RH_StaffCapacity = Convert.ToInt32(RH_TextBox_3.Text);
            string RH_DescOrg = RH_TextBox_4.Text;

            if (RH_StaffCapacity < 0)
            {
                MessageBox.Show("Введено некоректное значение! Установлено значение по умолчанию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Hospital hospital = new Hospital(RH_NameOrg, RH_AddressOrg, RH_StaffCapacity, RH_DescOrg);

            gf.LoadDataJson(absolutePath,"Hospital",hospital);

            this.Close();
            MessageBox.Show(
                "Данные успешно сохранены!",
                "Готово!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
