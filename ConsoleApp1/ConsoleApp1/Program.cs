using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Greetin take this quiz! about me");

            Username();
          
            if (petAnswer() == "yes");
            {
                Console.WriteLine("yes I have a dog");
            }
        
            if (favColor() == "blue")
            {
                Console.WriteLine("yes that is correct");
            }
            else
            {
                Console.WriteLine("its blue");
            }

            
            if (userAge() == 30)
            {
                Console.WriteLine("yes that is correct");
            }

          
            if (typeOfCar() == "toyota")
            {
                Console.WriteLine("yes that is correct");
            }
            else
            {
                Console.WriteLine("Nope it is Japanese Car tho!");

            }

          
        }



        /* static void catchException()
         {
             int number;
             try
             {
                 Console.WriteLine("enter a number!");
                 number = Convert.ToByte(Console.ReadLine());

             }
             catch (Exception e)
             {

             }

         }
         */


        // each its own method, asking the user their name
        static void Username()
        {
                Console.WriteLine("What is your name?");
                String Name = Console.ReadLine();
                Console.WriteLine("Hello" +" " + Name);
                Console.ReadKey();

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
