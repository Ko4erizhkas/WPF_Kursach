using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_Kursach.Polyclinic
{
    public partial class Polyclinic_RegPatient : Form
    {
        public Polyclinic_RegPatient()
        {
            InitializeComponent();
        }

        private void Polyclinic_AddPatient_Click(object sender, EventArgs e)
        {
            RegPatientForm regPatient = new RegPatientForm();
            regPatient.Show();
        }
    }
}
