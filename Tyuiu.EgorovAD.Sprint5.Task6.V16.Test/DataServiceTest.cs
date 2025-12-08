using Tyuiu.EgorovAD.Sprint5.Task6.V16.Lib;
namespace Tyuiu.EgorovAD.Sprint5.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask6V16.txt");

            FileInfo file = new FileInfo(path);

            bool filesInf = file.Exists;

            bool wait = true;

            Assert.AreEqual(wait, filesInf);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask6V16.txt";

            var res = ds.LoadFromDataFile(path);

            int wait = 6;

            Assert.AreEqual(wait, res);
        }
    }
}
