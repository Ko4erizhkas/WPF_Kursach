using System.Text.Json;

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
            string directoryPath = UploadInfoTextBox_1.Text;
            var items = DeserializeFromDirectory(directoryPath, "*.json");
            foreach (var item in items)
            {
                UploadInfoListBox_1.Items.Add(item);
            }
        }
        private List<object> DeserializeFromDirectory(string directoryPath, string searchPattern)
        {
            List<object> items = new List<object>();
            if (Directory.Exists(directoryPath))
            {
                foreach (var filePath in Directory.GetFiles(directoryPath, searchPattern))
                {
                    try
                    {
                        string fileContent = File.ReadAllText(filePath);
                        object? deserializeItem = JsonSerializer.Deserialize<object>(fileContent);
                        if (deserializeItem != null)
                        {
                            items.Add(deserializeItem);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при обработки файла {filePath}:{ex.Message}", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Данная директория не найдена!", "Не найдено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return items;
        }
    }
}
