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
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var columns = line.Split(';');
                        if (columns.Length > 1 && int.TryParse(columns[1], out int grade)) // Предполагается, что оценки во втором столбце
                        {
                            grades.Add(grade);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при чтении файла: " + ex.Message);
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
