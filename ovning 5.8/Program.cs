using System;
using System.Threading;

namespace övning_5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] talArray = { 12345, 67890, 54321, 98765, 24680 };

            foreach (int tal in talArray)
            {
                string talSträng = tal.ToString();

                for (int i = 0; i < talSträng.Length; i++)
                {
                    Console.WriteLine(talSträng[i]);
                    Thread.Sleep(500); // Kort paus mellan varje siffra
                }

                Thread.Sleep(2000); // Lite längre paus mellan varje tal
            }
        }
    }
}
