using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TomilovDA.Sprint7.Project.V7;

namespace Tyuiu.TomilovDA.Sprint7.Project.V7
{
    public partial class FormChart : Form
    {
        public FormChart(DataTable dt)
        {
            InitializeComponent();
            int hasDebtCount = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row[9]?.ToString() == "Есть задолженность")
                {
                    hasDebtCount++;
                }

            }
            int noDebtCount = dt.Rows.Count - hasDebtCount;
            int totalCount = dt.Rows.Count;
            double hasDebtPercentage = 0;
            double noDebtPercentage = 0;
            if (totalCount > 0)
            {
                hasDebtPercentage = Math.Round((double)hasDebtCount / totalCount * 100, 2);
                noDebtPercentage = Math.Round((double)noDebtCount / totalCount * 100, 2);
            }
            chartDebtorCount_TDA.Series[0].Points.AddXY("Есть задолженность", hasDebtCount);
            chartDebtorCount_TDA.Series[0].Points.AddXY("Нет задолженности", noDebtCount);

            labelHasDebtCount_TDA.Text = $"Количество должников: {hasDebtCount}";
            labelNoDebtCount_TDA.Text = $"Количество не должников: {noDebtCount}";
            labelHasDebtPercent_TDA.Text = $"Должники (%): {hasDebtPercentage}%";
            labelNoDebtPercent_TDA.Text = $"Не должники (%): {noDebtPercentage}%";
        }

        private void labelNoDebtPercent_TDA_Click(object sender, EventArgs e)
        {

        }
    }
}
