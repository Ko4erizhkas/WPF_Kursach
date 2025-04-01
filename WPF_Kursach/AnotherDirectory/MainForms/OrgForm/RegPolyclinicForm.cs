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
    public partial class RegPolyclinicForm : Form
    {
        private GeneratorFiles gf = new GeneratorFiles();
        static private readonly string path = AppDomain.CurrentDomain.BaseDirectory;
        static private readonly string relativePath = @"AnotherDirectory\DataBase\PolyclinicData";
        static private readonly string absolutePath = Path.Combine(path, relativePath);
        public RegPolyclinicForm()
        {
            InitializeComponent();
        }

        private void RegPolyclinicForm_Load(object sender, EventArgs e)
        {

        }

        private void RP_Button_1_Click(object sender, EventArgs e)
        {
            string RP_NameOrg = RP_TextBox_1.Text;
            string RP_AddressOrg = RP_TextBox_2.Text;
            int RP_StaffCapacity = Convert.ToInt32(RP_TextBox_3.Text);
            string RP_DescOrg = RP_TextBox_4.Text;

            if (RP_StaffCapacity < 0)
            {
                MessageBox.Show("Введено некоректное значение! Установлено значение по умолчанию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Polyclinic polyclinic = new Polyclinic(RP_NameOrg, RP_AddressOrg, RP_StaffCapacity, RP_DescOrg, null);

            gf.LoadDataJson(absolutePath, "Polyclinic", polyclinic);

            this.Close();
            MessageBox.Show(
                "Данные успешно сохранены!",
                "Готово!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
