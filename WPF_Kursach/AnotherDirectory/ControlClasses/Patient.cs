using System.Text.Json.Serialization;

namespace WPF_Kursach.AnotherDirectory.ControlClasses
{
    public class Patient : Person
    {
        private Doctor _CurrentDoctor;

        [JsonPropertyName("Id")]
        public string Id { get; set; } // Work in progress
        [JsonPropertyName("DataBirth")]
        public DateOnly? DateBirth { get; set; }
        [JsonPropertyName("Gender")]
        public string Gender { get; set; }
        [JsonPropertyName("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonPropertyName("EmailAddress")]
        public string? Email { get; set; }
        [JsonPropertyName("MedicalHistory")]
        public string MedHistory { get; set; }
        [JsonPropertyName("CurrentDoctor")]
        public Doctor? CurrentDoctor { get; set; }
        public List<Doctor> CurrentDoctors { get; set; }

        public Patient(string _FullName, string _Surname, string _MiddleName,
                       DateOnly _DateBirth, string _Gender,
                       string _PhoneNumber, string _Email, int _Age) :
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
                       string _PhoneNumber, string _Email, int _Age,
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

        public Patient(string _FullName, string _Surname, string _MiddleName,
                       DateOnly _DateBirth, string _Gender,
                       string _PhoneNumber, string _Email, int _Age,
                       Doctor _CurrentDoctor, string _MedHistory) :
                       base(_FullName, _Surname, _MiddleName, _Age)
        {
            this.Id = GenerateUniqueId();
            this.DateBirth = _DateBirth;
            this.Gender = _Gender;
            this.PhoneNumber = _PhoneNumber;
            this.Email = _Email;
            this.CurrentDoctor = _CurrentDoctor;
            this.MedHistory = _MedHistory;
        }
        public Patient(string _FullName, string _Surname, string _MiddleName, Doctor _CurrentDoctor) :
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
