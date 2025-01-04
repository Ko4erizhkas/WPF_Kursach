using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace WPF_Kursach.AnotherDirectory.ControlDirectory
{
    public class GeneratorFiles
    {
        public void GenerateFile(string directoryPath, string fileName, object fileContent)
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
    }
}
