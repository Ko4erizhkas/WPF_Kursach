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
        public string Specialization { get; set; }
        
        public Employee(string _FullName, string _Surname, string _Spec) : base(_FullName, _Surname)
        {
            this.Specialization = _Spec;
        }
    }
}
