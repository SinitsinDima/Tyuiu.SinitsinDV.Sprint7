using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SinitsinDV.Sprint7.Project.V3
{
    public partial class FormManagement : Form
    {
        public FormManagement()
        {
            InitializeComponent();
            textBoxManagement_SDV.Multiline = true;        // Поддержка многострочного ввода
            textBoxManagement_SDV.ScrollBars = ScrollBars.Vertical;  // Только вертикальный скроллбар
            textBoxManagement_SDV.WordWrap = true;         // Автоматический перенос текста по ширине

        }

        private void textBoxManagement_SDV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
