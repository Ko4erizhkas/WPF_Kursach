using System.Security.Cryptography.X509Certificates;

namespace WPF_Kursach.AnotherDirectory.ControlClasses
{
    public class Polyclinic : Organization
    {
        public Hospital? AttachHospital { get; private set; }
        public List<Patient> Patients { get; private set; }
        public Polyclinic(string nameOrg, string addressOrg, int staffCapacity, string? descOrg, Hospital? attachHospital) :
               base(nameOrg, addressOrg, staffCapacity, descOrg)
        {
            this.AttachHospital = attachHospital;
            this.Patients = new List<Patient>();
        }
        public void AddPatient(Patient patient, List<Doctor> doctors)
        {
            if (patient == null) throw new ArgumentNullException(nameof(patient));
            if (doctors == null || doctors.Count == 0) throw new ArgumentException("Список врачей не может быть пустым!", nameof(doctors));
            foreach (var doc in doctors)
            {
                if (!StaffList.Contains(doc))
                {
                    throw new InvalidOperationException($"Врач {doc.FullName} {doc.Surname} не работает в {NameOrg}");
                }
            }
            patient.CurrentDoctors = new List<Doctor>(doctors);
            Patients.Add(patient);
#if DEBUG
            Console.WriteLine($"Пациент {patient.FullName} {patient.Surname} добавлен в {NameOrg}");
#endif
        }

        public void ReferToHospital(Patient patient, Hospital hospital)
        {
            if (patient == null) throw new ArgumentNullException(nameof(patient));
            if (hospital == null) throw new ArgumentNullException(nameof(hospital));
            if (Patients.Contains(patient))
            {
                Patients.Add(patient);
#if DEBUG
                Console.WriteLine($"Пациент {patient.FullName} {patient.Surname} направлен из {NameOrg} в {hospital.NameOrg}");
#endif
            }
        }
    }
}
