using System.IO;
using Tyuiu.EgorovAD.Sprint5.Task7.V3.Lib;
namespace Tyuiu.EgorovAD.Sprint5.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");
            FileInfo file = new FileInfo(outputFile);

            bool filesInf = file.Exists;

            bool wait = true;

            Assert.AreEqual(wait, filesInf);
        }
    }
}
