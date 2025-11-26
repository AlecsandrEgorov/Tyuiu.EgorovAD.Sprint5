using Tyuiu.EgorovAD.Sprint5.Task2.V4.Lib;
namespace Tyuiu.EgorovAD.Sprint5.Task2.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 5, -5, -6},
                            { 5, 6, -7},
                            { 7, 3, 5}};


            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {

                    Console.Write($"{matrix[i, j]} \t");   

                }

                Console.WriteLine(); 
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(matrix);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {

                    Console.Write($"{matrix[i, j]} \t");

                }

                Console.WriteLine();
            }
            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
