// TroubleShooting Oscar Norén Fullstackutvecklare NET25
using System;
using System.Globalization;
using System.Security.Cryptography;

namespace TroubleShooting {

    class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Felhantering: Välj mellan 1-7");
                Console.WriteLine(" 1: Number \n 2: For-loop 1-100 \n 3: For-loop in a for-loop  \n 4: For-loop in a while-loop \n 5: Switch-case \n 6: If-statement \n 7: End program");
                string choice = Console.ReadLine();

                switch (choice) {

                    case "1":
                        Assignment1();
                        break;
                    case "2":
                        Assignment2();
                        break;
                    case "3":
                        Assignment3();
                        break;
                    case "4":
                        Assignment4();
                        break;
                    case "5":
                        Assignment5();
                        break;
                    case "6":
                        Assignment6();
                        break;

                    case "7":
                        EndProgram();
                        break;

                    default:
                        Console.WriteLine("Välj mellan 1-6");
                        break;
                }

            }
            static void Assignment1()
            {
                int number = 2;

                if (number > 3)
                {
                    //Forgot the ; at the end of the writeline
                    Console.WriteLine("Talet är större än tre");
                }
                //else if are two words not one
                else if (number < 3)
                {
                    Console.WriteLine("Talet är mindre än tre");
                }
            }

            static void Assignment2()
            {
                //changed i < 100 to <= 100 so that its either smaller or equal to 100 instead of ending at 99
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(i);
               }
            }

            static void Assignment3()
            {
                //Added i++ and j++ where it just stood i and j
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }

            static void Assignment4()
            {
                int i = 1;
                while (i <= 5)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        //Write needs an argument to work, so leaving it empty will not work
                        Console.Write(j + " ");
                    }

                    Console.WriteLine();
                    i++;
                }
            }

            static void Assignment5()
            {
                int i = 1;

                switch (i)
                {
                    //case 1: added break because it didn't have it before
                    case 1:
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    default:
                        Console.WriteLine("Other");
                        break;
                }
            }

            static void Assignment6()
            {
                int i = 10;
                //When i = 5 you coming into conflict with the i = 10 
                //therefore for the if-statment to work you need i == 5
                if (i == 5)
                {
                    Console.WriteLine("i är 5");
                }

            }

            static void EndProgram()
            {
                Console.WriteLine("Avslutar program");
                Environment.Exit(0);
            }
        }
    }
}








