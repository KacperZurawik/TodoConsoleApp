using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {    
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. Mark as done");
                Console.WriteLine("3. See all tasks");
                Console.WriteLine("4. Exit");

                string menuOptionChoice = Console.ReadLine();

                switch (menuOptionChoice)
                {
                    case "1":
                        break;
                    
                    case "2":
                        break;
                    
                    case "3":
                        break;

                    case "4":
                        running = false;
                        break;
                }
            }
        }
    }
}
