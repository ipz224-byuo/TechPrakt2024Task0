using System;

class Program
{
    static void Main(string[] args)
    {
        // Запитуємо у користувача перше число
        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Запитуємо у користувача друге число
        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Обчислюємо суму
        double sum = num1 + num2;

        // Виводимо результат
        Console.WriteLine($"Сума {num1} і {num2} дорівнює {sum}");

        // Щоб програма не закривалася відразу
        Console.ReadKey();
    }
}