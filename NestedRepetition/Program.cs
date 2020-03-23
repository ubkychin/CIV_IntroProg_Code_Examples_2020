using System;

namespace NestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Rudy";

            int counter = 0;

            while (counter < 10) {
                counter++;

                int counter2 = counter;

                while (counter2 < 5) {
                    System.Console.Write(name);

                    counter2++;
                }

                System.Console.WriteLine();
            }

            System.Console.Write("Goodbye " + name);



        }
    }
}
