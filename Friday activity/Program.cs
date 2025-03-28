using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Exit");
            Console.Write("Please select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                AddTask();
            }
            else if (choice == "2")
            {
                ViewTasks();
            }
            else if (choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }

    // Method to add task
    static void AddTask()
    {
        Console.Write("Enter the task: ");
        string task = Console.ReadLine();
        string filePath = "tasks.txt";

        try
        {
            // Append the task to the tasks.txt file
            File.AppendAllText(filePath, task + Environment.NewLine);
            Console.WriteLine("Task added successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Method to view tasks
    static void ViewTasks()
    {
        string filePath = "tasks.txt";

        try
        {
            if (File.Exists(filePath))
            {
                string[] tasks = File.ReadAllLines(filePath);

                if (tasks.Length == 0)
                {
                    Console.WriteLine("No tasks available.");
                }
                else
                {
                    Console.WriteLine("Your Tasks:");
                    foreach (string task in tasks)
                    {
                        Console.WriteLine(task);
                    }
                }
            }
            else
            {
                Console.WriteLine("No tasks file found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
