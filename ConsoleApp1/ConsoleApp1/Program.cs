using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Greetin take this quiz! about me");

            Username();
            Console.WriteLine("HIT ENTER");
            Console.Clear();
            petAnswer();
            favColor();
            favNumber();
            typeCar();
            NumberOfFeet();
            Console.ReadKey();
            Console.WriteLine("bye.........bye" );
        }

        // each its own method, asking the user their name
        static void Username()
        {
                Console.WriteLine("What is your name?");
                String Name = Console.ReadLine();
                Console.WriteLine("Hello" +" " + Name);
                Console.ReadKey();

        }


        //asking user if I have a pet?
        static void petAnswer()
        {
            try
            {
                Console.WriteLine("Do you think I have a dog or cat? yes or no");
                var HavePet = (Console.ReadLine().ToUpper());
                Console.WriteLine(HavePet);
                if (HavePet == "YES")
                {
                    Console.WriteLine("thats Correct");
                }
                else
                {
                    Console.WriteLine("Nope I did have a dog");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Please answer yes or no");
                throw;
            }
        }


        //asking favorite Color
        static void favColor()
        {
            try
            {
                Console.WriteLine("What is my favorite Color?");
                Console.WriteLine(" pick one red blue yellow green");
                var HaveColor = (Console.ReadLine().ToUpper());
                if (HaveColor == "Blue")
                {
                    Console.WriteLine("thats Correct Blue is my Favorite Color");
                }
                else
                {
                    Console.WriteLine("Nope I dont like that Color");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Please answer with a color");
                throw;
            }
        }

        //asking what my favorite number is
        static void favNumber()
        {
            try
            {
                Console.WriteLine("What is my favorite number?");
                Console.WriteLine(" 1 2 3 4 5 6 7 8 9 10");
                var HaveNumber = (Console.ReadLine().ToUpper());
                if (HaveNumber == "5")
                {
                    Console.WriteLine(" FIve is my favorite number");
                }
                else
                {
                    Console.WriteLine("Not the correct number");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Please answer with a number");
                throw;
            }
        }


        static void typeCar()
        {
            try
            {
                Console.WriteLine("What type of car do I have?");
                Console.WriteLine("pick a brand");
                var HaveNumber = (Console.ReadLine().ToUpper());
                if (HaveNumber == "Toyota")
                {
                    Console.WriteLine(" YESS that is type of car I drive");
                }
                else
                {
                    Console.WriteLine("Not the correct brand");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Please type somthing in");
                throw;
            }
        }


        static void NumberOfFeet()
        {
            try
            {
                Console.WriteLine("How many feet do I have?");
                var HaveNumber = (Console.ReadLine().ToUpper());
                if (HaveNumber == "2")
                {
                    Console.WriteLine("That is correct I have only 2 feet");
                }
                else
                {
                    Console.WriteLine(" You think I really have more than a left and right foot?");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Please answer with either 1 or 2");
                throw;
            }

            


        }
      

        //Bottom of the Main class
    }
}
