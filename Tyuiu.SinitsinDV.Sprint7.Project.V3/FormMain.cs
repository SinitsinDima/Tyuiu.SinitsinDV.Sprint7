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
            // ��������� Chart ��� �������
            chartGrade_SDV.ChartAreas.Add(new ChartArea("MainArea"));
            chartGrade_SDV.Legends.Add(new Legend("GradesLegend"));
            chartGrade_SDV.Series.Add(new Series("������")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.Int32
            });
        }

        private void buttonOpenFile_SDV_Click(object sender, EventArgs e)
        {
            // ��������� ������ ��� ������ �����
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog.Title = "�������� ���� ��� ��������";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // ��������� ���� ��� ������
                    using (var reader = new StreamReader(filePath, Encoding.UTF8))
                    {
                        // ������ ��� ������ �� �����
                        var lines = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            lines.Add(reader.ReadLine());
                        }

                        // ���� ���� �� ������
                        if (lines.Count > 0)
                        {

                            // ��������� ��������� ������ ��� ������ � DataGridView
                            for (int i = 0; i < lines.Count; i++)
                            {
                                var row = lines[i].Split(';');

                                // ��������� ������ �������� ��� ��������� ������
                                dataGridViewStudents_SDV.Rows.Add(row);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� �������� �����: " + ex.Message);
                }
            }
        }

        private void buttonSaveFile_SDV_Click(object sender, EventArgs e)
        {
            // ��������� ������ ��� ������ ����� � ����� �����
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "��������� ������ � ����"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // ������� ���� ��� ������
                    using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                    {
                        // ���������� ������ ����� �� DataGridView, ������� � ������ ������ (��� ����������)
                        foreach (DataGridViewRow row in dataGridViewStudents_SDV.Rows)
                        {
                            // ���������� ������ ������ ��� ���������� ����� ������
                            if (row.IsNewRow) continue;

                            var cellValues = row.Cells.Cast<DataGridViewCell>()
                                                      .Select(cell => cell.Value?.ToString() ?? string.Empty);
                            writer.WriteLine(string.Join(";", cellValues));
                        }
                    }

                    MessageBox.Show("������ ������� ��������� � ����.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� ���������� ������: " + ex.Message);
                }
            }
        }

        // ������� ������ �� DataGridView
        private void toolStripButtonClean_SDV_Click(object sender, EventArgs e)
        {
            dataGridViewStudents_SDV.Rows.Clear();
            for (int i = 1; i < dataGridViewStudents_SDV.Rows.Count; i++)
            {
                dataGridViewStudents_SDV.Columns.Clear();
            }
        }

        // ���������� ������� �� ������ ������
        private void buttonGrade_SDV_Click(object sender, EventArgs e)
        {
            // �������� ������ �� ������� ������� DataGridView
            var grades = GetGradesFromDataGridView();

            // ������� ���������� ������ ������
            var gradeCounts = Enumerable.Range(1, 5).ToDictionary(
                grade => grade,
                grade => grades.Count(g => g == grade)
            );

            // ������� ������ ����� �����������
            chartGrade_SDV.Series["������"].Points.Clear();

            // ��������� ������ � ������
            foreach (var gradeCount in gradeCounts)
            {
                chartGrade_SDV.Series["������"].Points.AddXY(gradeCount.Key, gradeCount.Value);
            }
        }
        private List<int> GetGradesFromDataGridView()
        {
            var grades = new List<int>();

            foreach (DataGridViewRow row in dataGridViewStudents_SDV.Rows)
            {
                if (row.Cells.Count > 1 && int.TryParse(row.Cells[1].Value?.ToString(), out int grade))
                {
                    grades.Add(grade);
                }
            }

            return grades;
        }
        private bool SearchValueInDataGridView(DataGridView dataGridView, string searchValue)
        {
            bool found = false; // ����, �����������, ��� ���� �� ���� ���������� �������

            // �������� �� ������ ������ � DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // ���������� ������ ������ (��� ��������� ������ � DataGridView ��� ���������� ����� ������)
                if (row.IsNewRow) continue;

                bool rowFound = false; // ���� ��� ������, ���� � ��� ���� ���� �� ���� ����������

                // �������� �� ������ ������ � ������� ������
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // �������� �������� ������ (���� ��� ����)
                    string? cellValue = cell.Value?.ToString();

                    // ���������, �������� �� ������ ��������� ��������
                    if (!string.IsNullOrEmpty(cellValue) && cellValue.Contains(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        rowFound = true; // ���� ���� ����������, ������������� ����
                        break; // ��������� �������� ��������� ����� � ������
                    }
                }

                if (rowFound) // ���� � ������ ���� ������� ����������
                {
                    row.Selected = true; // �������� ��� ������
                    found = true; // ������������� ����� ���� � ������� ����������
                }
            }

            return found;
        }

        private void toolStripButtonImage_SDV_Click(object sender, EventArgs e)
        {
            // �������� ����� �� ���������� ���� (��� ������ ��������)
            string searchValue = toolStripTextBoxSearch_SDV.Text.Trim();

            // ������� ������� ��������� �� ���� �����
            dataGridViewStudents_SDV.ClearSelection();

            // ���������, ��� ���� ������ �� ������
            if (!string.IsNullOrEmpty(searchValue))
            {
                // ���� �������� � DataGridView
                bool found = SearchValueInDataGridView(dataGridViewStudents_SDV, searchValue);

                if (found)
                {
                    MessageBox.Show("������� ���� ��� ��������� ����������.");
                }
                else
                {
                    MessageBox.Show("�������� �� �������.");
                }
            }
            else
            {
                MessageBox.Show("������� �������� ��� ������.");
            }
        }
        string filePath = @"C:\�����\�������.csv";
        private void buttonDone_SDV_Click(object sender, EventArgs e)
        {
            var grades = DataService.LoadGradesFromCsv(filePath);
            double averageGrade = DataService.CalculateAverageGrade(grades);
            textBoxResult_SDV.Text = averageGrade.ToString();
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
   
