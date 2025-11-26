using Tyuiu.EgorovAD.Sprint5.Task1.V19.Lib;
namespace Tyuiu.EgorovAD.Sprint5.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("startValue: " + startValue);
            Console.WriteLine("stopValue: " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
