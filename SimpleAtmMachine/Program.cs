using System;
using System.Text;

namespace SimpleAtmMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sets the title of the Console
            Console.Title = "The Revolutionary ATM";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Please Enter your Pin: ");
            string pin = Console.ReadLine();

            RequestPin();


            Console.ReadLine();
        }

        private static string RequestPin()
        {
            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);

                if (!char.IsControl(keyInfo.KeyChar))
                {
                    sb.Append(keyInfo.KeyChar);
                    Console.Write('*');
                }


            } while (true);
        }
    }
}

