using System;

namespace NestedRepetitionForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Rudy";

            for (int counter = 0; counter < 10; counter++) {

                for (int counter2 = counter; counter2 < 5; counter2++) {
                    System.Console.Write(name);
                }

                System.Console.WriteLine();
            }

            System.Console.Write("Goodbye " + name);
        }
    }
}
