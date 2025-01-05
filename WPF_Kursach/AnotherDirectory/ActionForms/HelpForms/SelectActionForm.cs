using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_Kursach
{
    public partial class SelectActionForm : Form
    {
        public SelectActionForm()
        {
            InitializeComponent();   
        }
        private void AddDoctorButtom_Click(object sender, EventArgs e)
        {
            RegDoctorForm authDoctorForm = new RegDoctorForm();
            authDoctorForm.Show();
        }
        private void AddPatientButtom_Click(object sender, EventArgs e)
        {
            RegPatientForm authPatientForm = new RegPatientForm();
            authPatientForm.Show();
        }

        private void SelectAction_Load(object sender, EventArgs e)
        {
            
        }
        private void CloseButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
