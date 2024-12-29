using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace WPF_Kursach.ControlDirectory
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

                var jsonContent = JsonSerializer.Serialize(fileContent, new JsonSerializerOptions
                {
                    WriteIndented = true // Читаемый формат JSON
                });
                File.WriteAllText(filePath, jsonContent);
            }
            catch (Exception ex) { }
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
