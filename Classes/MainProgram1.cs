using Program1;
using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int choice = 0;
                var stopwatch = new Stopwatch();
                Console.WriteLine("Enter your choice: 1.Start 2.Stop 3.Quit");
                while (choice != 3)
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            stopwatch.Start();
                            break;
                        case 2:
                            stopwatch.Stop();
                            Console.WriteLine("Total duration is: {0}", stopwatch.Duration);
                            break;
                        case 3: break;
                    }
                }
                Console.WriteLine("Thanks for using Stopwatch.");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("The stopwatch has been started already.");
            }
            
            
        }     
    }
}
