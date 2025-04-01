using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;
using WPF_Kursach.AnotherDirectory.ActionForms.RegForms;
using WPF_Kursach.AnotherDirectory.ControlClasses;

namespace WPF_Kursach.AnotherDirectory.MainForms
{
    public partial class MainFormV2 : Form
    {
        private RegDoctorForm docForm;
        private RegPatientForm patientForm;
        private RegHospitalForm hospitalForm;
        private RegPolyclinicForm polyclinicForm;

        private GeneratorFiles gf = new GeneratorFiles();

        static private readonly string path = AppDomain.CurrentDomain.BaseDirectory;
        static private readonly string relativePath = @"AnotherDirectory/DataBase";
        static private readonly string absolutePath = Path.Combine(path, relativePath);
        public MainFormV2()
        {
            InitializeComponent();
            Init();

        }

        private void MainFormV2_Load(object sender, EventArgs e)
        {

        }
        private void Init()
        {
            docForm = new RegDoctorForm();
            patientForm = new RegPatientForm();
            hospitalForm = new RegHospitalForm();
            polyclinicForm = new RegPolyclinicForm();
        }
        private void DoctorButton_Click(object sender, EventArgs e)
        {
            docForm.Show();
        }
        private void PatientButton_Click(object sender, EventArgs e)
        {
            patientForm.Show();
        }
        private void HospitalButton_Click(object sender, EventArgs e)
        {
            hospitalForm.Show();
        }
        private void PolyclinicButton_Click(object sender, EventArgs e)
        {
            polyclinicForm.Show();
        }
        private void UploadDoctorDataButton_Click(object sender, EventArgs e)
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var doctorDataPath = Path.Combine(basePath, "..", "..", "..", "WPF_Kursach", "AnotherDirectory", "DataBase", "DoctorData");
            var data = gf.UploadDataJson(doctorDataPath, "*.json");

            GenerateDataGridView(DoctorDataGridView, data);
        }

        private void LoadPatientDataButton_Click(object sender, EventArgs e)
        {
            var data = gf.UploadDataJson(Path.Combine(absolutePath, "PatientData"), "*.json");
            GenerateDataGridView(PatientDataGridView, data);
        }

        private void LoadDoctorDataButton_Click(object sender, EventArgs e)
        {
            var data = gf.UploadDataJson(Path.Combine(absolutePath, "DoctorData"), "*.json");
            GenerateDataGridView(DoctorDataGridView, data);
        }


        private void LoadHospitalDataButton_Click(object sender, EventArgs e)
        {
            var data = gf.UploadDataJson(Path.Combine(absolutePath, "HospitalData"), "*.json");
            GenerateDataGridView(HospitalDataGridView, data);
        }

        private void LoadPolyclinicDataButton_Click(object sender, EventArgs e)
        {
            var data = gf.UploadDataJson(Path.Combine(absolutePath, "PolyclinicData"), "*.json");
            GenerateDataGridView(PolyclinicDataGridView, data);
        }
        private void GenerateDataGridView(DataGridView dataGridView, List<object> items)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            if (items.Count > 0)
            {
                IDictionary<string, object> firstItemDict = null;
                if (items[0] is JsonElement jsonElement && jsonElement.ValueKind == JsonValueKind.Object)
                {
                    firstItemDict = jsonElement.EnumerateObject()
                        .ToDictionary(prop => prop.Name, prop => (object)prop.Value.ToString());
                }
                if (firstItemDict != null)
                {
                    foreach (var key in firstItemDict.Keys)
                    {
                        dataGridView.Columns.Add(key, key); // Добавляем столбец с именем ключа
                    }

                    // Заполняем строки
                    foreach (var item in items)
                    {
                        IDictionary<string, object> rowDict;

                        if (item is IDictionary<string, object> dictItem)
                        {
                            rowDict = dictItem;
                        }
                        else if (item is JsonElement je && je.ValueKind == JsonValueKind.Object)
                        {
                            rowDict = je.EnumerateObject()
                                .ToDictionary(prop => prop.Name, prop => (object)prop.Value.ToString());
                        }
                        else
                        {
                            string jsonItem = JsonSerializer.Serialize(item);
                            rowDict = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonItem);
                        }

                        var rowValues = new List<object>();
                        foreach (var key in firstItemDict.Keys)
                        {
                            rowValues.Add(rowDict.ContainsKey(key) ? rowDict[key]?.ToString() : null);
                        }
                        dataGridView.Rows.Add(rowValues.ToArray());
                    }
                }
            }
        }

        
    }
}
