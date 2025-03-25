using System.Text.Json.Serialization;

namespace WPF_Kursach.AnotherDirectory.ControlClasses
{
    public abstract class Person
    {
        private int _Age;
        [JsonPropertyName("FullName")]
        public string FullName { get; private set; }
        [JsonPropertyName("Surname")]
        public string Surname { get; private set; }
        [JsonPropertyName("MiddleName")]
        public string? MiddleName { get; private set; } // Отчество
        [JsonPropertyName("Years")]
        public int Age
        {
            get { return _Age; }

            set
            {
                if (value < 0)
                {
                    _Age = 0;
                }
                else
                {
                    _Age = value;
                }
            }
        }
        public Person(string _FullName, string _Surname, string _MiddleName, int _Age)
        {
            this.FullName = _FullName;
            this.Surname = _Surname;
            this.MiddleName = _MiddleName;
            this.Age = _Age;
        }
        public Person(string _FullName, string _Surname)
        {
            this.FullName = _FullName;
            this.Surname = _Surname;
        }
        public Person(string _FullName, string _Surname, string _MiddleName)
        {
            this.FullName = _FullName;
            this.Surname = _Surname;
            this.MiddleName = _MiddleName;
        }
    }
}
