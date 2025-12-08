using Tyuiu.EgorovAD.Sprint5.Task5.V8.Lib;
namespace Tyuiu.EgorovAD.Sprint5.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V19.txt";

            FileInfo file = new FileInfo(path);

            bool filesInf = file.Exists;

            bool wait = true;

            Assert.AreEqual(wait, filesInf);
        }
    }
}
