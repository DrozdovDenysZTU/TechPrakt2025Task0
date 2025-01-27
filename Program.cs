using System;

class Program
{
    static void Main(string[] args)
    {
        // Запит першого числа
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        // Запит другого числа
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Обчислення суми
        double sum = number1 + number2;

        // Виведення результату 
        Console.WriteLine($"The sum of {number1} and {number2} is {sum}");
    }
}