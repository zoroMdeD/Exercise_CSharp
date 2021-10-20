using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    class ReadFile
    {
        private string path = "null";

        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }
        public ReadFile(string path = @"D:\STUDIES\C#_exercise\Exercise_14\WordsStockRus.txt")
        {
            Path = path;
        }
        
        public int CountStingToFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    int count = 0;
                    while (sr.ReadLine() != null)
                    {
                        count++;
                    }
                    return count;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }

        public char[] MakeGuess(int count)
        {
            int cnt = 0;
            string line = "null";
            var rand = new Random();
            int change = rand.Next(0, count + 1);

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    cnt++;
                    if (change == cnt)
                        break;
                }
                sr.Close();
            }
            char[] mass = line.ToCharArray();
            return mass;
        }
    }
}                   
