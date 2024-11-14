using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MironenkoSE.Sprint4.Task6.V17.Lib
{
    public class DataServiceTest : ISprint4Task6V17
    {
        public int Calculate(string[] array)
        {
            int count = 1;
            foreach (var item in array)
            {
                if (item.Length > 7)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
        
    

