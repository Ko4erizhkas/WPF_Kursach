using System.ComponentModel;
using System.Text.Json;
using WPF_Kursach.AnotherDirectory.ControlClasses;

namespace WPF_Kursach.ActionForms
{
    public partial class UploadInfoFromJsonForm : Form
    {
        public UploadInfoFromJsonForm()
        {
            InitializeComponent();
        }

        private void UploadInfoFromJsonForm_Load(object sender, EventArgs e)
        {

        }

        private void UploadInfoButton_1_Click(object sender, EventArgs e)
        {
            GeneratorFiles gf = new GeneratorFiles();
            string directoryPath = UploadInfoTextBox_1.Text;
            string projectFolder = Application.StartupPath;

            var items = gf.UploadDataJson(directoryPath, "*.json");

            //BindingList<Doctor> data = new BindingList<Doctor>();
            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.DataSource = data;
            //dataGridView1.Refresh();

            //foreach (var item in items)
            //{
            //    data.Add((Doctor)item);
            //}
            GenerateDataGridView(dataGridView1, items);
            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }

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
            //private void UploadInfoButton_1_Click(object sender, EventArgs e)
            //{
            //    GeneratorFiles gf = new GeneratorFiles();
            //    string directoryPath = UploadInfoTextBox_1.Text;
            //    var items = gf.UploadDataJson(directoryPath, "*.json");
            //    foreach (var item in items)
            //    {
            //        UploadInfoListBox_1.Items.Add(item);
            //    }
            //}
        }
    }
}
