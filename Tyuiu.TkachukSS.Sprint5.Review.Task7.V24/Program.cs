using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TkachukSS.Sprint5.Review.Task7.V24.Lib;
namespace Tyuiu.TkachukSS.Sprint5.Review.Task7.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Ткачук С. С. | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Ревью по спринт 5                                                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Ткачук Семён Сергеевич | РПСб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine($@"*     Дан файл С:\DataSprint5\InPutDataFileTask7V24.txt " +
                                "(файл взять из архива согласно вашему варианту. " +
                                @"Создать папку в ручную С:\DataSprint5\ и скопировать в неё файл) в " +
                                "котором есть набор символьных данных." +
                                @"Заменить все русские слова на слово слово. ");                                 
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V24.txt";
            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.LoadDataAndSave(path);

            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
