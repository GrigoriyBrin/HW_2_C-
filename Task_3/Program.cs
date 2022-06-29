// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели от 1 до 7");
            int a = Convert.ToInt32(Console.ReadLine());
            int min = 0;
            int max = 8;
            int b = 5;


            if (a > min)
            {
                if (a < max)
                {
                    if (a > b)
                    {
                        Console.WriteLine("Да");
                    }
                    else
                    {
                        Console.WriteLine("Нет");
                    }
                }
            }
        }
    }
}
