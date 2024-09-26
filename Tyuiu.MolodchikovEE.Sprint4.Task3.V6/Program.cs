using Tyuiu.MolodchikovEE.Sprint4.Task3.V6.Lib;
namespace Tyuiu.MolodchikovEE.Sprint4.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы. (статический ввод)                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                            *");
            Console.WriteLine("* Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статичес*");
            Console.WriteLine("*скими значениями в диапазоне от 3 до 8. Найдите максимальный элемент во в*");
            Console.WriteLine("*второй строке массива. " +
                "8, 8, 3, 4, 5, " +
                "8, 6, 6, 4, 6, " +
                "3, 6, 5, 3, 4, " +
                "5, 6, 3, 7, 5,*");
            Console.WriteLine("* 7, 8, 5, 6, 6,                                                          *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int[,] massiv = { { 8, 8, 3, 4, 5 }, { 8, 6, 6, 4, 6 }, { 3, 6, 5, 3, 4 }, { 5, 6, 3, 7, 5 }, { 7, 8, 5, 6, 6 } }; 


            var result = ds.Calculate(massiv);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}