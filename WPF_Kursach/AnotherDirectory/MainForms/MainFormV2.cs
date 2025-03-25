using WPF_Kursach.AnotherDirectory.ActionForms.RegForms;
using WPF_Kursach.AnotherDirectory.ControlClasses;

namespace WPF_Kursach.AnotherDirectory.MainForms
{
    public partial class MainFormV2 : Form
    {
        private RegDoctorForm docForm;
        private RegPatientForm patientForm;
        private RegHospitalForm hospitalForm;
        private RegPolyclinicForm polyclinicForm;

        private List<Hospital> hospitals = new List<Hospital>();
        private List<Polyclinic> polyclinics = new List<Polyclinic>();


        public MainFormV2()
        {
            InitializeComponents();
        }
        private void InitializeComponents()
        {
            Width = 1280;
            Height = 720;
            docForm = new RegDoctorForm();
            patientForm = new RegPatientForm();
            hospitalForm = new RegHospitalForm();
            polyclinicForm = new RegPolyclinicForm();
        }
        private void AddPatient()
        {
            string P_FullName, P_Surname, P_Email, P_PhoneNumber, P_Gender;
            string? P_MiddleName, P_Desc;
            int P_Age;
            
        }
    }
}
