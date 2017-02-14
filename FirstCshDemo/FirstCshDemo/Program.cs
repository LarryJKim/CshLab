
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World from C#");
            //Console.WriteLine("Type Something!");

            //string input = Console.ReadLine(); //blocking call

            //Console.WriteLine("You typed " + input);
            //Console.WriteLine(String.Format("You typed {0}", input));

            while (true)
            {
                if (Console.KeyAvailable) //Prevents the ReadKey call below from blocking the loop.
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.I)
                    {
                        Console.WriteLine("You typed the 'I' key");
                    }
                }

                Console.WriteLine("Listening...");
                Thread.Sleep(200);

            }

            Console.Read();

        }
    }
}
