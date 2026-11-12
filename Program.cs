using System;
using System.Collections.Generic;

List<string> tasks = new();

while (true)
{
    Console.WriteLine("\nTo-Do List Manager");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Remove");
    Console.WriteLine("3. List");
    Console.WriteLine("4. Quit");
    Console.Write("Choose an option: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter a task: ");
            string? task = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(task))
            {
                tasks.Add(task);
                Console.WriteLine("Task added.");
            }
            else
            {
                Console.WriteLine("Task cannot be empty.");
            }

            break;

        case "2":
            if (tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks to remove.");
                break;
            }

            Console.Write("Enter the task number to remove: ");

            if (int.TryParse(Console.ReadLine(), out int removeIndex) &&
                removeIndex >= 1 &&
                removeIndex <= tasks.Count)
            {
                tasks.RemoveAt(removeIndex - 1);
                Console.WriteLine("Task removed.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }

            break;

        case "3":
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                break;
            }

            Console.WriteLine("\nTasks:");

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }

            break;

        case "4":
            Console.WriteLine("Goodbye!");
            return;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}
