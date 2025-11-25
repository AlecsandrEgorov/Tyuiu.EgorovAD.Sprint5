using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.EgorovAD.Sprint5.Task0.V2.Lib
{
    public class DataService : ISprint5Task0V2
    {
        public string SaveToFileTextData(int x)
        {
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            double y = Math.Pow(Math.Exp(1), x) / x;

            y = Math.Round(y, 3);

            File.WriteAllText(outputFile, Convert.ToString(y));   
            
            return outputFile;


        }
    }
}
