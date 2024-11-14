using Tyuiu.MironenkoSE.Sprint4.Task6.V17.Lib;
namespace Tyuiu.MironenkoSE.Sprint4.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sports = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

            DataService ds = new DataService();
            int result = ds.Calculate(sports);
            Console.WriteLine("Количество элементов, длина которых больше 6: " + result);
        }
    }
}