using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.EgorovAD.Sprint5.Task3.V1.Lib
{
    public class DataService : ISprint5Task3V1
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double z = (Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2));

            z = Math.Round(z, 2);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(BitConverter.GetBytes(z));    
            }
            return path;
        }
    }
}
