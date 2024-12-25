namespace Tyuiu.TomilovDA.Sprint7.Project.V7
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
            pictureBoxIcon_TDA = new PictureBox();
            buttonOK_TDA = new Button();
            labelAbout_TDA = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon_TDA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIcon_TDA
            // 
            pictureBoxIcon_TDA.Image = Project.V7.Properties.Resources._4kava;
            pictureBoxIcon_TDA.Location = new Point(12, 13);
            pictureBoxIcon_TDA.Name = "pictureBoxIcon_TDA";
            pictureBoxIcon_TDA.Size = new Size(180, 180);
            pictureBoxIcon_TDA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIcon_TDA.TabIndex = 0;
            pictureBoxIcon_TDA.TabStop = false;
            // 
            // buttonOK_TDA
            // 
            buttonOK_TDA.Location = new Point(431, 169);
            buttonOK_TDA.Name = "buttonOK_TDA";
            buttonOK_TDA.Size = new Size(75, 23);
            buttonOK_TDA.TabIndex = 2;
            buttonOK_TDA.Text = "ОК";
            buttonOK_TDA.UseVisualStyleBackColor = true;
            buttonOK_TDA.Click += buttonOK_TDA_Click;
            // 
            // labelAbout_TDA
            // 
            labelAbout_TDA.AutoSize = true;
            labelAbout_TDA.Location = new Point(203, 13);
            labelAbout_TDA.Name = "labelAbout_TDA";
            labelAbout_TDA.Size = new Size(303, 135);
            labelAbout_TDA.TabIndex = 3;
            labelAbout_TDA.Text = resources.GetString("labelAbout_TDA.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 204);
            Controls.Add(labelAbout_TDA);
            Controls.Add(buttonOK_TDA);
            Controls.Add(pictureBoxIcon_TDA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon_TDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxIcon_TDA;
        private Button buttonOK_TDA;
        private Label labelAbout_TDA;
    }
}