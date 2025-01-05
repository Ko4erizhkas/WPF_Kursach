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
    public class Doctor : Employee
    {
        [JsonPropertyName("MedArea")]
        public string? MedArea { get; set; }
        [JsonPropertyName("Salary")]
        public decimal? Salary { get; set; }
        [JsonPropertyName("MedBranch")]
        public string? MedBranch { get; set; }
        [JsonPropertyName("Description")]
        public string? Description { get; set; }
        public Doctor(string _FullName, string _Surname, string _MiddleName,
                      string _Spec, string _Id, string _PhoneNumber, 
                      string _Degree, string _Snils, string _MegArea,
                      string _MedBranch, string _Description, decimal _Salary) :
               base(_FullName, _Surname, _MiddleName, 
                    _Spec, _Id, _PhoneNumber,
                    _Degree, _Snils)
        {
            this.MedArea = _MegArea;
            this.MedBranch = _MedBranch;
            this.Description = _Description;
            this.Salary = _Salary;
        }
        public Doctor(string _FullName, string _Surname, string _MiddleName) : 
               base(_FullName, _Surname, _MiddleName) { }
    }
}
