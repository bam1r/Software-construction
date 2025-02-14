using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp3;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main()
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<VeterinaryClinic>()
            .AddSingleton<Zoo>()
            .BuildServiceProvider();
        
        var zoo = serviceProvider.GetService<Zoo>();

        zoo.AddAnimal(new Monkey(1, "Обезьянка Чарли", 2, 6));
        zoo.AddAnimal(new Rabbit(2, "Кролик Питер", 1, 7));
        zoo.AddAnimal(new Tiger(3, "Тигр Шерхан", 8));
        zoo.AddAnimal(new Wolf(4, "Волк Грей", 5));

        zoo.AddThing(new Table(101, "Стол для корма"));
        zoo.AddThing(new Computer(102, "Компьютер для учета"));
        
        Console.WriteLine();
        zoo.PrintFoodConsumption();
        Console.WriteLine();
        zoo.PrintInteractiveAnimals();
        Console.WriteLine();
        zoo.PrintInventory();
        
        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Добавить животное");
            Console.WriteLine("2. Вывести отчет о потреблении корма");
            Console.WriteLine("3. Вывести список контактных животных");
            Console.WriteLine("4. Вывести инвентарные номера");
            Console.WriteLine("5. Выход");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Введите имя животного: ");
                    string name = Console.ReadLine();
                    Console.Write("Введите количество потребляемой еды (кг): ");
                    if (!int.TryParse(Console.ReadLine(), out int food))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Некорректный ввод, попробуйте снова.");
                        break;
                    }
                    Console.Write("Введите уровень доброты (0-10, если применимо): ");
                    if (!int.TryParse(Console.ReadLine(), out int kindness))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Некорректный ввод, попробуйте снова.");
                        break;
                    }
                    zoo.AddAnimal(new NewAnimal(new Random().Next(1000), name, food, kindness));
                    break;
                case "2":
                    zoo.PrintFoodConsumption();
                    break;
                case "3":
                    zoo.PrintInteractiveAnimals();
                    break;
                case "4":
                    zoo.PrintInventory();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Некорректный ввод, попробуйте снова.");
                    break;
            }
        }
    }
}
