using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== Система Empathix: Проєкт активовано ===");
        Console.WriteLine("Лабораторна робота №1 з Основ програмної інженерії.");
        Console.Write("Будь ласка, введіть ваше ім'я: ");

        string userName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userName))
        {
            userName = "Користувач";
        }

        Console.WriteLine($"\nВітаємо, {userName}! Модуль збору вимог та аналізу налаштовано успішно.");
        Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}
