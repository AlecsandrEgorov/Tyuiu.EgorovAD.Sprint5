using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Linq;
namespace Tyuiu.EgorovAD.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {

            string content = File.ReadAllText(path);
            double res = 0;

            char[] separators = new char[] { ' ', ',', '\t', '\n', '\r', ';' };
            string[] parts = content.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            double? minValue = null;

            foreach (string part in parts)
            {
                if (double.TryParse(part.Trim(), System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out double number))
                {
                    if (!minValue.HasValue || number < minValue.Value)
                    {
                        minValue = number;
                        res = (double)minValue;
                    }
                }
            }
            return res;
        }
    }
}
