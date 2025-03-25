namespace WPF_Kursach.AnotherDirectory.ControlClasses;

public class Hospital : Organization
{

    public List<Building> Buildings { get; private set; }
    public List<Patient> Patients { get; private set; }
    public Hospital(string nameOrg, string addressOrg, int staffCapacity, string? descOrg)
        : base(nameOrg, addressOrg, staffCapacity,descOrg)
    {
        Buildings = new List<Building>();
        Patients = new List<Patient>();
    }
    public void AddBuilding(Building building)
    {
        Buildings.Add(building);
#if DEBUG
        Console.WriteLine($"Корпус {building.Number} добавлен в {NameOrg}");
#endif
    }
    public void AddPatient(Patient patient, Doctor doctor)
    {
        if (patient == null) throw new ArgumentNullException(nameof(patient));
        if (doctor == null) throw new ArgumentNullException(nameof(doctor));
        if (!StaffList.Contains(doctor))
        {
            throw new InvalidOperationException($"Врач {doctor.FullName} {doctor.Surname} не работает в {NameOrg}");
        }
        patient.CurrentDoctor = doctor;
        Patients.Add(patient);
#if DEBUG
        Console.WriteLine($"Пациент {patient.FullName} {patient.Surname} добавлен в {NameOrg}");
#endif
    }
    public int GetTotalBeds()
    {
        int totalBeds = 0;
        foreach (var builds in Buildings)
        {
            foreach (var dept in builds.Departments)
            {
                totalBeds += dept.BedsCount;
            }
        }
        return totalBeds;
    }
}

