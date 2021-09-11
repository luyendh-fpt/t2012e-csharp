using System;
using System.Collections.Generic;
using T2012EHelloWorld.Entities;

namespace T2012EHelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // GenerateMenu(); // Ctrl + K -> Ctrl + C | Ctrl + K + Ctrl + U
            Student student = new Student();
            student.RollNumber = "A001";
            student.Name = "Hung";
            student.Email = "hung@gmail.com";
            Console.WriteLine(student.ToString());
        }

        private static void GenerateMenu()
        {
            while (true)
            {
                Console.WriteLine("Hello application");
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Say hello.");
                Console.WriteLine("2. Say goodbye.");
                Console.WriteLine("0. Exit.");
                Console.WriteLine("---------------------"); //clr ~ jvm
                Console.WriteLine("Please enter your choice (1-3):");
                var choice = Convert.ToInt32(Console.ReadLine()); // new Scanner .nextLine, nextInt;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter your name: ");
                        var name =  Console.ReadLine();
                        Console.WriteLine($"Hello {name}");
                        break;
                    case 2:
                        Console.WriteLine("Nice to meet you.");
                        break;
                    case 0:
                        Console.WriteLine("Bye bye");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
                if (choice == 0)
                {
                    break;
                }
            }
        }
    }
}