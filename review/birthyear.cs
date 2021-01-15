using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your age : ");
            string age = Console.In.ReadLine();
            int Iage = int.Parse(age);
            DateTime today = DateTime.Today;
            int datebirth = today.Year - Iage;
            Console.WriteLine("your birthyear " + datebirth + ".");
            Console.ReadLine();
        }
    }
}
