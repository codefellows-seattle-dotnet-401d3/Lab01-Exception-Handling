using System;

/*
 * About Me Quiz, by Arthur Allen
 */

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int score = 0; //Score starts set to zero.

                Console.WriteLine("About Me Quiz");

                score += Question1();
                score += Question2();
                score += Question3();
                score += Question4();
                score += Question5();

                Console.WriteLine("");
                Console.WriteLine("Your final score is {0}!", score);
                Console.Read();
            }
            catch
            {
                Console.WriteLine("Oh look, an error.");
            }

        }

        
        static int Question1()
        {
            string answer;
            Console.WriteLine("");
            Console.WriteLine("Who am I, what am I doing here?");
            Console.WriteLine("");
            Console.WriteLine("Which of thsese are not one of my hobbies?");
            Console.WriteLine("1.) Local history");
            Console.WriteLine("2.) Drive-in theaters");
            Console.WriteLine("3.) Anthro animal fandom");
            Console.WriteLine("4.) Coding");
            answer = Console.ReadLine();
            if (answer == "4")
            {
                Console.WriteLine("Correct. Coding isn't a hobby, it's a career.");
                return 1;
            }
            else
            {
                Console.WriteLine("Wrong. Coding isn't a hobby, it's a career.");
                return -1;
            }
        }

        static int Question2()
        {
            string answer;
            Console.WriteLine("");
            Console.WriteLine("Which of the following are not a good reason why I have been stuck persuing the Abandoned Rails Facebook page these past months, instead of keeping my coding skills sharp?");
            Console.WriteLine("1.) It's fun to find something hidden that not many others would notice.");
            Console.WriteLine("2.) It's fun to think about how things have changed in the years since the rail line was active.");
            Console.WriteLine("3.) It's interesting to think about the engneering challenge of constructing a rail line, especially through rough terrain.");
            Console.WriteLine("4.) I'm addicted to Facebook likes.");
            answer = Console.ReadLine();
            if (answer == "4")
            {
                Console.WriteLine("Why oh why is Facebook so addictive?");
                return 1;
            }
            else
            {
                Console.WriteLine("No, those are all good reasons.");
                return -1;
            }

        }

        static int Question3()
        {
            string answer;
            Console.WriteLine("");
            Console.WriteLine("How much did a pirate pay for corn?");
            Console.WriteLine("1.) A dollahrrrr ninty eight.");
            Console.WriteLine("2.) A buck an ear.");
            Console.WriteLine("3.) Corn is in whiskey, not rum.");
            Console.WriteLine("4.) Why is he telling jokes in an About Me program?");
            answer = Console.ReadLine();
            if (answer == "4")
            {
                Console.WriteLine("It breaks the monotony of thinking up real 'about me' questions");
                return 1;
            }
            else
            {
                Console.WriteLine("All good answers");
                return 1;
            }
        }
        static int Question4()
        {
            string answer;
            Console.WriteLine("");
            Console.WriteLine("What is an ermine?");
            Console.WriteLine("1.) A royal dress.");
            Console.WriteLine("2.) A cute but viscious animal.");
            Console.WriteLine("3.) The first word of Arthur's screen name");
            Console.WriteLine("4.) Methinks it is like a weasel.");
            answer = Console.ReadLine();
  
            Console.WriteLine("All correct answers.");
            return 1;
        }

        static int Question5()
        {
            string answer;
            Console.WriteLine("");
            Console.WriteLine("This quiz is...");
            Console.WriteLine("1.) Too short.");
            Console.WriteLine("2.) Just right.");
            Console.WriteLine("3.) Too long.");
            Console.WriteLine("4.) Way too long.");
            answer = Console.ReadLine();
            if (answer == "4")
            {
                Console.WriteLine("4 is the only right answer");
                return 1;
            }
            else
            {
                Console.WriteLine("4 is the only right answer");
                return -1;
            }
        }
    }
}
