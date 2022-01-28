using System;

namespace Coditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TutorialIfElse();
            //TutorialSwitch();
        }

        private static void TutorialSwitch()
        {
            var number = 15;
            switch (number)
            {
                case 15:
                    Console.WriteLine("Number is 15");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                case 25:
                    Console.WriteLine("Number is 25");
                    break;
                default:
                    Console.WriteLine("Number's not 15 or 20 or 25");
                    break;

            }
        }

        private static void TutorialIfElse()
        {
            var number = 15;
            if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else if (number == 50)
            {
                Console.WriteLine("Number is 50");
            }
            else
            {
                Console.WriteLine("Number's not 20 or 50");
            }
        }
    }
}
