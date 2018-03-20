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
            int correctAnswers = AskAll(questions);
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

        static int AskAll(string[][] questions)
        {
            int correct = 0;
            foreach (string[] question in questions)
            {

                if (Correct(Ask(question), question[1]))
                    correct++;
            }
            return correct;
        }

        static string Ask(string[] question)
        {
            string userAnswer;
            try
            {
                Console.WriteLine(question[0]);
                userAnswer = Console.ReadLine();
                if (userAnswer == null || userAnswer == "" || userAnswer == "\n")
                    throw new Exception("invalid question answer");
            }
            catch
            {
                Console.WriteLine("Invald input. Try again.");
                userAnswer = Ask(question);
            }
            finally
            {
                Console.WriteLine(question[2]);
            }
            return userAnswer;
        }

        static string[][] Questions ()
        {
            //format of array: [0] question [1] correct answer as a string [2] message explaining the answer
            return new string[][]
            {
                new string[] {
                    "How many continents has Brent lived on?",
                    "3",
                    "North America, Europe and Asia"
                },
                new string[] {
                    "What is Brent's middle name?",
                    "Michael",
                    "Brent's initials are BMW. It used to be a joke that he was the only BMW his dad would ever have."
                },
                new string[]
                {
                    "Brent loves chess. What is the name of the current (March 2018) world chess champion? (first and last name)",
                    "Magnus Carlsen",
                    "Magnus Carlsen got the title in 2013 in a match against Viswanathan Anand."
                }
            };
        }
    }
}
