using System.Data;
using System.Text;

namespace Tyuiu.TomilovDA.Sprint7.Project.V7.Lib
{
    public class DataService
    {
        public DataTable ReadCsvFile(string filePath)
        {
            DataTable dt = new DataTable();

            using (var reader = new StreamReader(filePath, Encoding.UTF8))
            {

                string headerLine = reader.ReadLine();
                if (headerLine == null)
                {
                    throw new Exception("Файл пуст или не содержит данных");
                }
                string[] headers = headerLine.Split(';');
                foreach (string header in headers)
                {
                    string head = header.Trim();
                    if (head == "Номер подъезда" || head == "Номер квартиры" || head == "Количество комнат" || head == "Количество членов семьи" || head == "Количество детей")
                    {
                        dt.Columns.Add(head, typeof(int));
                    }
                    else if (head == "Общая площадь" || head == "Полезная площадь")
                    {
                        dt.Columns.Add(head, typeof(double));
                    }
                    else if (head == "Дата прописки")
                    {
                        dt.Columns.Add(head, typeof(DateTime));
                    }
                    else
                    {
                        dt.Columns.Add(head, typeof(string));
                    }

                }

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line != null)
                    {
                        string[] values = line.Split(';');
                        DataRow row = dt.NewRow();
                        for (int i = 0; i < Math.Min(values.Length, dt.Columns.Count); i++)
                        {
                            string value = values[i].Trim();
                            if (!string.IsNullOrEmpty(value))
                            {
                                int n;
                                bool isNumerical = int.TryParse(value, out n);
                                double k;
                                bool isDouble = double.TryParse(value, out k);
                                DateTime f;
                                bool isDate = DateTime.TryParse(value, out f);
                                if (isDouble)
                                {
                                    if (isNumerical)
                                    {
                                        row[i] = n;
                                    }
                                    else
                                    {
                                        row[i] = k;
                                    }
                                }
                                else
                                {
                                    if (!isDate)
                                    {
                                        row[i] = value;
                                    }
                                    else
                                    {
                                        row[i] = f;
                                    }
                                }
                            }
                            else
                            {
                                row[i] = DBNull.Value;
                            }
                        }
                        dt.Rows.Add(row);
                    }
                }
            }
            return dt;
        }

        public DataTable CreateTable()
        {
            DataTable dt = new DataTable();
            string headerLine = "Номер подъезда;Номер квартиры;Общая площадь;Полезная площадь;Количество комнат;Фамилия квартиросъемщика;Дата прописки;Количество членов семьи;Количество детей;Есть задолженность;Примечание";
            string[] headers = headerLine.Split(';');
            foreach (string header in headers)
            {
                string head = header.Trim();
                if (head == "Номер подъезда" || head == "Номер квартиры" || head == "Количество комнат" || head == "Количество членов семьи" || head == "Количество детей")
                {
                    dt.Columns.Add(head, typeof(int));
                }
                else if (head == "Общая площадь" || head == "Полезная площадь")
                {
                    dt.Columns.Add(head, typeof(double));
                }
                else if (head == "Дата прописки")
                {
                    dt.Columns.Add(head, typeof(DateTime));
                }
                else
                {
                    dt.Columns.Add(head, typeof(string));
                }

            }
            dt.Rows.Add();
            return dt;
        }

        public bool IsNumericType(Type type)
        {
            return type == typeof(int) || type == typeof(double) || type == typeof(decimal) || type == typeof(float);
        }
    }
}
