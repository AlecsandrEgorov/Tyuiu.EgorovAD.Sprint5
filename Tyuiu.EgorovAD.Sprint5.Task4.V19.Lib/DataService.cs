using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.EgorovAD.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double x = Convert.ToDouble(strx);
            double res = Math.Round(Math.Pow((x / Math.Cos(x)), 2), 3);
            return res;
        }
    }
}
