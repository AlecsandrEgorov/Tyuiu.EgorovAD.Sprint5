using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
namespace Tyuiu.EgorovAD.Sprint5.Task7.V3.Lib
{
    public class DataService : ISprint5Task7V3
    {
        public string LoadDataAndSave(string path)
        {
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");

            if (File.Exists(outputFile))
            {
                File.Delete(outputFile);
            }

            StringBuilder totalResult = new StringBuilder();
            string strline = "";

            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    strline = "";

                    foreach (char currentChar in line)
                    {
                        bool isRussianLetter = (currentChar >= 'А' && currentChar <= 'Я') ||
                                               (currentChar >= 'а' && currentChar <= 'я') ||
                                               currentChar == 'Ё' || currentChar == 'ё';

                        if (!isRussianLetter)
                        {
                            strline += currentChar;
                        }
                    }

                    File.AppendAllText(outputFile, strline + Environment.NewLine, Encoding.UTF8);

                    totalResult.Append(strline);
                }
            }

            return totalResult.ToString();
        }
    }
}