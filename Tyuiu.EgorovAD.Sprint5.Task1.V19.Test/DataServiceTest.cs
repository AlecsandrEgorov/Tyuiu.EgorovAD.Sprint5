using Tyuiu.EgorovAD.Sprint5.Task1.V19.Lib;
namespace Tyuiu.EgorovAD.Sprint5.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Xeon\AppData\Local\Temp\OutPutFileTask1.txt";

            FileInfo file = new FileInfo(path);

            bool filesInf = file.Exists;

            bool wait = true;

            Assert.AreEqual(wait, filesInf);
        }
    }
}
