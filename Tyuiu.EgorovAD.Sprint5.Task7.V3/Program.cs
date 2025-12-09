using Tyuiu.EgorovAD.Sprint5.Task7.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask7V3.txt";
        string outputFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");

        Console.WriteLine("Данные находятся в " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Находится в файле: ");
        Console.WriteLine(outputFile);
        Console.WriteLine("Результат: ");

        string res = ds.LoadDataAndSave(path);

        Console.WriteLine(res);

    }
}