using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MolodchikovEE.Sprint4.Task6.V15.Lib
{
    public class DataService : ISprint4Task6V15
    {
        public int Calculate(string[] array)
        {

            string[] shortCities = Array.FindAll(array, city => city.Length < 7);
            int a = shortCities.Length;

            return a;
        }
    }
}
