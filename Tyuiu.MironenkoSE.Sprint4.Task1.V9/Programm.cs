using Tyuiu.MironenkoSE.Sprint4.Task1.V9.Lib;
namespace Tyuiu.MironenkoSE.Sprint4.Task1.V9
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Мироненко С.Э. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                        *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                                                     *");
            Console.WriteLine("* Задание #1                                                                                       *");
            Console.WriteLine("* Вариант #9                                                                                       *");
            Console.WriteLine("* Выполнила: Мироненко С.Э. | АСОиУБ - 24-1                                                        *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов, заполненный статическими значениями в       *");
            Console.WriteLine("* диапазоне от 4 до 9 подсчитать произведение нечетных элементов массива                           *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            int len;
            Console.WriteLine("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("Введите значение " + i + " элементов массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1; ++i)
            {
                Console.Write(numsArray[i] + " \t " + " \t ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Произведение нечетных элементов массива равна: " + res);
            Console.ReadKey();
        }
    }
}
