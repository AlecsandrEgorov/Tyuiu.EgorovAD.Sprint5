using System.IO;
using Tyuiu.EgorovAD.Sprint5.Task7.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask7V3.txt";

        Console.WriteLine("Данные находятся в " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Находится в файле: ");

        string res = ds.LoadDataAndSave(path);

        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан");
        Console.ReadKey();



    }
}