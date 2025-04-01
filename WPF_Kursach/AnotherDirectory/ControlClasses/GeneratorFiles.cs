using System.Text.Json;
namespace WPF_Kursach.AnotherDirectory.ControlClasses
{
    public class GeneratorFiles
    {
        //Serialize Data
        public void LoadDataJson(string directoryPath, string fileName, dynamic fileContent)
        {
            try
            {
                Directory.CreateDirectory(directoryPath);

                string uniqueFileName = GenerateUniqueName(directoryPath, fileName, "json");

                string filePath = Path.Combine(directoryPath, uniqueFileName);
                var JsonFormater = new JsonSerializerOptions
                {
                    // Читаемый формат JSON
                    WriteIndented = true,

                    // Сохраняет кодировку текста в "читабильном" виде
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                var jsonContent = JsonSerializer.Serialize(fileContent, JsonFormater);
                File.WriteAllText(filePath, jsonContent);
            }
            catch (Exception ex)
            {
                throw new Exception($"Не удалось создать файл: {fileName} \n Ошибка: {ex}");
            }
        }
        public string GenerateUniqueName(string directoryPath, string baseName, string extension)
        {
            int counter = 0;
            string fileName;
            do
            {
                // Формируем имя файла: Text1.txt, Text2.txt и т.д.
                fileName = $"{baseName}{counter}.{extension}";
                counter++;
            }
            while (File.Exists(Path.Combine(directoryPath, fileName)));

            return fileName;
        }
        //Deserialize From Directory
        public List<object> UploadDataJson (string directoryPath, string searchPattern)
        {
            List<object> items = new List<object>();
            if (Directory.Exists(directoryPath))
            {
                foreach (var filePath in Directory.GetFiles(directoryPath, searchPattern))
                {
                    try
                    {
                        string fileContent = File.ReadAllText(filePath);
                        object deserializeItem = JsonSerializer.Deserialize<object>(fileContent);
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
