using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WPF_Kursach.AnotherDirectory.ControlDirectory
{
    public class Patient : Person
    {
        private Doctor _CurrentDoctor;

        [JsonPropertyName("Id")]
        public string? Id { get; set; } // Work in progress
        [JsonPropertyName("DataBirth")]
        public DateOnly? DateBirth { get; private set; }
        [JsonPropertyName("Gender")]
        public string? Gender { get; set; }
        [JsonPropertyName("PhoneNumber")]
        public string? PhoneNumber { get; set; }
        [JsonPropertyName("EmailAddress")]
        public string? Email { get; set; }
        [JsonPropertyName("MedicalHistory")]
        public List<string>? MedicalHistory { get; set; }
        [JsonPropertyName("CurrentDoctor")]
        public Doctor? CurrentDoctor { get; set; }
        public Patient(string _FullName, string _Surname, string _MiddleName, 
                       DateOnly _DateBirth, string _Gender, 
                       string _PhoneNumber, string _Email , uint _Age) : 
                       base(_FullName, _Surname, _MiddleName, _Age)
        {
            this.Id = GenerateUniqueId();
            this.DateBirth = _DateBirth;
            this.Gender = _Gender;
            this.PhoneNumber = _PhoneNumber;
            this.Email = _Email;
        }
        public Patient(string _FullName, string _Surname, string _MiddleName, 
                       DateOnly _DateBirth, string _Gender,
                       string _PhoneNumber, string _Email, uint _Age, 
                       Doctor _CurrentDoctor) :
                       base(_FullName, _Surname, _MiddleName, _Age)
        {
            this.Id = GenerateUniqueId();
            this.DateBirth = _DateBirth;
            this.Gender = _Gender;
            this.PhoneNumber = _PhoneNumber;
            this.Email = _Email;
            this.CurrentDoctor = _CurrentDoctor;

        }
        public Patient(string _FullName, string _Surname,string _MiddleName ,Doctor _CurrentDoctor) :
                       base(_FullName, _Surname, _MiddleName)
        {
            this.CurrentDoctor = _CurrentDoctor;
        }
        public Patient(string _FullName, string _Surname) : base(_FullName, _Surname) { }
        public Patient(string _FullName, string _Surname, string _MiddleName) : base(_FullName, _Surname, _MiddleName) { }
        private string GenerateUniqueId()
        {
            return "";
        }
    }
}
