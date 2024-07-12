using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toDoList = new List<string>();
            string userChoice;

            do
            {
                Console.Clear();
                Console.WriteLine("To-Do List Application");
                Console.WriteLine("=======================");
                Console.WriteLine("1. View To-Do List");
                Console.WriteLine("2. Add To-Do Item");
                Console.WriteLine("3. Remove To-Do Item");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        ViewToDoList(toDoList);
                        break;
                    case "2":
                        AddToDoItem(toDoList);
                        break;
                    case "3":
                        RemoveToDoItem(toDoList);
                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                if (userChoice != "4")
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

            } while (userChoice != "4");
        }

        static void ViewToDoList(List<string> toDoList)
        {
            Console.Clear();
            Console.WriteLine("To-Do List");
            Console.WriteLine("==========");
            if (toDoList.Count == 0)
            {
                Console.WriteLine("No items in the list.");
            }
            else
            {
                for (int i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {toDoList[i]}");
                }
            }
        }

        static void AddToDoItem(List<string> toDoList)
        {
            Console.Clear();
            Console.WriteLine("Add To-Do Item");
            Console.WriteLine("==============");
            Console.Write("Enter a new to-do item: ");
            string newItem = Console.ReadLine();
            toDoList.Add(newItem);
            Console.WriteLine("Item added successfully.");
        }

        static void RemoveToDoItem(List<string> toDoList)
        {
            Console.Clear();
            Console.WriteLine("Remove To-Do Item");
            Console.WriteLine("=================");
            ViewToDoList(toDoList);
            if (toDoList.Count > 0)
            {
                Console.Write("Enter the item number to remove: ");
                if (int.TryParse(Console.ReadLine(), out int itemNumber) && itemNumber > 0 && itemNumber <= toDoList.Count)
                {
                    toDoList.RemoveAt(itemNumber - 1);
                    Console.WriteLine("Item removed successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid item number.");
                }
            }
        }
    }
}
