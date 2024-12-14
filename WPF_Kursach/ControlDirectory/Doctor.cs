using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Kursach.ControlDirectory
{
    public class Doctor
    {
        private int _ExpYears;
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Surname { get; set; } // Фамилия
        public string Specialty { get; set; }
        public string PhoneNumber { get; set; }
        public int ExperienceYears
        {
            get 
            {
                return _ExpYears;
            }
            set 
            {
                if (value <= 0)
                {
                    _ExpYears = 0;
                    throw new ArgumentOutOfRangeException("Negative Value or Zero");
                }
                else
                {
                    _ExpYears = value;
                }
            }
        }
        //public bool IsProfessor { get; set; }
        //public bool IsDocent { get; set; }
        //public decimal Salary { get; set; }
        public Doctor(string _Surname, string _FullName, 
                      string _Speciality, int _ExperienceYears, 
                      string _PhoneNumber) 
        {
            this.Surname = _Surname;
            this.FullName = _FullName;
            this.Specialty = _Speciality;
            this.PhoneNumber = _PhoneNumber;
            this.ExperienceYears = _ExperienceYears;
        }
    }
    
}
