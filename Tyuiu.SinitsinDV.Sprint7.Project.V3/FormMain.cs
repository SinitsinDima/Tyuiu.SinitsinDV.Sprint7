using Tyuiu.SinitsinDV.Sprint7.Project.V3.Lib;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.SinitsinDV.Sprint7.Project.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SetupChart();

        }
        DataService ds = new DataService();
        private void SetupChart()
        {
            // Настройка Chart для графика
            chartGrade_SDV.ChartAreas.Add(new ChartArea("MainArea")); //Добавление области для графика
            chartGrade_SDV.Legends.Add(new Legend("GradesLegend")); //Значение данных
            chartGrade_SDV.Series.Add(new Series("Оценки")
            {
                ChartType = SeriesChartType.Column, //Столбачатая диаграмма
                XValueType = ChartValueType.Int32 // Тип данных по x (целые числа)
            });
        }

        private void buttonOpenFile_SDV_Click(object sender, EventArgs e)
        {
            // Открываем диалог для выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"; //Расширение файла
            openFileDialog.Title = "Выберите файл для загрузки";

            if (openFileDialog.ShowDialog() == DialogResult.OK) // Если пользователь выбрал файл, то можно нажать ок
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Открываем файл для чтения
                    using (var reader = new StreamReader(filePath, Encoding.UTF8))
                    {
                        // Читаем все строки из файла
                        var lines = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            lines.Add(reader.ReadLine());
                        }

                        // Если файл не пустой
                        if (lines.Count > 0)
                        {

                            // Добавляем остальные строки как данные в DataGridView
                            for (int i = 0; i < lines.Count; i++)
                            {
                                var row = lines[i].Split(';');

                                // Добавляем каждое значение как отдельную ячейку
                                dataGridViewStudents_SDV.Rows.Add(row);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке файла: " + ex.Message);
                }
            }
        }

        private void buttonSaveFile_SDV_Click(object sender, EventArgs e)
        {
            // Открываем диалог для выбора места и имени файла
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Сохранить данные в файл"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK) // Если пользователь выбрал файл, то можно нажать ок
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Создаем файл для записи
                    using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                    {
                        // Записываем данные строк из DataGridView, начиная с первой строки (без заголовков)
                        foreach (DataGridViewRow row in dataGridViewStudents_SDV.Rows)
                        {
                            // Пропускаем пустую строку для добавления новых данных
                            if (row.IsNewRow) continue;

                            var cellValues = row.Cells.Cast<DataGridViewCell>() // Извлекаются значения ячеек строки
                                                      .Select(cell => cell.Value?.ToString() ?? string.Empty); // Каждое значение ячейки преобразуется в строку
                            writer.WriteLine(string.Join(";", cellValues)); // Все значения строки объединяются в одну строку через разделитель
                        }
                    }

                    MessageBox.Show("Данные успешно сохранены в файл.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
                }
            }
        }

        // Очистка данных из DataGridView
        private void toolStripButtonClean_SDV_Click(object sender, EventArgs e)
        {
            dataGridViewStudents_SDV.Rows.Clear();
            for (int i = 1; i < dataGridViewStudents_SDV.Rows.Count; i++)
            {
                dataGridViewStudents_SDV.Columns.Clear();
            }
        }

        // Построение графика на основе оценок
        private void buttonGrade_SDV_Click(object sender, EventArgs e)
        {
            // Получаем данные из второго столбца DataGridView
            var grades = GetGradesFromDataGridView();

            // Подсчет количества каждой оценки
            var gradeCounts = Enumerable.Range(1, 5).ToDictionary(
                grade => grade,
                grade => grades.Count(g => g == grade)
            );

            // Очищаем график перед обновлением
            chartGrade_SDV.Series["Оценки"].Points.Clear();

            // Добавляем данные в график
            foreach (var gradeCount in gradeCounts)
            {
                chartGrade_SDV.Series["Оценки"].Points.AddXY(gradeCount.Key, gradeCount.Value);
            }
        }
        private List<int> GetGradesFromDataGridView()
        {
            var grades = new List<int>();

            foreach (DataGridViewRow row in dataGridViewStudents_SDV.Rows)
            {
                if (row.Cells.Count > 1 && int.TryParse(row.Cells[1].Value?.ToString(), out int grade)) // существует ли второй столбец, Если значение ячейки можно преобразовать в целое число (оценка), то оно добавляется в список
                {
                    grades.Add(grade);
                }
            }

            return grades;
        }
        private bool SearchValueInDataGridView(DataGridView dataGridView, string searchValue)
        {
            bool found = false; // Флаг, указывающий, что хотя бы одно совпадение найдено

            // Проходим по каждой строке в DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Пропускаем пустую строку (это последняя строка в DataGridView для добавления новых данных)
                if (row.IsNewRow) continue;

                bool rowFound = false; // Флаг для строки, если в ней есть хотя бы одно совпадение

                // Проходим по каждой ячейке в текущей строке
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Получаем значение ячейки (если оно есть)
                    string? cellValue = cell.Value?.ToString();

                    // Проверяем, содержит ли ячейка поисковое значение
                    if (!string.IsNullOrEmpty(cellValue) && cellValue.Contains(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        rowFound = true; // Если есть совпадение, устанавливаем флаг
                        break; // Прерываем проверку остальных ячеек в строке
                    }
                }

                if (rowFound) // Если в строке было найдено совпадение
                {
                    row.Selected = true; // Выделяем всю строку
                    found = true; // Устанавливаем общий флаг о наличии совпадений
                }
            }

            return found;
        }

        private void toolStripButtonImage_SDV_Click(object sender, EventArgs e)
        {
            // Получаем текст из текстового поля (без лишних пробелов)
            string searchValue = toolStripTextBoxSearch_SDV.Text.Trim();

            // Сначала снимаем выделение со всех строк
            dataGridViewStudents_SDV.ClearSelection();

            // Проверяем, что поле поиска не пустое
            if (!string.IsNullOrEmpty(searchValue))
            {
                // Ищем значение в DataGridView
                bool found = SearchValueInDataGridView(dataGridViewStudents_SDV, searchValue);

                if (found)
                {
                    MessageBox.Show("Найдено одно или несколько совпадений.");
                }
                else
                {
                    MessageBox.Show("Значение не найдено.");
                }
            }
            else
            {
                MessageBox.Show("Введите значение для поиска.");
            }
        }
        
        private void buttonDone_SDV_Click(object sender, EventArgs e)
        {
            // Открываем диалог для выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Выберите файл для расчета средней оценки"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) // Если пользователь выбрал файл
            {
                string filePath = openFileDialog.FileName; // Получаем путь к выбранному файлу

                try
                {
                    var grades = DataService.LoadGradesFromCsv(filePath); // Загрузка оценок из выбранного файла
                    double averageGrade = DataService.CalculateAverageGrade(grades); // Расчет средней оценки
                    textBoxResult_SDV.Text = averageGrade.ToString(); // Выводим результат в текстовое поле
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message); // Обработка ошибок
                }
            }
        }


        private void buttonAboutMe_SDV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonReference_SDV_Click(object sender, EventArgs e)
        {
            FormManagement formException = new FormManagement();
            formException.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }


    }
}
