using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Kursach
{
    public class Doctor
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public string PhoneNumber { get; set; }
        public int ExperienceYears { get; set; }
        public bool IsProfessor { get; set; }
        public bool IsDocent { get; set; }
        public decimal Salary { get; set; }
    }
}
