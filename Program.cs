using System;

class Program
{
    static void Main()
    {
        int number;
        Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number % 29 == 0) {
            Console.WriteLine($"{number} - четное число.");
        } else {
            Console.WriteLine($"{number} - нечётное число.");
        }
    }

}
