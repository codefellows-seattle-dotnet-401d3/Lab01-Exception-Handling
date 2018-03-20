using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] questions = Questions();
            int correctAnswers = Ask(questions);
            Console.WriteLine("You got {0} right out of {1}", correctAnswers, questions.Length);
            Console.ReadLine();
        }

        static bool Correct(string answer, string correct)
        {
            answer = answer.ToUpper();
            correct = correct.ToUpper();
            if (answer == "YES" || answer == "T" || answer == "TRUE") answer = "Y";
            if (answer == "NO" || answer == "F" || answer == "FALSE") answer = "N";
            return answer == correct;
        }

        static int Ask(string[][] questions)
        {
            int correct = 0;
            foreach (string[] question in questions)
            {
                Console.WriteLine(question[0]);
                if (Correct(Console.ReadLine(), question[1]))
                    correct++;
            }
            return correct;
        }

        static string[][] Questions ()
        {
            //format of array: [0] question [1] correct answer as a string [2] message explaining the answer
            return new string[][]
            {
                new string[] {"How many continents has Brent lived on?", "3", "North America, Europe and Asia"},
                new string[] {"What is Brent's middle name?", "Michael", "Brent's initials are BMW. It used to be a joke that he was the only BMW his dad would ever have."},
            };
        }
    }
}
