using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Kursach.AnotherDirectory.ControlDirectory
{
    public class Employee : Person
    {
        public string? Id { get; set; }
        public string? Specialization { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Degree { get; set; }
        public string? SNILS { get; set; }
        public Employee(string _FullName, string _Surname, string _MiddleName,
                        string _Spec, string _Id, string _PhoneNumber,
                        string _Degree, string _SNILS) : base(_FullName, _Surname, _MiddleName)
        {
            this.Id = _Id;
            this.Specialization = _Spec;
            this.PhoneNumber = _PhoneNumber;
            this.Degree = _Degree;
            this.SNILS = _SNILS;
        }
        public Employee(string _FullName, string _Surname, string _MiddleName) :
            base(_FullName, _Surname, _MiddleName) { }
    }
}
