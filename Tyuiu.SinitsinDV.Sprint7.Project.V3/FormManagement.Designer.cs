namespace Tyuiu.SinitsinDV.Sprint7.Project.V3
{
    partial class FormManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagement));
            textBoxManagement_SDV = new TextBox();
            SuspendLayout();
            // 
            // textBoxManagement_SDV
            // 
            textBoxManagement_SDV.Dock = DockStyle.Fill;
            textBoxManagement_SDV.Location = new Point(0, 0);
            textBoxManagement_SDV.Multiline = true;
            textBoxManagement_SDV.Name = "textBoxManagement_SDV";
            textBoxManagement_SDV.ScrollBars = ScrollBars.Vertical;
            textBoxManagement_SDV.Size = new Size(800, 450);
            textBoxManagement_SDV.TabIndex = 0;
            textBoxManagement_SDV.Text = resources.GetString("textBoxManagement_SDV.Text");
            textBoxManagement_SDV.TextChanged += textBoxManagement_SDV_TextChanged;
            // 
            // FormManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxManagement_SDV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormManagement";
            Text = "Руководство";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxManagement_SDV;
    }
}