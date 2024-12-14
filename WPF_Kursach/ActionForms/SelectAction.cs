using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_Kursach
{
    public partial class SelectAction : Form
    {
        public SelectAction()
        {
            InitializeComponent();
        }
        private void AddDoctorButtom_Click(object sender, EventArgs e)
        {
            AuthDoctorForm authDoctorForm = new AuthDoctorForm();
            authDoctorForm.Show();
        }
        private void AddPatientButtom_Click(object sender, EventArgs e)
        {
            AuthPatientForm authPatientForm = new AuthPatientForm();
            authPatientForm.Show();
        }

        private void SelectAction_Load(object sender, EventArgs e)
        {

        }

    }
}
