using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.TomilovDA.Sprint7.Project.V7.Lib;

namespace Tyuiu.TomilovDA.Sprint7.Project.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            dataGridViewApartments_TDA.MultiSelect = true;
            dataGridViewApartments_TDA.AllowUserToAddRows = false;
        }
        public DataTable dt = new DataTable();
        DataService ds = new DataService();
        private void LoadCsvToDataGridView(string filePath)
        {
            try
            {
                dt = ds.ReadCsvFile(filePath);
                dataGridViewApartments_TDA.Columns.Clear();
                dataGridViewApartments_TDA.DataSource = dt;
                foreach (DataGridViewColumn column in dataGridViewApartments_TDA.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� �������� �����: " + ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void toolStripMenuItemOpenFile_TDA_Click(object sender, EventArgs e)
        {
            if (openFileDialogTable_TDA.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogTable_TDA.FileName;
                LoadCsvToDataGridView(filePath);
                buttonAddRow_TDA.Enabled = true;
                buttonDeleteRows_TDA.Enabled = true;
                buttonAverage_TDA.Enabled = true;
                UpdateCountLabel();
            }
        }


        private void SearchDataViewHighlight(string searchValue)
        {
            if (!(dataGridViewApartments_TDA.DataSource is DataTable dt)) return;


            dataGridViewApartments_TDA.ClearSelection();
            ClearHighlight();

            if (string.IsNullOrEmpty(searchValue))
            {
                dt.DefaultView.RowFilter = "";
                return;
            }

            string filterExpression = string.Join(" OR ", dt.Columns.Cast<DataColumn>().Select(c => $"Convert([{c.ColumnName}], 'System.String') LIKE '%{searchValue}%'"));
            try
            {
                dt.DefaultView.RowFilter = filterExpression;

                if (dt.DefaultView.Count == 0)
                {
                    MessageBox.Show("���������� �� �������.");
                    return;
                }


                foreach (DataGridViewRow row in dataGridViewApartments_TDA.Rows)
                {
                    if (row.Visible)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Contains(searchValue))
                            {
                                row.Cells[i].Style.BackColor = Color.Yellow;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ����������: {ex.Message}");
                dt.DefaultView.RowFilter = "";
            }
        }

        private void ClearHighlight()
        {
            foreach (DataGridViewRow row in dataGridViewApartments_TDA.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }
        }

        private void toolStripTextBoxFilter_TDA_TextChanged(object sender, EventArgs e)
        {
            SearchDataViewHighlight(toolStripTextBoxFilter_TDA.Text);
        }

        private void ToolStripMenuItemAbout_TDA_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = ds.CreateTable();
            dataGridViewApartments_TDA.Columns.Clear();
            dataGridViewApartments_TDA.DataSource = dt;
            foreach (DataGridViewColumn column in dataGridViewApartments_TDA.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            UpdateCountLabel();
            buttonAddRow_TDA.Enabled = true;
            buttonDeleteRows_TDA.Enabled = true;
            buttonAverage_TDA.Enabled = true;
        }

        private void dataGridViewApartments_TDA_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            throw new Exception("����� �������� ��� ������.");
        }


        private void dataGridViewApartments_TDA_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue == null || string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                return;
            }

            DataGridViewCell cell = dataGridViewApartments_TDA.Rows[e.RowIndex].Cells[e.ColumnIndex];
            Type cellType = cell.ValueType;
            if (cellType == null)
            {
                return;
            }


            try
            {
                if (cellType == typeof(int))
                {
                    int.Parse(e.FormattedValue.ToString());
                }
                else if (cellType == typeof(double))
                {
                    double.Parse(e.FormattedValue.ToString());
                }
                else if (cellType == typeof(DateTime))
                {
                    DateTime.Parse(e.FormattedValue.ToString());
                }
                else if (cellType == typeof(bool))
                {
                    bool.Parse(e.FormattedValue.ToString());
                }
            }
            catch (Exception)
            {
                e.Cancel = true;
                if (cellType != null)
                {
                    var defaultValue = cellType.IsValueType ? Activator.CreateInstance(cellType) : null;
                    cell.Value = defaultValue;
                }
                else
                {
                    cell.Value = null;
                }
                if (cellType != null)
                {
                    if (cellType == typeof(int))
                    {
                        MessageBox.Show($"����� �������� ��� ������. ���� ������� ������������ ������ ����� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (cellType == typeof(double))
                    {
                        MessageBox.Show($"����� �������� ��� ������. ���� ������� ������������ ������ �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (cellType == typeof(DateTime))
                    {
                        MessageBox.Show($"����� �������� ��� ������. ���� ������� ������������ ������ ����. ���������� ����: ��.��.����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"�������� ��� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            UpdateCountLabel();
        }



        private void buttonDeleteRows_TDA_Click(object sender, EventArgs e)
        {
            if (dataGridViewApartments_TDA.SelectedRows.Count > 0)
            {
                var rowsToDelete = dataGridViewApartments_TDA.SelectedRows.Cast<DataGridViewRow>().ToList();
                foreach (DataGridViewRow row in rowsToDelete)
                {
                    DataRowView dataRowView = (DataRowView)row.DataBoundItem;
                    if (dataRowView != null)
                    {
                        dataRowView.Row.Delete();
                    }
                }
                dt.AcceptChanges();

                if (dt.Rows.Count == 0)
                {
                }
                UpdateCountLabel();
            }
            else
            {
                MessageBox.Show("��� ���������� ����� ��� ��������.", "�����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void buttonAddRow_TDA_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.NewRow();
            dt.Rows.Add(newRow);
            UpdateCountLabel();
        }

        private void ToolStripMenuItemSave_TDA_Click(object sender, EventArgs e)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("������� �����. ��� ������ ��� ����������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    using (var writer = new StreamWriter(filePath))
                    {
                        string headerRow = string.Join(";", dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName));
                        writer.WriteLine(headerRow);

                        foreach (DataRow row in dt.Rows)
                        {
                            string rowValues = string.Join(";", row.ItemArray.Select(value => value?.ToString() ?? ""));
                            writer.WriteLine(rowValues);
                        }
                    }

                    MessageBox.Show($"������ ������� ��������� � {filePath}", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� ���������� �����: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBoxRow_TDA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRow_TDA.Checked)
            {
                dataGridViewApartments_TDA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                dataGridViewApartments_TDA.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }

        private int CountValuesInColumn(int column, string targetValue)
        {
            int count = 0;
            if (dataGridViewApartments_TDA.DataSource is DataTable dt)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row[column]?.ToString() == targetValue)
                    {
                        count++;
                    }

                }
            }

            return count;
        }
        private void UpdateCountLabel()
        {
            try
            {
                if (dt.Columns.Count >= 10)
                {
                    string targetValue = "���� �������������";

                    int count = CountValuesInColumn(9, targetValue);
                    labelCount_TDA.Text = $"���������� ���������: {count}";
                }
            }
            catch
            {

            }
        }


        private void labelCount_TDA_Click(object sender, EventArgs e)
        {
            if (dataGridViewApartments_TDA.DataSource is DataTable dataTable)
            {
                FormChart formChart = new FormChart(dt);
                formChart.Show();
            }
            else
            {
                MessageBox.Show("��� ������ ��� ����������� ���������.", "�����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private double? CalculateAverageOfSelectedCells()
        {
            if (dataGridViewApartments_TDA.SelectedCells.Count == 0)
            {
                MessageBox.Show("��� ���������� �����.", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            Type firstCellType = dataGridViewApartments_TDA.SelectedCells[0].ValueType;
            if (firstCellType == null)
            {
                MessageBox.Show("�� ������� ���������� ��� ������ ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            foreach (DataGridViewCell cell in dataGridViewApartments_TDA.SelectedCells)
            {
                if (cell.ValueType == null)
                {
                    MessageBox.Show("��� ������ ���������� ����� �� ����� ���� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                if (cell.ValueType != firstCellType || !ds.IsNumericType(cell.ValueType))
                {
                    MessageBox.Show("��� ������ ���������� ����� ������ ���� ���� � ��� �� � ������ ���� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            double sum = 0;
            int count = 0;

            foreach (DataGridViewCell cell in dataGridViewApartments_TDA.SelectedCells)
            {
                if (cell.Value != null && double.TryParse(cell.Value.ToString(), out double cellValue))
                {
                    sum += cellValue;
                    count++;
                }
            }

            if (count > 0)
            {
                return sum / count;
            }
            else
            {
                MessageBox.Show("��� ������ ��� �������� �������� ��������.", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private void buttonAverage_TDA_Click(object sender, EventArgs e)
        {
            double? average = CalculateAverageOfSelectedCells();
            if (average.HasValue)
            {
                MessageBox.Show($"������� ��������: {average.Value:F2}", "������� ��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ToolStripMenuItemHelp_TDA_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.Show();
        }
    }
}
