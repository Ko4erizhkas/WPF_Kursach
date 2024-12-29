using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WPF_Kursach.ControlDirectory
{
    public class Patient
    {
        private uint _Years;
        private Doctor _CurrentDoctor;
        private DateTime _dateBirth;
        [JsonPropertyName("Id")]
        public string? Id { get; set; } // Идентификатор
        [JsonPropertyName("FullName")]
        public string? FullName { get; set; } // Полное имя
        [JsonPropertyName("Surname")]
        public string Surname { get; set; } // Фамилия
        [JsonPropertyName("DataBirth")]
        public DateOnly DateBirth{ get; private set; } // Дата рождения
        [JsonPropertyName("Gender")]
        public string? Gender { get; set; }
        [JsonPropertyName("Address")]
        public string? Address { get; set; } // Адрес проживания
        [JsonPropertyName("PhoneNumber")]
        public string? PhoneNumber { get; set; } // Номер телефона
        [JsonPropertyName("MedicalInstitution")]
        public string? MedicalInstitution { get; set; } // Название больницы или поликлиники
        [JsonPropertyName("Years")]
        public uint Years 
        {
            get { return _Years; }

            set 
            {
                if (value <= 0)
                {
                    _Years = 0;
                    throw new ArgumentException("Zero or Negative Argument");
                }
                else
                {
                    value = _Years;
                }
            }
        }

        // Лечащий врач. Нужно сделать ввод только имени и фамилии, а не всей информации о докторе!!!!
        public Doctor CurrentDoctor 
        {
            get { return _CurrentDoctor; }
            set { }
        } 
        public Patient(string _FullName, string _Surname, string _DateBirthS,
                       string _Gender, string _Adress, string _PhoneNumber,
                       string _MedicalInstitution, uint _Years)
        {
            this.FullName = _FullName;
            this.Surname = _Surname;
            this.DateBirth = CheckAndParseDate(_DateBirthS);
            this.Gender = _Gender;
            this.Address = _Adress;
            this.PhoneNumber = _PhoneNumber;
            this.MedicalInstitution = _MedicalInstitution;
            this.Years = _Years;
        }
        public Patient(string _FullName, string _Surname)
        {
            this.FullName = _FullName;
            this.Surname = _Surname;
        }
        public Patient() { }
        private DateOnly CheckAndParseDate(string dateString)
        {
            if (DateOnly.TryParseExact(dateString,
                                       "dd.MM.yyyy",
                                       CultureInfo.InvariantCulture,
                                       DateTimeStyles.None,
                                       out var parsedDate))
            {
                return parsedDate;
            }
            throw new ArgumentException("Неверный формат даты. Используйте формат dd.MM.yyyy");
        }
        public string SerializePatient(string _FullName, string _Surname, string _DateBirthS,
                                       string _Gender, string _Adress, string _PhoneNumber,
                                       string _MedicalInstitution, uint _Years)
        {
            string jsonPatientData = JsonSerializer.Serialize(
                                      new Patient(_FullName, _Surname, _DateBirthS,
                                      _Gender, _Adress, _PhoneNumber,
                                      _MedicalInstitution, _Years));
            return jsonPatientData;
        }
        public string SerializePatient(Patient patient)
        {
            string jsonPatientData = JsonSerializer.Serialize(patient);
            return jsonPatientData;
        }
        public Patient DeserializePatient(string? fileName)
        {
            if (fileName == null)
            {
                return null!;
            }
            else 
            {
                Patient DJsonDataPatient = JsonSerializer.Deserialize<Patient>(fileName);
                return DJsonDataPatient;
            }
            
        }
    }

}
