// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3-х значное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = a.ToString();
            int countSymbol = 4;
            
            if (b.Length < countSymbol)
            {
                Console.WriteLine("Result: " + b[1]);
            }
        }
    }
}
