namespace Tyuiu.TomilovDA.Sprint7.Project.V7
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(989, 480);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(998, 503);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            MaximumSize = new Size(1016, 550);
            MinimumSize = new Size(1016, 550);
            Name = "FormGuide";
            Text = "Справка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}