using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WPF_Kursach.ControlDirectory
{
    public class Doctor
    {
        private int _ExpYears;
        public string? Id { get; set; }

        [JsonPropertyName("FullName")]
        public string? FullName { get; set; }

        [JsonPropertyName("Surname")]
        public string? Surname { get; set; } // Фамилия

        [JsonPropertyName("Specialty")]
        public string? Specialty { get; set; }

        [JsonPropertyName("PhoneNumber")]
        public string? PhoneNumber { get; set; }

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
        public Doctor() { }
        public string SerializeDoctor(string _Surname, string _FullName,
                      string _Speciality, int _ExperienceYears,
                      string _PhoneNumber)
        {
            string jsonDataDoctor = JsonSerializer.Serialize<Doctor>(new Doctor (_Surname, _FullName, _Speciality, _ExperienceYears, _PhoneNumber));
            return jsonDataDoctor;
        }
        public string SerializeDoctor(Doctor doctor)
        {
            string jsonDataDoctor = JsonSerializer.Serialize<Doctor>(doctor);
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
        public void Main_Doctor()
        {
            Doctor d = new Doctor
            {
                FullName = "asd",
                Surname = "shadg",
                Specialty = " sidghla",
                ExperienceYears = 123,
                PhoneNumber = "125681364"
            };
            string dop = SerializeDoctor(d);
            var es = DeserializeDoctor(dop);
        }
    }
    
}
