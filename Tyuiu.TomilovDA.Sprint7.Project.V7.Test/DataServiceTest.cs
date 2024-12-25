using System.Data;
using Tyuiu.TomilovDA.Sprint7.Project.V7.Lib;

namespace Tyuiu.TomilovDA.Sprint7.Project.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExists()
        {
            string filePath = "test.csv";
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                Assert.IsTrue(fileInfo.Exists);
            }
        }
        [TestMethod]
        public void ReadCsvFile_ValidFile()
        {
            DataService ds = new DataService();
            string filePath = "test.csv";
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                DataTable result = ds.ReadCsvFile(filePath);
                Assert.IsNotNull(result);
                Assert.IsTrue(result.Columns.Count > 0);
            }
            else
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void CheckIsNumericType()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.IsNumericType(typeof(double)));
            Assert.IsFalse(ds.IsNumericType(typeof(string)));
        }
    }
}