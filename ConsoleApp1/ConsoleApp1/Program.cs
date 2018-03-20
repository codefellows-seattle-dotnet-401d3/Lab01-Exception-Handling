using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Greetin take this quiz! about me");
          
       
            if (Username() == "tiger") {
                Console.WriteLine("correct");
            }

            if (petAnswer() == "yes")
            {
                Console.WriteLine("yes I have a dog");
            }

        }

        // each its own method, asking the user their name
        static string Username()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }

        //asking user if I have a pet?
        static string petAnswer()
        {
            Console.WriteLine("Do you think I have a dog or cat? yes or no");
            return Console.ReadLine();
        }

        //asking favorite color
        static string favColor()
        {
            Console.WriteLine("What is my favorite color?");
            return Console.ReadLine();
        }
        // asking number of fingers
        static int userAge()
        {
            Console.WriteLine("Guess how many fingers I have?");
            return Convert.ToByte(Console.ReadLine());
        }

        //type of car 
        static string typeOfCar()
        {
            Console.WriteLine("what type of car do I have?");
            return Console.ReadLine(); 
        }


    }
}
