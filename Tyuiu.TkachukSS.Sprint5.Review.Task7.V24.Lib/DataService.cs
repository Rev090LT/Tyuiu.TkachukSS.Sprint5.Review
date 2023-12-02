using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text.RegularExpressions;
using System.IO;
namespace Tyuiu.TkachukSS.Sprint5.Review.Task7.V24.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {            
            string str = File.ReadAllText(path);
            string put = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V24.txt";
            string pattern = @"\b[а-яА-Я]+\b";
            string result = Regex.Replace(str, pattern, "слово");
            File.WriteAllText(put, result); 
            return put;
        }
    }
}
