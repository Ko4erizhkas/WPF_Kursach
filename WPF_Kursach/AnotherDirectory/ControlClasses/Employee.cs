namespace WPF_Kursach.AnotherDirectory.ControlClasses
{
    public class Employee : Person
    {
        public string Id { get; private set; }
        public string Specialization { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Degree { get; private set; }
        public Employee(string _FullName, string _Surname, string _MiddleName,
                        string _Spec, string _Id, string _PhoneNumber,
                        string _Degree) : base(_FullName, _Surname, _MiddleName)
        {
            this.Id = _Id;
            this.Specialization = _Spec;
            this.PhoneNumber = _PhoneNumber;
            this.Degree = _Degree;
        }
    }
}
