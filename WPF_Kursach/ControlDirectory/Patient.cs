using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Kursach.ControlDirectory
{
    public class Patient
    {
        public string Id { get; set; } // Идентификатор
        public string FullName { get; set; } // Полное имя
        public string Surname { get; set; } // Фамилия
        public DateTime DateBirth { get; set; } // Дата рождения
        public string Gender { get; set; } 
        public string Address { get; set; } // Адрес проживания
        public string PhoneNumber { get; set; } // Номер телефона
        public string MedicalInstitution { get; set; } // Название больницы или поликлиники
        public Doctor CurrentDoctor { get; set; } // Лечащий врач
    }
}
