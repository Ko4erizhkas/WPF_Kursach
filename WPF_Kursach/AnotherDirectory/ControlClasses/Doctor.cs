using System.Text.Json.Serialization;

namespace WPF_Kursach.AnotherDirectory.ControlClasses;

public class Doctor : Employee
{
    private decimal _salary;
    [JsonPropertyName("MedArea")]
    public string MedArea { get; private set; }
    [JsonPropertyName("Salary")]
    public decimal Salary 
    {
        get { return _salary; }
        private set
        {
            if (value < 0)
            {
                _salary = 0;
            }
            else
            {
                _salary = value;
            }
        }
    }
    [JsonPropertyName("MedBranch")]
    public string MedBranch { get; private set; }
    [JsonPropertyName("MedRank")]
    public string MedRank { get; private set; }
    [JsonPropertyName("Description")]
    public string? Description { get; private set; }
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
    public Doctor(string _FullName, string _Surname, string _MiddleName,
                   string _Spec, string _Id, string _PhoneNumber,
                   string _Degree, string _Snils, string _MedArea,
                   string _MedBranch, string _MedRank, string _Description,
                   decimal _Salary) :
           base(_FullName, _Surname, _MiddleName,
                _Spec, _Id, _PhoneNumber,
                _Degree, _Snils)
    {
        this.MedArea = _MedArea;
        this.MedBranch = _MedBranch;
        this.MedRank = _MedRank;
        this.Description = _Description;
        this.Salary = _Salary;
    }
    public Doctor(string _FullName, string _Surname, string _MiddleName,
                   string _Spec, string _Id, string _PhoneNumber,
                   string _Degree, string _Snils) : 
                base (_FullName, _Surname, _MiddleName,
                _Spec, _Id, _PhoneNumber,
                _Degree, _Snils)
    {

    }
}
