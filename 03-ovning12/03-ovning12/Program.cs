using System;
using System.Collections.Generic;

namespace _03_ovning12
{
    class Program
    {
        static List<string> todo = new List<string>();
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.Clear();
                PrintMenu();
                Console.Write("Enter option: ");
                option = int.Parse(Console.ReadLine());
                if (option == 0)
                {
                    //Anropa metod som skriver ut listan
                }
                else if (option == 1)
                {
                    //Anropa en metod som lägger till i lista
                }
                else if (option == 2)
                {
                    //Anropa metod som tar bort översta i lista
                }
                else if (option == 3)
                {
                    //Anropa metod som tar bort på viss position
                }
                else if (option == 4)
                {
                    //Anropa metod som lägger till på viss position
                }
            } while (option != -1);
        }
        static void PrintMenu()
        {
            Console.WriteLine("********* Menu *********");
            Console.WriteLine("* 0. View ToDo-list *");
            Console.WriteLine("* 1. Add item *");
            Console.WriteLine("* 2. Remove item *");
            Console.WriteLine("* 3. Remove item #n *");
            Console.WriteLine("* 4. Insert at #n *");
            Console.WriteLine("* -1. Exit *");
            Console.WriteLine("************************");
        }
    }
}
