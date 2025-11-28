using Tyuiu.EgorovAD.Sprint5.Task4.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask4V19.txt";

        Console.WriteLine("Данные находятся в " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}