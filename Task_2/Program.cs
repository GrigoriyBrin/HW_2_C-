// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = a.ToString();
            int countSymbol = 3;
            
            if (b.Length < countSymbol)
            {
                Console.WriteLine("Третьей цифры нет");
            }
            
            else
            {
                Console.WriteLine("Result: " + b[2]);
            }
            
           
        }
    }
}
