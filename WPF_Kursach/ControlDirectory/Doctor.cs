using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WPF_Kursach.ControlDirectory
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

        //public bool IsProfessor { get; set; }
        //public bool IsDocent { get; set; }
        //public decimal Salary { get; set; }
        public Doctor(string _FullName, string _Surname,
                      string _Speciality, int _ExperienceYears, 
                      string _PhoneNumber, string _DateBirthS, 
                      string _Gender, string _Address, 
                      string _MedicalInstitution, uint _Age)
        : base (_FullName, _Surname, _DateBirthS, _Gender, 
                    _Address, _PhoneNumber, _MedicalInstitution, _Age)
        {
            this.Surname = _Surname;
            this.FullName = _FullName;
            this.Specialty = _Speciality;
            this.PhoneNumber = _PhoneNumber;
            this.ExperienceYears = _ExperienceYears;
        }
        public Doctor(string _FullName, string _Surname) : base (_FullName, _Surname)
        {
            this.FullName = _FullName;
            this.Surname = _Surname;
        }
        public Doctor() { }

        public string SerializeDoctor(string _FullName, string _Surname,
                      string _Speciality, int _ExperienceYears,
                      string _PhoneNumber, string _DateBirthS,
                      string _Gender, string _Address,
                      string _MedicalInstitution, uint _Age)
        {
            string jsonDataDoctor = JsonSerializer.Serialize(new Doctor (_FullName, _Surname, _Speciality, _ExperienceYears,
                                                             _PhoneNumber, _DateBirthS, _Gender, _Address, _MedicalInstitution, _Age), new JsonSerializerOptions { WriteIndented = true} );
            return jsonDataDoctor;
        }
        public string SerializeDoctor(Doctor doctor)
        {
            string jsonDataDoctor = JsonSerializer.Serialize(doctor, new JsonSerializerOptions { WriteIndented = true });
            return jsonDataDoctor;
        }
        public Doctor DeserializeDoctor(string? fileName)
        {
            if (fileName == null)
            {
                return null;
            }
            else 
            {
                Doctor DJsonDataDoctor = JsonSerializer.Deserialize<Doctor>(fileName);
                return DJsonDataDoctor;
            }   
        }
    }
    
}
