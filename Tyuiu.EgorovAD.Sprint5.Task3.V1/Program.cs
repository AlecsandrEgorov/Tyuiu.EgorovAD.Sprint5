using Tyuiu.EgorovAD.Sprint5.Task3.V1.Lib;
internal class Program

{
    private static void Main(string[] args)
    {
        int x = 3;
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("X = " + x);

        string res = ds.SaveToFileTextData(x);

        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан");
        Console.ReadKey();
    }
}