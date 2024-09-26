using Tyuiu.MolodchikovEE.Sprint4.Task5.V26.Lib;
namespace Tyuiu.MolodchikovEE.Sprint4.Task5.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы. (генератор случайных чисел)                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайны*");
            Console.WriteLine("*ыми значениями в диапазоне от -4 до 4. Заменить положительные элементы на*");
            Console.WriteLine("*а 1.                                                                     *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[,] array = new int[5, 5];

            Console.WriteLine("Введите 25 чисел для заполнения массива 5x5 (от 2 до 9):");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int value;
                    while (true)
                    {
                        Console.Write($"Введите элемент [{i}, {j}]: ");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out value) && value >= 2 && value <= 9)
                        {
                            array[i, j] = value;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: введите число от 2 до 9.");
                        }
                    }

                }
            }
            var result = ds.Calculate(array);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}