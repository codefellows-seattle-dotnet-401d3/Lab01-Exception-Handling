using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Greetin take this quiz! about me");

            Username();
            Console.Clear();
            petAnswer();



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
