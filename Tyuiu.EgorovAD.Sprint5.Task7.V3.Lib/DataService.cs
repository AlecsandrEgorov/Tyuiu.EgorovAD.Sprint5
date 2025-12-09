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

            FileInfo fileInfo = new FileInfo(outputFile);

            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(outputFile);
            }

            string strline = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        char currentChar = line[i];


                        bool isRussianLetter = (currentChar >= 'А' && currentChar <= 'Я') ||
                                               (currentChar >= 'а' && currentChar <= 'я') ||
                                               currentChar == 'Ё' || currentChar == 'ё';

                        if (!isRussianLetter)
                        {
                            strline += currentChar;
                        }
                    }
                }
                File.AppendAllText(outputFile, strline + Environment.NewLine);
                strline = "";

            }
            return strline;
        }
    }
}