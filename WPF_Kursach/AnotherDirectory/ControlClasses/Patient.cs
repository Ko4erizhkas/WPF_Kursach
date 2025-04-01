using System.Text.Json.Serialization;

namespace WPF_Kursach.AnotherDirectory.ControlClasses
{
    public class Patient : Person
    {
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
        public Patient(string _FullName, string _Surname, string _MiddleName,
                       DateOnly _DateBirth, string _Gender,
                       string _PhoneNumber, string _Email, int _Age) :
                       base(_FullName, _Surname, _MiddleName, _Age)
        {
            this.DateBirth = _DateBirth;
            this.Gender = _Gender;
            this.PhoneNumber = _PhoneNumber;
            this.Email = _Email;
        }

        //Нужно сделать десериализацию данных о CurrentDoctor в таблицу с Doctor или отдельно
        public Patient(string _FullName, string _Surname, string _MiddleName,
                       DateOnly _DateBirth, string _Gender,
                       string _PhoneNumber, string _Email, int _Age,
                       Doctor _CurrentDoctor) :
                       base(_FullName, _Surname, _MiddleName, _Age)
        {
            this.DateBirth = _DateBirth;
            this.Gender = _Gender;
            this.PhoneNumber = _PhoneNumber;
            this.Email = _Email;
            this.CurrentDoctor = _CurrentDoctor;
        }

        public Patient(string _FullName, string _Surname, string _MiddleName,
                       DateOnly _DateBirth, string _Gender,
                       string _PhoneNumber, string _Email, int _Age, string _MedHistory) :
                       base(_FullName, _Surname, _MiddleName, _Age)
        {
            this.DateBirth = _DateBirth;
            this.Gender = _Gender;
            this.PhoneNumber = _PhoneNumber;
            this.Email = _Email;
            this.MedHistory = _MedHistory;
        }
        public Patient(string _FullName, string _Surname, string _MiddleName, Doctor _CurrentDoctor) :
                       base(_FullName, _Surname, _MiddleName)
        {
            this.CurrentDoctor = _CurrentDoctor;
        }
        public Patient(string _FullName, string _Surname) : base(_FullName, _Surname) { }
        public Patient(string _FullName, string _Surname, string _MiddleName) : base(_FullName, _Surname, _MiddleName) { }
        
    }
}
