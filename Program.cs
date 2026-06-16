using System;

class Program
{
    static void Main(string[] args)
    {
        // Налаштування коректного відображення кирилиці в консолі
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Console.WriteLine("=== Система Empathix: Проєкт активовано ===");
        Console.WriteLine("Лабораторна робота №1 з Основ програмної інженерії.");
        
        Console.Write("Будь ласка, введіть ваше ім'я: ");
        string userName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(userName)) userName = "Користувач";
        
        Console.WriteLine($"\nВітаємо, {userName}!");

        // Тестування AI-функції
        Console.WriteLine("\n--- Модуль AI-аналізу тексту вимог ---");
        Console.Write("Введіть текст вимоги для аналізу: ");
        string requirement = Console.ReadLine();

        int wordCount = CountWords(requirement);
        Console.WriteLine($"Результат аналізу Empathix: знайдено {wordCount} слів.");

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }

    // Функція на C#, яка приймає рядок тексту і повертає кількість слів у ньому.
    // Якщо текст порожній, повертає 0.
    static int CountWords(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
