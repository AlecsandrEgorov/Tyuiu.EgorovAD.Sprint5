using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.EgorovAD.Sprint5.Task6.V16.Lib
{
    public class DataService : ISprint5Task6V16
    {
        public int LoadFromDataFile(string path)
        {
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");



            string text = File.ReadAllText(path);



            char[] separators = " .,!?;:\t\n\r()[]{}'\"".ToCharArray();
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int englishWordCount = 0;


            foreach (string word in words)
            {
                if (IsEnglishWordSimple(word))
                {
                    englishWordCount++;

                }
            }
            File.WriteAllText(outputFile, Convert.ToString(englishWordCount));
            return englishWordCount;
        }

        static bool IsEnglishWordSimple(string word)
        {

            foreach (char c in word)
            {
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                {
                    return false;
                }
            }
            return word.Length > 0;
        }

    }
}
