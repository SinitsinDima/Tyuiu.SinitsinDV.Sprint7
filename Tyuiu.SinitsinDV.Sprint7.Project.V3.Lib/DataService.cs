using System.Text;

namespace Tyuiu.SinitsinDV.Sprint7.Project.V3.Lib
{
    public class DataService
    {
        public static List<int> LoadGradesFromCsv(string filePath)
        {
            var grades = new List<int>();

            try
            {
                // Открываем файл для чтения с кодировкой UTF-8
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        var columns = line.Split(';');

                        // Проверка на наличие второго столбца и преобразование в целое число
                        if (columns.Length > 1 && int.TryParse(columns[1], out int grade))
                        {
                            grades.Add(grade);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
                throw; // Генерируем исключение для обработки на уровне вызова
            }

            return grades;
        }
        public static double CalculateAverageGrade(List<int> grades)
        {
            if (grades == null || grades.Count == 0)
                throw new ArgumentException("Список оценок пуст или не задан.");

            // Подсчитываем сумму оценок
            int total = 0;
            foreach (var grade in grades)
            {
                total += grade;
            }

            // Возвращаем среднее арифметическое
            return Math.Round((double)total / grades.Count, 3);
        }
    }
}
