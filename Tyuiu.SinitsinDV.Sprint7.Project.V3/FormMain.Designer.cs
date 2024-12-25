namespace Tyuiu.SinitsinDV.Sprint7.Project.V3
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_SDV = new Panel();
            buttonReference_SDV = new Button();
            buttonSaveFile_SDV = new Button();
            buttonAboutMe_SDV = new Button();
            buttonOpenFile_SDV = new Button();
            toolStripSettings_SDV = new ToolStrip();
            toolStripLabelSearch_SDV = new ToolStripLabel();
            toolStripTextBoxSearch_SDV = new ToolStripTextBox();
            toolStripButtonImage_SDV = new ToolStripButton();
            toolStripButtonClean_SDV = new ToolStripButton();
            panelBottom_SDV = new Panel();
            groupBoxResult_SDV = new GroupBox();
            buttonDone_SDV = new Button();
            textBoxResult_SDV = new TextBox();
            labelResult_SDV = new Label();
            splitter1 = new Splitter();
            panelLeft_SDV = new Panel();
            dataGridViewStudents_SDV = new DataGridView();
            Students_SDV = new DataGridViewTextBoxColumn();
            Grade_SDV = new DataGridViewTextBoxColumn();
            Note_SDV = new DataGridViewTextBoxColumn();
            Teacher = new DataGridViewTextBoxColumn();
            panelRight_SDV = new Panel();
            buttonGrade_SDV = new Button();
            chartGrade_SDV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter2 = new Splitter();
            backgroundWorker_SDV = new System.ComponentModel.BackgroundWorker();
            toolTip_SDV = new ToolTip(components);
            panelTop_SDV.SuspendLayout();
            toolStripSettings_SDV.SuspendLayout();
            panelBottom_SDV.SuspendLayout();
            groupBoxResult_SDV.SuspendLayout();
            panelLeft_SDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents_SDV).BeginInit();
            panelRight_SDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGrade_SDV).BeginInit();
            SuspendLayout();
            // 
            // panelTop_SDV
            // 
            panelTop_SDV.Controls.Add(buttonReference_SDV);
            panelTop_SDV.Controls.Add(buttonSaveFile_SDV);
            panelTop_SDV.Controls.Add(buttonAboutMe_SDV);
            panelTop_SDV.Controls.Add(buttonOpenFile_SDV);
            panelTop_SDV.Controls.Add(toolStripSettings_SDV);
            panelTop_SDV.Dock = DockStyle.Top;
            panelTop_SDV.Location = new Point(0, 0);
            panelTop_SDV.Margin = new Padding(3, 2, 3, 2);
            panelTop_SDV.Name = "panelTop_SDV";
            panelTop_SDV.Size = new Size(1011, 68);
            panelTop_SDV.TabIndex = 0;
            // 
            // buttonReference_SDV
            // 
            buttonReference_SDV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonReference_SDV.Location = new Point(878, 22);
            buttonReference_SDV.Margin = new Padding(3, 2, 3, 2);
            buttonReference_SDV.Name = "buttonReference_SDV";
            buttonReference_SDV.Size = new Size(122, 22);
            buttonReference_SDV.TabIndex = 4;
            buttonReference_SDV.Text = "Руководство";
            toolTip_SDV.SetToolTip(buttonReference_SDV, "Руководство пользования программой");
            buttonReference_SDV.UseVisualStyleBackColor = true;
            buttonReference_SDV.Click += buttonReference_SDV_Click;
            // 
            // buttonSaveFile_SDV
            // 
            buttonSaveFile_SDV.Image = (Image)resources.GetObject("buttonSaveFile_SDV.Image");
            buttonSaveFile_SDV.Location = new Point(63, 29);
            buttonSaveFile_SDV.Margin = new Padding(3, 2, 3, 2);
            buttonSaveFile_SDV.Name = "buttonSaveFile_SDV";
            buttonSaveFile_SDV.Size = new Size(53, 36);
            buttonSaveFile_SDV.TabIndex = 3;
            toolTip_SDV.SetToolTip(buttonSaveFile_SDV, "Сохранить файл");
            buttonSaveFile_SDV.UseVisualStyleBackColor = true;
            buttonSaveFile_SDV.Click += buttonSaveFile_SDV_Click;
            // 
            // buttonAboutMe_SDV
            // 
            buttonAboutMe_SDV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAboutMe_SDV.Location = new Point(878, 44);
            buttonAboutMe_SDV.Margin = new Padding(3, 2, 3, 2);
            buttonAboutMe_SDV.Name = "buttonAboutMe_SDV";
            buttonAboutMe_SDV.Size = new Size(122, 22);
            buttonAboutMe_SDV.TabIndex = 2;
            buttonAboutMe_SDV.Text = "О программе";
            toolTip_SDV.SetToolTip(buttonAboutMe_SDV, "Данные о программе");
            buttonAboutMe_SDV.UseVisualStyleBackColor = true;
            buttonAboutMe_SDV.Click += buttonAboutMe_SDV_Click;
            // 
            // buttonOpenFile_SDV
            // 
            buttonOpenFile_SDV.Image = (Image)resources.GetObject("buttonOpenFile_SDV.Image");
            buttonOpenFile_SDV.Location = new Point(4, 29);
            buttonOpenFile_SDV.Margin = new Padding(3, 2, 3, 2);
            buttonOpenFile_SDV.Name = "buttonOpenFile_SDV";
            buttonOpenFile_SDV.Size = new Size(53, 35);
            buttonOpenFile_SDV.TabIndex = 1;
            toolTip_SDV.SetToolTip(buttonOpenFile_SDV, "Открыть файл");
            buttonOpenFile_SDV.UseVisualStyleBackColor = true;
            buttonOpenFile_SDV.Click += buttonOpenFile_SDV_Click;
            // 
            // toolStripSettings_SDV
            // 
            toolStripSettings_SDV.ImageScalingSize = new Size(20, 20);
            toolStripSettings_SDV.Items.AddRange(new ToolStripItem[] { toolStripLabelSearch_SDV, toolStripTextBoxSearch_SDV, toolStripButtonImage_SDV, toolStripButtonClean_SDV });
            toolStripSettings_SDV.Location = new Point(0, 0);
            toolStripSettings_SDV.Name = "toolStripSettings_SDV";
            toolStripSettings_SDV.Size = new Size(1011, 27);
            toolStripSettings_SDV.TabIndex = 0;
            toolStripSettings_SDV.Text = "toolStrip1";
            // 
            // toolStripLabelSearch_SDV
            // 
            toolStripLabelSearch_SDV.Name = "toolStripLabelSearch_SDV";
            toolStripLabelSearch_SDV.Size = new Size(42, 24);
            toolStripLabelSearch_SDV.Text = "Поиск";
            // 
            // toolStripTextBoxSearch_SDV
            // 
            toolStripTextBoxSearch_SDV.Name = "toolStripTextBoxSearch_SDV";
            toolStripTextBoxSearch_SDV.Size = new Size(88, 27);
            // 
            // toolStripButtonImage_SDV
            // 
            toolStripButtonImage_SDV.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonImage_SDV.Image = (Image)resources.GetObject("toolStripButtonImage_SDV.Image");
            toolStripButtonImage_SDV.ImageTransparentColor = Color.Magenta;
            toolStripButtonImage_SDV.Name = "toolStripButtonImage_SDV";
            toolStripButtonImage_SDV.Size = new Size(24, 24);
            toolStripButtonImage_SDV.ToolTipText = "Произовести поиск по таблице ";
            toolStripButtonImage_SDV.Click += toolStripButtonImage_SDV_Click;
            // 
            // toolStripButtonClean_SDV
            // 
            toolStripButtonClean_SDV.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonClean_SDV.Image = (Image)resources.GetObject("toolStripButtonClean_SDV.Image");
            toolStripButtonClean_SDV.ImageTransparentColor = Color.Magenta;
            toolStripButtonClean_SDV.Name = "toolStripButtonClean_SDV";
            toolStripButtonClean_SDV.Size = new Size(24, 24);
            toolStripButtonClean_SDV.ToolTipText = "Очистить таблицу таблицы";
            toolStripButtonClean_SDV.Click += toolStripButtonClean_SDV_Click;
            // 
            // panelBottom_SDV
            // 
            panelBottom_SDV.Controls.Add(groupBoxResult_SDV);
            panelBottom_SDV.Controls.Add(splitter1);
            panelBottom_SDV.Dock = DockStyle.Bottom;
            panelBottom_SDV.Location = new Point(0, 355);
            panelBottom_SDV.Margin = new Padding(3, 2, 3, 2);
            panelBottom_SDV.Name = "panelBottom_SDV";
            panelBottom_SDV.Size = new Size(1011, 65);
            panelBottom_SDV.TabIndex = 0;
            // 
            // groupBoxResult_SDV
            // 
            groupBoxResult_SDV.Controls.Add(buttonDone_SDV);
            groupBoxResult_SDV.Controls.Add(textBoxResult_SDV);
            groupBoxResult_SDV.Controls.Add(labelResult_SDV);
            groupBoxResult_SDV.Dock = DockStyle.Fill;
            groupBoxResult_SDV.Location = new Point(4, 0);
            groupBoxResult_SDV.Margin = new Padding(3, 2, 3, 2);
            groupBoxResult_SDV.Name = "groupBoxResult_SDV";
            groupBoxResult_SDV.Padding = new Padding(3, 2, 3, 2);
            groupBoxResult_SDV.Size = new Size(1007, 65);
            groupBoxResult_SDV.TabIndex = 1;
            groupBoxResult_SDV.TabStop = false;
            groupBoxResult_SDV.Text = "Результат";
            // 
            // buttonDone_SDV
            // 
            buttonDone_SDV.Location = new Point(236, 15);
            buttonDone_SDV.Margin = new Padding(3, 2, 3, 2);
            buttonDone_SDV.Name = "buttonDone_SDV";
            buttonDone_SDV.Size = new Size(89, 22);
            buttonDone_SDV.TabIndex = 2;
            buttonDone_SDV.Text = "Выполнить";
            toolTip_SDV.SetToolTip(buttonDone_SDV, "Подсчитать среднюю оценку учащихся");
            buttonDone_SDV.UseVisualStyleBackColor = true;
            buttonDone_SDV.Click += buttonDone_SDV_Click;
            // 
            // textBoxResult_SDV
            // 
            textBoxResult_SDV.Location = new Point(122, 15);
            textBoxResult_SDV.Margin = new Padding(3, 2, 3, 2);
            textBoxResult_SDV.Name = "textBoxResult_SDV";
            textBoxResult_SDV.ReadOnly = true;
            textBoxResult_SDV.Size = new Size(110, 23);
            textBoxResult_SDV.TabIndex = 1;
            // 
            // labelResult_SDV
            // 
            labelResult_SDV.AutoSize = true;
            labelResult_SDV.Location = new Point(7, 17);
            labelResult_SDV.Name = "labelResult_SDV";
            labelResult_SDV.Size = new Size(98, 15);
            labelResult_SDV.TabIndex = 0;
            labelResult_SDV.Text = "Средняя оценка:";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(3, 2, 3, 2);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 65);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panelLeft_SDV
            // 
            panelLeft_SDV.Controls.Add(dataGridViewStudents_SDV);
            panelLeft_SDV.Dock = DockStyle.Left;
            panelLeft_SDV.Location = new Point(0, 68);
            panelLeft_SDV.Margin = new Padding(3, 2, 3, 2);
            panelLeft_SDV.Name = "panelLeft_SDV";
            panelLeft_SDV.Size = new Size(613, 287);
            panelLeft_SDV.TabIndex = 0;
            // 
            // dataGridViewStudents_SDV
            // 
            dataGridViewStudents_SDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents_SDV.Columns.AddRange(new DataGridViewColumn[] { Students_SDV, Grade_SDV, Note_SDV, Teacher });
            dataGridViewStudents_SDV.Dock = DockStyle.Fill;
            dataGridViewStudents_SDV.Location = new Point(0, 0);
            dataGridViewStudents_SDV.Margin = new Padding(3, 2, 3, 2);
            dataGridViewStudents_SDV.Name = "dataGridViewStudents_SDV";
            dataGridViewStudents_SDV.RowHeadersVisible = false;
            dataGridViewStudents_SDV.RowHeadersWidth = 51;
            dataGridViewStudents_SDV.Size = new Size(613, 287);
            dataGridViewStudents_SDV.TabIndex = 0;
            // 
            // Students_SDV
            // 
            Students_SDV.HeaderText = "Студенты";
            Students_SDV.MinimumWidth = 6;
            Students_SDV.Name = "Students_SDV";
            Students_SDV.Width = 170;
            // 
            // Grade_SDV
            // 
            Grade_SDV.HeaderText = "Оценка";
            Grade_SDV.MinimumWidth = 6;
            Grade_SDV.Name = "Grade_SDV";
            Grade_SDV.Width = 125;
            // 
            // Note_SDV
            // 
            Note_SDV.HeaderText = "Примечание";
            Note_SDV.MinimumWidth = 6;
            Note_SDV.Name = "Note_SDV";
            Note_SDV.Width = 125;
            // 
            // Teacher
            // 
            Teacher.HeaderText = "Преподаватель";
            Teacher.MinimumWidth = 6;
            Teacher.Name = "Teacher";
            Teacher.Width = 125;
            // 
            // panelRight_SDV
            // 
            panelRight_SDV.Controls.Add(buttonGrade_SDV);
            panelRight_SDV.Controls.Add(chartGrade_SDV);
            panelRight_SDV.Controls.Add(splitter2);
            panelRight_SDV.Dock = DockStyle.Fill;
            panelRight_SDV.Location = new Point(613, 68);
            panelRight_SDV.Margin = new Padding(3, 2, 3, 2);
            panelRight_SDV.Name = "panelRight_SDV";
            panelRight_SDV.Size = new Size(398, 287);
            panelRight_SDV.TabIndex = 0;
            // 
            // buttonGrade_SDV
            // 
            buttonGrade_SDV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonGrade_SDV.Location = new Point(299, 232);
            buttonGrade_SDV.Margin = new Padding(3, 2, 3, 2);
            buttonGrade_SDV.Name = "buttonGrade_SDV";
            buttonGrade_SDV.Size = new Size(80, 39);
            buttonGrade_SDV.TabIndex = 2;
            buttonGrade_SDV.Text = "Количество оценок";
            toolTip_SDV.SetToolTip(buttonGrade_SDV, "Вывод количества оценок учащихся");
            buttonGrade_SDV.UseVisualStyleBackColor = true;
            buttonGrade_SDV.Click += buttonGrade_SDV_Click;
            // 
            // chartGrade_SDV
            // 
            chartArea1.Name = "ChartArea1";
            chartGrade_SDV.ChartAreas.Add(chartArea1);
            chartGrade_SDV.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartGrade_SDV.Legends.Add(legend1);
            chartGrade_SDV.Location = new Point(4, 0);
            chartGrade_SDV.Margin = new Padding(3, 2, 3, 2);
            chartGrade_SDV.Name = "chartGrade_SDV";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGrade_SDV.Series.Add(series1);
            chartGrade_SDV.Size = new Size(394, 287);
            chartGrade_SDV.TabIndex = 1;
            chartGrade_SDV.Text = "chart1";
            // 
            // splitter2
            // 
            splitter2.Location = new Point(0, 0);
            splitter2.Margin = new Padding(3, 2, 3, 2);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 287);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // toolTip_SDV
            // 
            toolTip_SDV.Tag = "";
            toolTip_SDV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 420);
            Controls.Add(panelRight_SDV);
            Controls.Add(panelLeft_SDV);
            Controls.Add(panelBottom_SDV);
            Controls.Add(panelTop_SDV);
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "FormMain";
            Text = "Электронный дневник учащегося";
            Load += FormMain_Load;
            panelTop_SDV.ResumeLayout(false);
            panelTop_SDV.PerformLayout();
            toolStripSettings_SDV.ResumeLayout(false);
            toolStripSettings_SDV.PerformLayout();
            panelBottom_SDV.ResumeLayout(false);
            groupBoxResult_SDV.ResumeLayout(false);
            groupBoxResult_SDV.PerformLayout();
            panelLeft_SDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents_SDV).EndInit();
            panelRight_SDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGrade_SDV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_SDV;
        private Panel panelBottom_SDV;
        private Panel panelLeft_SDV;
        private Panel panelRight_SDV;
        private Splitter splitter1;
        private Splitter splitter2;
        private System.ComponentModel.BackgroundWorker backgroundWorker_SDV;
        private ToolStrip toolStripSettings_SDV;
        private ToolStripLabel toolStripLabelSearch_SDV;
        private ToolStripTextBox toolStripTextBoxSearch_SDV;
        private ToolStripButton toolStripButtonImage_SDV;
        private Button buttonReference_SDV;
        private Button buttonSaveFile_SDV;
        private Button buttonAboutMe_SDV;
        private Button buttonOpenFile_SDV;
        private DataGridView dataGridViewStudents_SDV;
        private GroupBox groupBoxResult_SDV;
        private Label labelResult_SDV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrade_SDV;
        private TextBox textBoxResult_SDV;
        private ToolStripButton toolStripButtonClean_SDV;
        private DataGridViewTextBoxColumn Students_SDV;
        private DataGridViewTextBoxColumn Grade_SDV;
        private DataGridViewTextBoxColumn Note_SDV;
        private DataGridViewTextBoxColumn Teacher;
        private Button buttonGrade_SDV;
        private Button buttonDone_SDV;
        private ToolTip toolTip_SDV;
    }
}
