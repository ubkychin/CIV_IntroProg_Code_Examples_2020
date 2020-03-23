using System;

namespace Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Judy";

            int counter = 0;

            if (name == "Rudy") {
                while (counter < 5) {
                    System.Console.WriteLine(name);

                    // counter = counter + 1;
                    counter++;
                }
            } else {
                System.Console.WriteLine("Sorry you're not Rudy, no while loop");
            }

            Console.WriteLine("Goodbye " + name);

        }
    }
}
