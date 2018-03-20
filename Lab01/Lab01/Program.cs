using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            score += QuestionOne();
            bool qTwo = QuestionTwo();
            if(qTwo == true)
            {
                score += 1;
            }
            string qThree = QuestionThree();
            if (qThree == "Alexander")
            {
                score += 1;
            }
            score += QuestionFour();
            score += QuestionFive();

            Console.WriteLine($"All done\nYour score is {score} out of 5");
            Console.ReadLine();
        }

        static int QuestionOne()
        {
            try
            {
                Console.WriteLine("How many courses have I taken at Code fellows?");
                string userInput = Console.ReadLine();
                if (userInput == "2")
                {
                    Console.WriteLine("Thats right!");
                    Console.ReadLine();
                    return 1;
                }
                else
                {
                    Console.WriteLine("Sorry that's not right");
                    Console.ReadLine();
                    return 0;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Pleaes enter a b c or d");
                return 0;
            }
        }

        static bool QuestionTwo()
        {
            try
            {
                Console.WriteLine("Do I drive or Bus to Code Fellows?");
                Console.WriteLine("a) Yes\nb) No");
                string userInput = Console.ReadLine();
                if (userInput == "a")
                {
                    Console.WriteLine("Thats right!");
                    Console.ReadLine();
                    return true;
                }
                else
                {
                    Console.WriteLine("Sorry that's not right");
                    Console.ReadLine();
                    return false;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Pleaes enter a or b");
                return false;
            }
        }

        static string QuestionThree()
        {
            try
            {
                Console.WriteLine("Can you guess my middle name? (Hint: It starts with an A)");
                string userInput = Console.ReadLine();
                if (userInput == "Alexander")
                {
                    Console.WriteLine("Thats right!");
                    Console.ReadLine();
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Sorry that's not right");
                    Console.ReadLine();
                    return "nope";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somthing went wrong. I don't know what you did.");
                return "exception";
            }
        }

        static int QuestionFour()
        {
            try
            {
                Console.WriteLine("What is my current video game of choice? (When I have time)");
                Console.WriteLine("a) Surviving Mars\nb) Vermintide\nc) Overwatch\nd) Into the Breach");
                string userInput = Console.ReadLine();
                if (userInput == "a")
                {
                    Console.WriteLine("Thats right!");
                    Console.ReadLine();
                    return 1;
                }
                else
                {
                    Console.WriteLine("Sorry that's not right");
                    Console.ReadLine();
                    return 0;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Pleaes enter a b c or d");
                return 0;
            }
        }

        static int QuestionFive()
        {
            try
            {
                Console.WriteLine("What kind of car do I drive?");
                Console.WriteLine("a) Explorer\nb) Leaf\nc) GTI\nd) Mustang");
                string userInput = Console.ReadLine();
                if (userInput == "b")
                {
                    Console.WriteLine("Thats right!");
                    Console.ReadLine();
                    return 1;
                }
                else
                {
                    Console.WriteLine("Sorry that's not right");
                    Console.ReadLine();
                    return 0;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Pleaes enter a b c or d");
                return 0;
            }
        }
    }
}
