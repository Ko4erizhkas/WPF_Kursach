using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WPF_Kursach.AnotherDirectory.ControlDirectory
{
    public class Doctor : Patient
    {
        private int _ExpYears;
        [JsonPropertyName("Specialty")]
        public string? Specialty { get; set; }
        [JsonPropertyName("ExperienceYears")]
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
        [JsonPropertyName("Salary")]
        public decimal Salary { get; set; }
        public Doctor(string _FullName, string _Surname, string _MiddleName, 
                      string _Speciality, int _ExperienceYears,
                      string _PhoneNumber, DateTime _DateBirth,
                      string _Gender, string _Address,
                      string _EmailAddress, uint _Age)
        : base(_FullName, _Surname, _MiddleName, _DateBirth, _Gender,
              _PhoneNumber, _EmailAddress, _Age)
        {
            this.Specialty = _Speciality;
            this.ExperienceYears = _ExperienceYears;
        }
        public Doctor(string _FullName, string _Surname, string _MiddleName,
                      string _Speciality, int _ExperienceYears,
                      string _PhoneNumber, DateTime _DateBirth,
                      string _Gender, string _Address,
                      string _EmailAddress, uint _Age, decimal _Salary)
        : base(_FullName, _Surname, _MiddleName, _DateBirth, _Gender,
              _PhoneNumber, _EmailAddress, _Age)
        {
            this.Specialty = _Speciality;
            this.ExperienceYears = _ExperienceYears;
            this.Salary = _Salary;
        }
        public Doctor(string _FullName, string _Surname, string _MiddleName) : base(_FullName, _Surname, _MiddleName) { }
    }
}
