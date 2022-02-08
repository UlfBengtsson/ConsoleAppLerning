using System;

namespace ConsoleAppLerning
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepAlive = true;

            do
            {
                try
                {
                    Console.WriteLine("Run excersise by entering the number or -1 to exit.");

                    int selection = int.Parse(Console.ReadLine() ?? "0");

                    switch(selection)
                    {
                        case 1:
                            Exercise1();
                            break;

                        case 2:
                            Exercise2();
                            break;
                        //more cases as you progress doing the excersises.

                        case -1:
                            keepAlive = false;
                            Console.WriteLine("Thanks for using the program.");
                            break;
                        default:
                            Console.WriteLine("Was not a valid selection.");
                            break;
                    }

                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                catch
                {
                    Console.WriteLine("Exception has occured.");
                }

            } while (keepAlive);
        }//main method

        static void Exercise1()
        {
            Console.WriteLine("replace this with exercies");
        }

        static void Exercise2()
        {
            Console.WriteLine("replace this with exercies");
        }

    }//class
}//namespace