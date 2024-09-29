using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BerezovskayaGO.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int k)
        {
            double res = k / 60 / 60;
            return (int)res;
        }
    }
}
