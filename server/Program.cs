using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №4");
            Console.WriteLine("Приветствие: Добро пожаловать в программу!");
            Console.WriteLine($"ФИО: Стренин Денис Олегович");
            Console.WriteLine($"Группа: ИСП-231");
            Console.WriteLine($"Текущая дата и время: {DateTime.Now}");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nМеню");
                Console.WriteLine("1 — Показать ФИО");
                Console.WriteLine("2 — Показать группу");
                Console.WriteLine("3 — Показать дату");
                Console.WriteLine("4 — Выход");
                Console.Write("Выберите пункт: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("ФИО: Стренин Денис Олегович");
                        break;
                    case "2":
                        Console.WriteLine("Группа: ИСП-231");
                        break;
                    case "3":
                        Console.WriteLine($"Текущая дата и время: {DateTime.Now}");
                        break;
                    case "4":
                        Console.WriteLine("Выход из программы...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}