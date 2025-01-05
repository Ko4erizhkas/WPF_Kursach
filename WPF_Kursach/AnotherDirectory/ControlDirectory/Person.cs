using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WPF_Kursach.AnotherDirectory.ControlDirectory
{
    public class Person
    {
        private uint? _Age;
        [JsonPropertyName("FullName")]
        public string? FullName { get; set; }
        [JsonPropertyName("Surname")]
        public string? Surname { get; set; }
        [JsonPropertyName("MiddleName")]
        public string? MiddleName { get; set; } // Отчество
        [JsonPropertyName("Years")]
        public uint? Age
        {
            get { return _Age; }

            set
            {
                if (value <= 0)
                {
                    _Age = 0;
                    throw new ArgumentException("Zero or Negative Argument");
                }
                else
                {
                    value = _Age;
                }
            }
        }
        public Person(string _FullName, string _Surname, string _MiddleName, uint _Age)
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
