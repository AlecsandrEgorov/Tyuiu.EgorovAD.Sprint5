using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Globalization;
namespace Tyuiu.EgorovAD.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double x = double.Parse(strx, CultureInfo.InvariantCulture);
            double res = Math.Round(Math.Pow((x / Math.Cos(x)), 2), 3);
            return res;
        }
    }
}
