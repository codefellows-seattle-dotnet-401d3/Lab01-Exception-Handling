using System;

namespace ConsoleApp1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Greetin take this quiz!");
            QuestionOne();

        }

        static void QuestionOne()
        {
            int UserAge, UserNum;
            string Username, UserColor, UserAnimal;

            Console.WriteLine("How old are you ?");
           UserAge = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("What is your name:?");
            Username = Convert.ToString(Console.ReadLine());

            Console.WriteLine("What is your favorite Color?");
            UserColor = Convert.ToString(Console.ReadLine());

            Console.WriteLine(" pick a number 1 or 2");
            UserNum = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Do you like Dogs or Cats?");
            UserAnimal = Convert.ToString(Console.ReadLine());

         
        }

       
    }
}
