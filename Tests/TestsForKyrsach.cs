using Newtonsoft.Json.Bson;
using System.Web;
using WPF_Kursach.AnotherDirectory.ControlClasses;

namespace Tests
{
    [TestClass]
    public class PatientTestClass
    {
        [TestMethod]
        public void Patient_TestConstructor_1()
        {
            string _FullName = "asdfsaf";
            string _Surname = "dasfag";
            Patient patient = new Patient(_FullName, _Surname);
            Assert.AreEqual(_FullName, patient.FullName);
            Assert.AreEqual(_Surname, patient.Surname);
        }
        [TestMethod]
        public void Patient_TestConstructor_2()
        {
            string _FullName = "asdfsaf";
            string _Surname = "dasfag";
            string _MiddleName = "sdgasdg";
            Patient patient = new Patient( _FullName, _Surname, _MiddleName);
            Assert.AreEqual(_FullName, patient.FullName);
            Assert.AreEqual(_Surname, patient.Surname);
            Assert.AreEqual(_MiddleName, patient.MiddleName);
        }
        [TestMethod]
        public void Patient_TestConstructor_3()
        {
            string P_FullName = "sdhglisag";
            string P_Surname = "P_SurnameTextBox_1.Text";
            string P_MiddleName = "P_MiddleNameTextBox_1.Text";
            string P_PhoneNumber = "P_PhoneNumberTextBox_1.Text";
            string P_EmailAddress = "P_EmailTextBox1.Text";
            string P_Gender = "Ezhik";
            int P_Age = 123;
            DateOnly P_DateBirth = new DateOnly(1223,12,12);
            Patient patient = new Patient(P_FullName, P_Surname, P_MiddleName,
                                          P_DateBirth, P_Gender, P_PhoneNumber, 
                                          P_EmailAddress, P_Age);
            Assert.AreEqual(P_FullName, patient.FullName);
            Assert.AreEqual(P_Surname, patient.Surname);
            Assert.AreEqual(P_MiddleName, patient.MiddleName);
            Assert.AreEqual(P_PhoneNumber, patient.PhoneNumber);
            Assert.AreEqual(P_Age, patient.Age);
            Assert.AreEqual(P_Gender, patient.Gender);
            Assert.AreEqual(P_EmailAddress, patient.Email);
            Assert.AreEqual(P_DateBirth, patient.DateBirth);
        }
        [TestMethod]
        public void Patient_TestConstructor_4()
        {
            string P_FullName = "sdhglisag";
            string P_Surname = "P_SurnameTextBox_1.Text";
            string P_MiddleName = "P_MiddleNameTextBox_1.Text";
            string P_PhoneNumber = "P_PhoneNumberTextBox_1.Text";
            string P_EmailAddress = "P_EmailTextBox1.Text";
            string P_Gender = "Ezhik";
            int P_Age = 123;
            DateOnly P_DateBirth = new DateOnly(1223, 12, 12);
            Doctor P_Doctor = new Doctor("asd","asdasd","sdfgas",null,null,null,null);
            Patient patient = new Patient(P_FullName, P_Surname, P_MiddleName,
                                          P_DateBirth, P_Gender, P_PhoneNumber,
                                          P_EmailAddress, P_Age);
            Assert.AreEqual(P_FullName, patient.FullName);
            Assert.AreEqual(P_Surname, patient.Surname);
            Assert.AreEqual(P_MiddleName, patient.MiddleName);
            Assert.AreEqual(P_PhoneNumber, patient.PhoneNumber);
            Assert.AreEqual(P_Age, patient.Age);
            Assert.AreEqual(P_Gender, patient.Gender);
            Assert.AreEqual(P_EmailAddress, patient.Email);
            Assert.AreEqual(P_DateBirth, patient.DateBirth);
        }
        [TestMethod]
        public void Patient_TestConstructor_5()
        {
            string P_FullName = "sdhglisag";
            string P_Surname = "P_SurnameTextBox_1.Text";
            string P_MiddleName = "P_MiddleNameTextBox_1.Text";
            string P_PhoneNumber = "P_PhoneNumberTextBox_1.Text";
            string P_EmailAddress = "P_EmailTextBox1.Text";
            string P_Gender = "Ezhik";
            string P_MedHistory = "¬здохнул и пЄрнул. —ъел 3 тонны оливье и осталс€ жив с божьей помощью";
            int P_Age = 123;
            DateOnly P_DateBirth = new DateOnly(1223, 12, 12);
            Doctor P_Doctor = new Doctor("asd", "asdasd", "sdfgas", null, null, null, null);
            Patient patient = new Patient(P_FullName, P_Surname, P_MiddleName,
                                          P_DateBirth, P_Gender, P_PhoneNumber,
                                          P_EmailAddress, P_Age, P_MedHistory);
            Assert.AreEqual(P_FullName, patient.FullName);
            Assert.AreEqual(P_Surname, patient.Surname);
            Assert.AreEqual(P_MiddleName, patient.MiddleName);
            Assert.AreEqual(P_PhoneNumber, patient.PhoneNumber);
            Assert.AreEqual(P_Age, patient.Age);
            Assert.AreEqual(P_Gender, patient.Gender);
            Assert.AreEqual(P_EmailAddress, patient.Email);
            Assert.AreEqual(P_DateBirth, patient.DateBirth);
            Assert.AreEqual(P_MedHistory, patient.MedHistory);
        }
        [TestMethod]
        public void Patient_TestConstructor_7_NegativeAge_SetZeroAge()
        {
            string P_FullName = "sdhglisag";
            string P_Surname = "P_SurnameTextBox_1.Text";
            string P_MiddleName = "P_MiddleNameTextBox_1.Text";
            string P_PhoneNumber = "P_PhoneNumberTextBox_1.Text";
            string P_EmailAddress = "P_EmailTextBox1.Text";
            string P_Gender = "Ezhik";
            int P_Age = -123;
            DateOnly P_DateBirth = new DateOnly(1223, 12, 12);
            Patient patient = new Patient(P_FullName, P_Surname, P_MiddleName,
                                          P_DateBirth, P_Gender, P_PhoneNumber,
                                          P_EmailAddress, P_Age);
            Assert.AreEqual(P_FullName, patient.FullName);
            Assert.AreEqual(P_Surname, patient.Surname);
            Assert.AreEqual(P_MiddleName, patient.MiddleName);
            Assert.AreEqual(P_PhoneNumber, patient.PhoneNumber);
            Assert.AreEqual(0, patient.Age);
            Assert.AreEqual(P_Gender, patient.Gender);
            Assert.AreEqual(P_EmailAddress, patient.Email);
            Assert.AreEqual(P_DateBirth, patient.DateBirth);
        }
        //[TestMethod]
        //public void Patient_TestConstructor_6()
        //{
        //    string P_FullName = "sdhglisag";
        //    string P_Surname = "P_SurnameTextBox_1.Text";
        //    string P_MiddleName = "P_MiddleNameTextBox_1.Text";
        //    string P_MedHistory = "¬здохнул и пЄрнул. —ъел 3 тонны оливье и осталс€ жив с божьей помощью";
        //    Doctor P_Doctor = new Doctor("asd", "asdasd", "sdfgas");
        //    Patient patient = new Patient(P_FullName, P_Surname, P_MiddleName, P_Doctor);
        //    Assert.AreEqual(P_FullName, patient.FullName);
        //    Assert.AreEqual(P_Surname, patient.Surname);
        //    Assert.AreEqual(P_MiddleName, patient.MiddleName);
        //    Assert.AreEqual(P_Doctor, patient.CurrentDoctor);
        //    Assert.AreEqual(P_MedHistory, patient.MedHistory);
        //}
    }
    [TestClass]
    public class DoctorTestClass
    {
        [TestMethod]
        public void Doctor_TestConstructor_1()
        {
            string D_FullName = "adsafda";
            string D_Surname = "fsjdghlkd";
            string D_MiddleName = "shfjlgkdsa";
            string D_Spec = "sdfhlgdshfg";
            string D_Id = "dfjkh";
            string D_PhoneNumber = "1234567890";
            string D_Degree = "dfjslkhg";
            string D_MedArea = "dsahksldf123";
            string D_MedBranch = "shglksg12342321";
            string D_Desc = "dsfhlgkjsdhflkjsdfgbn askjlfndhbglsdbf ahslnvdyg shgdilh vniasd hgaois";
            decimal D_Salary = 3169453.213M;
            Doctor doctor = new Doctor(D_FullName, D_Surname, D_MiddleName, 
                                       D_Spec, D_Id, D_PhoneNumber, 
                                       D_Degree, D_MedArea,
                                       D_MedBranch, D_Desc, D_Salary);
            Assert.AreEqual(D_FullName, doctor.FullName);
            Assert.AreEqual(D_Surname, doctor.Surname);
            Assert.AreEqual(D_MiddleName, doctor.MiddleName);
            Assert.AreEqual(D_Spec, doctor.Specialization);
            Assert.AreEqual(D_Id, doctor.Id);
            Assert.AreEqual(D_PhoneNumber, doctor.PhoneNumber);
            Assert.AreEqual(D_Degree, doctor.Degree);
            Assert.AreEqual(D_MedArea, doctor.MedArea);
            Assert.AreEqual(D_MedBranch, doctor.MedBranch);
            Assert.AreEqual(D_Desc, doctor.Description);
            Assert.AreEqual(D_Salary, doctor.Salary);
        }
        [DataTestMethod]
        [DataRow(123.0,123.0)]
        [DataRow(-123.0,0)]
        [DataRow(123123.21846, 123123.21846)]
        [DataRow(-25765.218376, 0)]
        public void Doctor_TestConstructor_2(double a, double expected)
        {
            string D_FullName = "adsafda";
            string D_Surname = "fsjdghlkd";
            string D_MiddleName = "shfjlgkdsa";
            string D_Spec = "sdfhlgdshfg";
            string D_Id = "dfjkh";
            string D_PhoneNumber = "1234567890";
            string D_Degree = "dfjslkhg";
            string D_MedArea = "dsahksldf123";
            string D_MedBranch = "shglksg12342321";
            string D_Desc = "да. там? ужас. вообще! ывпфып slkfjhlkgsfjhg S M;js s;ofghsduhfsd iPG PIHDSIUGPF pSDHg s DgpisDhg isdg nsdpS DG sdDGhSDfogh madofuh ilgadhf glidbfhligh sdbglsiaf pidafh gpdfiabg";
            string D_MedRank = "sadgkh1235215";
            decimal D_Salary = (decimal)a;
            Doctor doctor = new Doctor(D_FullName, D_Surname, D_MiddleName,
                                       D_Spec, D_Id, D_PhoneNumber,
                                       D_Degree, D_MedArea,
                                       D_MedBranch, D_MedRank,D_Desc, D_Salary);
            Assert.AreEqual(D_FullName, doctor.FullName);
            Assert.AreEqual(D_Surname, doctor.Surname);
            Assert.AreEqual(D_MiddleName, doctor.MiddleName);
            Assert.AreEqual(D_Spec, doctor.Specialization);
            Assert.AreEqual(D_Id, doctor.Id);
            Assert.AreEqual(D_PhoneNumber, doctor.PhoneNumber);
            Assert.AreEqual(D_Degree, doctor.Degree);
            Assert.AreEqual(D_MedArea, doctor.MedArea);
            Assert.AreEqual(D_MedBranch, doctor.MedBranch);
            Assert.AreEqual(D_MedRank, doctor.MedRank);
            Assert.AreEqual(D_Desc, doctor.Description);
            Assert.AreEqual((decimal)expected, doctor.Salary);
        }
    }
}