using Tyuiu.EgorovAD.Sprint5.Task0.V2.Lib;
namespace Tyuiu.EgorovAD.Sprint5.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\Users\Xeon\source\repos\Tyuiu.EgorovAD.Sprint5\Tyuiu.EgorovAD.Sprint5.Task0.V2\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo file = new FileInfo(path);

            bool filesInf = file.Exists;

            bool wait = true;

            Assert.AreEqual(wait, filesInf);
        }
    }
}
