using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoConsoleApp.Services
{
    internal class TodoServices
    {
        public static void AddTask()
        {

            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Description: ");
            string description = Console.ReadLine();

        }
    }
}
