namespace Tyuiu.TomilovDA.Sprint7.Project.V7
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
            labelDeleteRows_TDA = new Label();
            buttonDeleteRows_TDA = new Button();
            labelAddRow_TDA = new Label();
            menuStripMain_TDA = new MenuStrip();
            ToolStripMenuItemFile_TDA = new ToolStripMenuItem();
            ToolStripMenuItemCreate_TDA = new ToolStripMenuItem();
            toolStripMenuItemOpenFile_TDA = new ToolStripMenuItem();
            ToolStripMenuItemSave_TDA = new ToolStripMenuItem();
            ToolStripMenuItemAbout_TDA = new ToolStripMenuItem();
            ToolStripMenuItemHelp_TDA = new ToolStripMenuItem();
            groupBoxGrid_TDA = new GroupBox();
            dataGridViewApartments_TDA = new DataGridView();
            toolStripTable_TDA = new ToolStrip();
            toolStripLabelFind_TDA = new ToolStripLabel();
            toolStripTextBoxFilter_TDA = new ToolStripTextBox();
            openFileDialogTable_TDA = new OpenFileDialog();
            toolTipMain_TDA = new ToolTip(components);
            buttonAddRow_TDA = new Button();
            labelAverage_TDA = new Label();
            buttonAverage_TDA = new Button();
            panelButtons_TDA = new Panel();
            checkBoxRow_TDA = new CheckBox();
            panelGrid_TDA = new Panel();
            splitContainerTable_TDA = new SplitContainer();
            labelCount_TDA = new Label();
            menuStripMain_TDA.SuspendLayout();
            groupBoxGrid_TDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApartments_TDA).BeginInit();
            toolStripTable_TDA.SuspendLayout();
            panelButtons_TDA.SuspendLayout();
            panelGrid_TDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerTable_TDA).BeginInit();
            splitContainerTable_TDA.Panel1.SuspendLayout();
            splitContainerTable_TDA.Panel2.SuspendLayout();
            splitContainerTable_TDA.SuspendLayout();
            SuspendLayout();
            // 
            // labelDeleteRows_TDA
            // 
            labelDeleteRows_TDA.AutoSize = true;
            labelDeleteRows_TDA.Location = new Point(108, 86);
            labelDeleteRows_TDA.Name = "labelDeleteRows_TDA";
            labelDeleteRows_TDA.Size = new Size(91, 15);
            labelDeleteRows_TDA.TabIndex = 5;
            labelDeleteRows_TDA.Text = "Удалить строку";
            labelDeleteRows_TDA.TextAlign = ContentAlignment.MiddleCenter;
            toolTipMain_TDA.SetToolTip(labelDeleteRows_TDA, "Удалить выделенные строки");
            labelDeleteRows_TDA.Click += labelDeleteRows_TDA_Click;
            // 
            // buttonDeleteRows_TDA
            // 
            buttonDeleteRows_TDA.Enabled = false;
            buttonDeleteRows_TDA.Image = (Image)resources.GetObject("buttonDeleteRows_TDA.Image");
            buttonDeleteRows_TDA.Location = new Point(129, 37);
            buttonDeleteRows_TDA.Name = "buttonDeleteRows_TDA";
            buttonDeleteRows_TDA.Size = new Size(46, 46);
            buttonDeleteRows_TDA.TabIndex = 4;
            buttonDeleteRows_TDA.TextImageRelation = TextImageRelation.ImageAboveText;
            toolTipMain_TDA.SetToolTip(buttonDeleteRows_TDA, "Удалить выделенные строки");
            buttonDeleteRows_TDA.UseVisualStyleBackColor = true;
            buttonDeleteRows_TDA.Click += buttonDeleteRows_TDA_Click;
            // 
            // labelAddRow_TDA
            // 
            labelAddRow_TDA.AutoSize = true;
            labelAddRow_TDA.Location = new Point(3, 86);
            labelAddRow_TDA.Name = "labelAddRow_TDA";
            labelAddRow_TDA.Size = new Size(99, 15);
            labelAddRow_TDA.TabIndex = 3;
            labelAddRow_TDA.Text = "Добавить строку";
            labelAddRow_TDA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStripMain_TDA
            // 
            menuStripMain_TDA.BackColor = SystemColors.ControlLight;
            menuStripMain_TDA.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemFile_TDA, ToolStripMenuItemAbout_TDA, ToolStripMenuItemHelp_TDA });
            menuStripMain_TDA.Location = new Point(0, 0);
            menuStripMain_TDA.Name = "menuStripMain_TDA";
            menuStripMain_TDA.Size = new Size(1123, 24);
            menuStripMain_TDA.TabIndex = 1;
            menuStripMain_TDA.Text = "menuStripMain_TDA";
            // 
            // ToolStripMenuItemFile_TDA
            // 
            ToolStripMenuItemFile_TDA.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemCreate_TDA, toolStripMenuItemOpenFile_TDA, ToolStripMenuItemSave_TDA });
            ToolStripMenuItemFile_TDA.Name = "ToolStripMenuItemFile_TDA";
            ToolStripMenuItemFile_TDA.Size = new Size(48, 20);
            ToolStripMenuItemFile_TDA.Text = "Файл";
            // 
            // ToolStripMenuItemCreate_TDA
            // 
            ToolStripMenuItemCreate_TDA.Name = "ToolStripMenuItemCreate_TDA";
            ToolStripMenuItemCreate_TDA.Size = new Size(133, 22);
            ToolStripMenuItemCreate_TDA.Text = "Создать";
            ToolStripMenuItemCreate_TDA.ToolTipText = "Создать новую таблицу";
            ToolStripMenuItemCreate_TDA.Click += создатьToolStripMenuItem_Click;
            // 
            // toolStripMenuItemOpenFile_TDA
            // 
            toolStripMenuItemOpenFile_TDA.Name = "toolStripMenuItemOpenFile_TDA";
            toolStripMenuItemOpenFile_TDA.Size = new Size(133, 22);
            toolStripMenuItemOpenFile_TDA.Text = "Открыть";
            toolStripMenuItemOpenFile_TDA.ToolTipText = "Выберите .csv файл таблицы";
            toolStripMenuItemOpenFile_TDA.Click += toolStripMenuItemOpenFile_TDA_Click;
            // 
            // ToolStripMenuItemSave_TDA
            // 
            ToolStripMenuItemSave_TDA.Name = "ToolStripMenuItemSave_TDA";
            ToolStripMenuItemSave_TDA.Size = new Size(133, 22);
            ToolStripMenuItemSave_TDA.Text = "Сохранить";
            ToolStripMenuItemSave_TDA.Click += ToolStripMenuItemSave_TDA_Click;
            // 
            // ToolStripMenuItemAbout_TDA
            // 
            ToolStripMenuItemAbout_TDA.Name = "ToolStripMenuItemAbout_TDA";
            ToolStripMenuItemAbout_TDA.Size = new Size(94, 20);
            ToolStripMenuItemAbout_TDA.Text = "О программе";
            ToolStripMenuItemAbout_TDA.ToolTipText = "Информация о программе и о её разработчике";
            ToolStripMenuItemAbout_TDA.Click += ToolStripMenuItemAbout_TDA_Click;
            // 
            // ToolStripMenuItemHelp_TDA
            // 
            ToolStripMenuItemHelp_TDA.Name = "ToolStripMenuItemHelp_TDA";
            ToolStripMenuItemHelp_TDA.Size = new Size(65, 20);
            ToolStripMenuItemHelp_TDA.Text = "Справка";
            ToolStripMenuItemHelp_TDA.Click += ToolStripMenuItemHelp_TDA_Click;
            // 
            // groupBoxGrid_TDA
            // 
            groupBoxGrid_TDA.Controls.Add(dataGridViewApartments_TDA);
            groupBoxGrid_TDA.Dock = DockStyle.Fill;
            groupBoxGrid_TDA.Location = new Point(0, 0);
            groupBoxGrid_TDA.Name = "groupBoxGrid_TDA";
            groupBoxGrid_TDA.Size = new Size(1123, 485);
            groupBoxGrid_TDA.TabIndex = 0;
            groupBoxGrid_TDA.TabStop = false;
            groupBoxGrid_TDA.Text = "Квартиры";
            groupBoxGrid_TDA.Enter += groupBoxGrid_TDA_Enter;
            // 
            // dataGridViewApartments_TDA
            // 
            dataGridViewApartments_TDA.AllowUserToAddRows = false;
            dataGridViewApartments_TDA.AllowUserToDeleteRows = false;
            dataGridViewApartments_TDA.AllowUserToResizeRows = false;
            dataGridViewApartments_TDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewApartments_TDA.Dock = DockStyle.Fill;
            dataGridViewApartments_TDA.Location = new Point(3, 19);
            dataGridViewApartments_TDA.Name = "dataGridViewApartments_TDA";
            dataGridViewApartments_TDA.RowHeadersVisible = false;
            dataGridViewApartments_TDA.Size = new Size(1117, 463);
            dataGridViewApartments_TDA.TabIndex = 0;
            dataGridViewApartments_TDA.CellEndEdit += dataGridViewApartments_TDA_CellEndEdit;
            dataGridViewApartments_TDA.CellValidating += dataGridViewApartments_TDA_CellValidating;
            dataGridViewApartments_TDA.DataError += dataGridViewApartments_TDA_DataError;
            // 
            // toolStripTable_TDA
            // 
            toolStripTable_TDA.Dock = DockStyle.None;
            toolStripTable_TDA.Items.AddRange(new ToolStripItem[] { toolStripLabelFind_TDA, toolStripTextBoxFilter_TDA });
            toolStripTable_TDA.Location = new Point(3, 0);
            toolStripTable_TDA.Name = "toolStripTable_TDA";
            toolStripTable_TDA.Size = new Size(159, 25);
            toolStripTable_TDA.TabIndex = 1;
            // 
            // toolStripLabelFind_TDA
            // 
            toolStripLabelFind_TDA.Name = "toolStripLabelFind_TDA";
            toolStripLabelFind_TDA.Size = new Size(45, 22);
            toolStripLabelFind_TDA.Text = "Поиск:";
            // 
            // toolStripTextBoxFilter_TDA
            // 
            toolStripTextBoxFilter_TDA.BorderStyle = BorderStyle.FixedSingle;
            toolStripTextBoxFilter_TDA.ForeColor = SystemColors.MenuText;
            toolStripTextBoxFilter_TDA.Name = "toolStripTextBoxFilter_TDA";
            toolStripTextBoxFilter_TDA.Size = new Size(100, 25);
            toolStripTextBoxFilter_TDA.ToolTipText = "Поиск по";
            toolStripTextBoxFilter_TDA.TextChanged += toolStripTextBoxFilter_TDA_TextChanged;
            // 
            // openFileDialogTable_TDA
            // 
            openFileDialogTable_TDA.FileName = "openFileDialogTable_TDA";
            openFileDialogTable_TDA.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // buttonAddRow_TDA
            // 
            buttonAddRow_TDA.Enabled = false;
            buttonAddRow_TDA.Image = (Image)resources.GetObject("buttonAddRow_TDA.Image");
            buttonAddRow_TDA.Location = new Point(26, 37);
            buttonAddRow_TDA.Name = "buttonAddRow_TDA";
            buttonAddRow_TDA.Size = new Size(46, 46);
            buttonAddRow_TDA.TabIndex = 2;
            buttonAddRow_TDA.TextImageRelation = TextImageRelation.ImageAboveText;
            toolTipMain_TDA.SetToolTip(buttonAddRow_TDA, "Добавить пустую строку в конце таблицы.");
            buttonAddRow_TDA.UseVisualStyleBackColor = true;
            buttonAddRow_TDA.Click += buttonAddRow_TDA_Click;
            // 
            // labelAverage_TDA
            // 
            labelAverage_TDA.AutoSize = true;
            labelAverage_TDA.Location = new Point(205, 86);
            labelAverage_TDA.Name = "labelAverage_TDA";
            labelAverage_TDA.Size = new Size(107, 15);
            labelAverage_TDA.TabIndex = 7;
            labelAverage_TDA.Text = "Среднее значение";
            labelAverage_TDA.TextAlign = ContentAlignment.MiddleCenter;
            toolTipMain_TDA.SetToolTip(labelAverage_TDA, "Удалить выделенные строки");
            // 
            // buttonAverage_TDA
            // 
            buttonAverage_TDA.Enabled = false;
            buttonAverage_TDA.Image = Properties.Resources.calculator;
            buttonAverage_TDA.Location = new Point(237, 37);
            buttonAverage_TDA.Name = "buttonAverage_TDA";
            buttonAverage_TDA.Size = new Size(46, 46);
            buttonAverage_TDA.TabIndex = 6;
            buttonAverage_TDA.TextImageRelation = TextImageRelation.ImageAboveText;
            toolTipMain_TDA.SetToolTip(buttonAverage_TDA, "Удалить выделенные строки");
            buttonAverage_TDA.UseVisualStyleBackColor = true;
            buttonAverage_TDA.Click += buttonAverage_TDA_Click;
            // 
            // panelButtons_TDA
            // 
            panelButtons_TDA.Controls.Add(labelAverage_TDA);
            panelButtons_TDA.Controls.Add(buttonAverage_TDA);
            panelButtons_TDA.Controls.Add(labelDeleteRows_TDA);
            panelButtons_TDA.Controls.Add(buttonDeleteRows_TDA);
            panelButtons_TDA.Controls.Add(labelAddRow_TDA);
            panelButtons_TDA.Controls.Add(buttonAddRow_TDA);
            panelButtons_TDA.Controls.Add(menuStripMain_TDA);
            panelButtons_TDA.Dock = DockStyle.Top;
            panelButtons_TDA.Location = new Point(0, 0);
            panelButtons_TDA.Name = "panelButtons_TDA";
            panelButtons_TDA.Size = new Size(1123, 112);
            panelButtons_TDA.TabIndex = 0;
            // 
            // checkBoxRow_TDA
            // 
            checkBoxRow_TDA.AutoSize = true;
            checkBoxRow_TDA.Location = new Point(165, 3);
            checkBoxRow_TDA.Name = "checkBoxRow_TDA";
            checkBoxRow_TDA.Size = new Size(118, 19);
            checkBoxRow_TDA.TabIndex = 6;
            checkBoxRow_TDA.Text = "Выделять строку";
            checkBoxRow_TDA.UseVisualStyleBackColor = true;
            checkBoxRow_TDA.CheckedChanged += checkBoxRow_TDA_CheckedChanged;
            // 
            // panelGrid_TDA
            // 
            panelGrid_TDA.Controls.Add(splitContainerTable_TDA);
            panelGrid_TDA.Dock = DockStyle.Fill;
            panelGrid_TDA.Location = new Point(0, 112);
            panelGrid_TDA.Name = "panelGrid_TDA";
            panelGrid_TDA.Size = new Size(1123, 514);
            panelGrid_TDA.TabIndex = 1;
            // 
            // splitContainerTable_TDA
            // 
            splitContainerTable_TDA.Dock = DockStyle.Fill;
            splitContainerTable_TDA.FixedPanel = FixedPanel.Panel2;
            splitContainerTable_TDA.IsSplitterFixed = true;
            splitContainerTable_TDA.Location = new Point(0, 0);
            splitContainerTable_TDA.Name = "splitContainerTable_TDA";
            splitContainerTable_TDA.Orientation = Orientation.Horizontal;
            // 
            // splitContainerTable_TDA.Panel1
            // 
            splitContainerTable_TDA.Panel1.Controls.Add(groupBoxGrid_TDA);
            // 
            // splitContainerTable_TDA.Panel2
            // 
            splitContainerTable_TDA.Panel2.Controls.Add(labelCount_TDA);
            splitContainerTable_TDA.Panel2.Controls.Add(checkBoxRow_TDA);
            splitContainerTable_TDA.Panel2.Controls.Add(toolStripTable_TDA);
            splitContainerTable_TDA.Size = new Size(1123, 514);
            splitContainerTable_TDA.SplitterDistance = 485;
            splitContainerTable_TDA.TabIndex = 6;
            // 
            // labelCount_TDA
            // 
            labelCount_TDA.AutoSize = true;
            labelCount_TDA.Cursor = Cursors.Hand;
            labelCount_TDA.ForeColor = Color.Blue;
            labelCount_TDA.Location = new Point(286, 4);
            labelCount_TDA.Name = "labelCount_TDA";
            labelCount_TDA.Size = new Size(140, 15);
            labelCount_TDA.TabIndex = 8;
            labelCount_TDA.Text = "Количество должников:";
            labelCount_TDA.Click += labelCount_TDA_Click;
            labelCount_TDA.MouseHover += labelCount_TDA_MouseHover;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 626);
            Controls.Add(panelGrid_TDA);
            Controls.Add(panelButtons_TDA);
            MainMenuStrip = menuStripMain_TDA;
            Name = "FormMain";
            Text = "Домоуправление";
            menuStripMain_TDA.ResumeLayout(false);
            menuStripMain_TDA.PerformLayout();
            groupBoxGrid_TDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewApartments_TDA).EndInit();
            toolStripTable_TDA.ResumeLayout(false);
            toolStripTable_TDA.PerformLayout();
            panelButtons_TDA.ResumeLayout(false);
            panelButtons_TDA.PerformLayout();
            panelGrid_TDA.ResumeLayout(false);
            splitContainerTable_TDA.Panel1.ResumeLayout(false);
            splitContainerTable_TDA.Panel2.ResumeLayout(false);
            splitContainerTable_TDA.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerTable_TDA).EndInit();
            splitContainerTable_TDA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxGrid_TDA;
        private DataGridView dataGridViewApartments_TDA;
        private OpenFileDialog openFileDialogTable_TDA;
        private MenuStrip menuStripMain_TDA;
        private ToolStripMenuItem ToolStripMenuItemFile_TDA;
        private ToolStripMenuItem toolStripMenuItemOpenFile_TDA;
        private ToolStripMenuItem ToolStripMenuItemSave_TDA;
        private ToolStripMenuItem ToolStripMenuItemAbout_TDA;
        private ToolStripMenuItem ToolStripMenuItemHelp_TDA;
        private ToolStrip toolStripTable_TDA;
        private ToolStripTextBox toolStripTextBoxFilter_TDA;
        private ToolStripLabel toolStripLabelFind_TDA;
        private ToolStripMenuItem ToolStripMenuItemCreate_TDA;
        private Label labelAddRow_TDA;
        private ToolTip toolTipMain_TDA;
        private Label labelDeleteRows_TDA;
        private Button buttonDeleteRows_TDA;
        private Button buttonAddRow_TDA;
        private Panel panelButtons_TDA;
        private Panel panelGrid_TDA;
        private SplitContainer splitContainerTable_TDA;
        private CheckBox checkBoxRow_TDA;
        private Label labelCount_TDA;
        private Label labelAverage_TDA;
        private Button buttonAverage_TDA;
    }
}
