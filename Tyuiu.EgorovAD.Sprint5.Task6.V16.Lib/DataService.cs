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
            int englishWordCount = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                char[] separators = " .,!?;:\t\n\r()[]{}'\"".ToCharArray();


                while ((line = reader.ReadLine()) != null)
                {
                    for ()
                        if (IsEnglishWordSimple(word))
                        {
                            englishWordCount++;

                        }
                }
            }
            return 6;
        }
    }
}
