using Tyuiu.MironenkoSE.Sprint4.Task7.V6.Lib;
namespace Tyuiu.MironenkoSE.Sprint4.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "458963214789";
            DataService ds = new DataService();
            int sum = ds.Calculate(3, 4, input);
            Console.WriteLine("Сумма нечетных чисел в матрице: " + sum);
        }
    }
}
    

