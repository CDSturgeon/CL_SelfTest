using System;
using System.Text;

namespace CL_SelfTets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "I", "Love", "C#", "Programming" };

            Console.WriteLine(StringLoop(array));
            Console.ReadKey();

            var me= new ComputerProgrammer("Cory");
            Console.WriteLine($"{me.Name} {me.DoWork(8)}");
            Console.ReadKey();

        }

        static string StringLoop(string[] array)
        {
            var text = new StringBuilder();

            foreach (string item in array)
                text.Append(item + " ");

            return text.ToString();
        }
    }
}

