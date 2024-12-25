namespace Tyuiu.SinitsinDV.Sprint7.Project.V3
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelAbout_SDV = new Label();
            pictureBoxMe_SDV = new PictureBox();
            buttonOK_SDV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_SDV).BeginInit();
            SuspendLayout();
            // 
            // labelAbout_SDV
            // 
            labelAbout_SDV.AutoSize = true;
            labelAbout_SDV.Location = new Point(268, 60);
            labelAbout_SDV.Name = "labelAbout_SDV";
            labelAbout_SDV.Size = new Size(282, 165);
            labelAbout_SDV.TabIndex = 0;
            labelAbout_SDV.Text = resources.GetString("labelAbout_SDV.Text");
            // 
            // pictureBoxMe_SDV
            // 
            pictureBoxMe_SDV.Image = (Image)resources.GetObject("pictureBoxMe_SDV.Image");
            pictureBoxMe_SDV.Location = new Point(22, 26);
            pictureBoxMe_SDV.Name = "pictureBoxMe_SDV";
            pictureBoxMe_SDV.Size = new Size(204, 360);
            pictureBoxMe_SDV.TabIndex = 1;
            pictureBoxMe_SDV.TabStop = false;
            // 
            // buttonOK_SDV
            // 
            buttonOK_SDV.Location = new Point(531, 349);
            buttonOK_SDV.Name = "buttonOK_SDV";
            buttonOK_SDV.Size = new Size(84, 36);
            buttonOK_SDV.TabIndex = 2;
            buttonOK_SDV.Text = "ОК";
            buttonOK_SDV.UseVisualStyleBackColor = true;
            buttonOK_SDV.Click += buttonOK_SDV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 397);
            Controls.Add(buttonOK_SDV);
            Controls.Add(pictureBoxMe_SDV);
            Controls.Add(labelAbout_SDV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_SDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAbout_SDV;
        private PictureBox pictureBoxMe_SDV;
        private Button buttonOK_SDV;
    }
}