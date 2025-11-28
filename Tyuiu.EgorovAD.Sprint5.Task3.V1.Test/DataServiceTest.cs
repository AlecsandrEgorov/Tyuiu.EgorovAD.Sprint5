using Tyuiu.EgorovAD.Sprint5.Task3.V1.Lib;
namespace Tyuiu.EgorovAD.Sprint5.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Admin\AppData\Local\Temp\OutPutFileTask3.bin";

            FileInfo file = new FileInfo(path);

            bool filesInf = file.Exists;

            bool wait = true;

            Assert.AreEqual(wait, filesInf);
        }
    }
}
