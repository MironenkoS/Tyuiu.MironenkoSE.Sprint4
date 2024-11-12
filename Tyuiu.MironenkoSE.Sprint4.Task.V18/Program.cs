using Tyuiu.MironenkoSE.Sprint4.Task2.V22.Lib;
namespace Tyuiu.MironenkoSE.Sprint4.Task3.V18;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Мироненко С.Э. | АСОиУб-24-1";
           
        Console.WriteLine("***************************************************************************");                                     
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Мироненко Сергей Эдуардович | АСОиУб-24-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* статическими значениями в диапазоне от 3 до 7. Подсчитайте количество   *");
        Console.WriteLine("* четных элементов во всем массиве.                                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        int[,] numsArray = new int[5, 5] { { 2, 4, 2, 7, 7},   
                                           { 4, 7, 9, 9, 7 },
                                           { 8, 5, 5, 6, 5 },
                                           { 7, 7, 5, 2, 9 },
                                           { 9, 3, 7, 9, 8 } };

        int rows = numsArray.GetUpperBound(0) + 1;
        int colums = numsArray.Length / rows;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write($"{numsArray[i, j]}\t\t\t\t");
            }
        }


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = ds.Calculate(numsArray);

        Console.WriteLine(" Количество всех четных элементов массива = " + result);
        Console.ReadKey();
    }
}
    


