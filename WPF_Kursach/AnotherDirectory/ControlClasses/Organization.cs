using System.Text.Json.Serialization;

namespace WPF_Kursach.AnotherDirectory.ControlClasses
{
    public abstract class Organization
    {
        public List<Employee> StaffList { get; set; }

        private int Capacity;

        [JsonPropertyName("NameOrg")]
        public string NameOrg { get; private set; }
        [JsonPropertyName("AddressOrg")]
        public string AddressOrg { get; private set; }
        [JsonPropertyName("DescriptionOrg")]
        public string? DescriptionOrg { get; private set; }
        [JsonPropertyName("StaffCapacity")]
        public int StaffCapacity
        {
            get { return Capacity; }
            set
            {
                if (value < 0) { throw new ArgumentException("Вместимость персонала не может быть отрицательной!"); }
                else { Capacity = value; }
            }
        }
        public int CurrentStaffCount => StaffList.Count;
        public Organization(string nameOrg, string addressOrg, int staffCapacity, string? descOrg)
        {
            this.NameOrg = nameOrg;
            this.AddressOrg = addressOrg;
            this.StaffCapacity = staffCapacity;
            this.DescriptionOrg = descOrg;
            this.StaffList = new List<Employee>();
        }
        public virtual void AddStaff(Employee employee)
        {
            if (StaffList.Count < StaffCapacity && !StaffList.Contains(employee))
            {
                StaffList.Add(employee);
            }
            else if (StaffList.Count >= StaffCapacity)
            {
                throw new ArgumentOutOfRangeException
                ($"Нельзя добавить сотрудника" +
                 $"{employee.FullName} {employee.Surname}:" +
                 $"превышена максимальная вместимость персонала ({StaffCapacity})");
            }
#if DEBUG
            if (StaffList.Contains(employee))
            {
                Console.WriteLine($"Сотрудник {employee.FullName} {employee.Surname} уже существует в {NameOrg}");
            }
#endif
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee), "Сотрудник не может быть null!");
            }
            if (StaffList.Count < StaffCapacity)
            {
                StaffList.Add(employee);
#if DEBUG
                Console.WriteLine($"Сотрудник {employee.FullName} {employee.Surname} добавлен в {NameOrg}");
#endif
            }
        }
        public virtual void RemoveStaff(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee), "Сотрудник не может быть null!");
            }
            if (StaffList.Contains(employee))
            {
                StaffList.Remove(employee);
#if DEBUG
                Console.WriteLine($"Сотрудник {employee.FullName} {employee.Surname} удалён из {NameOrg}");
#endif
            }
            else
            {
                throw new ArgumentException
                ($"Невозможно найти или отсутствует сотрудник " +
                $"{employee.FullName} " +
                $"{employee.Surname} " +
                $"в списке персонала!");
            }
        }
        public override string ToString()
        {
            return $"{NameOrg} ({AddressOrg})" +
                   $"\n Вместимость - {StaffCapacity}," +
                   $"\n Количество персонала - {CurrentStaffCount}";
        }
    }
}
