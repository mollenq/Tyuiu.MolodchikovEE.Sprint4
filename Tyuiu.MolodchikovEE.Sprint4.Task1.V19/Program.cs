using Tyuiu.MolodchikovEE.Sprint4.Task1.V19.Lib;
namespace Tyuiu.MolodchikovEE.Sprint4.Task1.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы. (ввод с клавиатуры)                                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан одномерный целочисленный массив на 12 элементов заполненный значениям*");
            Console.WriteLine("*ми с клавиатуры в диапазоне от 2 до 9 подсчитать сумму четных элементов м*");
            Console.WriteLine("*массива.  С клавиатуры: 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4               *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int[] array = new int[12];

            for (int i = 0; i < 12; i++) 
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();



            var result = ds.Calculate(array);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}