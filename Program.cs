using System;

class Program
{
    static void Main()
    {
        int number;
        Console.Write("Введите числ123123о: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number % 3 == 0) {
            Console.WriteLine($"{number} - четное число!");
        } else {
            Console.WriteLine($"{number} - нечётное число.");
        }
    }

}
