using System;

namespace ExponentsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            string input;
            int number = 1;
            while (goOn)
            {

                bool valid = false;
                while (!valid)
                {


                    input = GetInput("Please Enter an Integer");
                    number = int.Parse(input);
                    if (number > 0)
                    {
                        if (number > Math.Cbrt(int.MaxValue))
                        {
                            valid = false;
                            Console.WriteLine("Invalid Entry, please enter a number whose cube is lower than the max integer value");
                        }

                        else valid = true;
                    }

                    else
                    {
                        valid = false;
                        Console.WriteLine("Invalid Entry, please enter a number greater than 0");
                    }
                }
                Console.WriteLine(number);
                string header = string.Format("{1,-10} {0,-10} {2,-10}", "Number", "Squared", "Cubed");
                string header2 = string.Format("{0,-10} {1,-10} {2,-10}", "======", "=======", "=====");
                Console.WriteLine(header);
                Console.WriteLine(header2);

                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(CreateRow(i));
                }
                goOn = Continue();
            }
            
        }
        public static string CreateRow(int num)
        {
            int square = num * num;
            int cube = square * num;
            string result = string.Format("{0,-10} {1,-10} {2,-10}", num, square, cube);
            return result;
        }
        public static string GetInput(string prompt)
        {

            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }

        public static bool Continue()
        {
            string answer = GetInput("Would you like to continue? (y/n)").ToLower();
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("goodbye");
                return false;

            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand that");
                Console.WriteLine("Let's Try Again");
                return Continue();
            }
            
        }
    }
}
