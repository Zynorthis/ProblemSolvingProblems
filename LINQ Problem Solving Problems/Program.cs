using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problem_Solving_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which problem would you like to see the result for?");
            int userInput = Int32.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    {
                        Console.Clear();
                        ProblemOne problemOneObject = new ProblemOne();
                        problemOneObject.ProblemOneProblem();
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        ProblemTwo problemTwoObject = new ProblemTwo();
                        problemTwoObject.ProblemTwoProblem();
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        ProblemThree problemTwoObject = new ProblemThree();
                        problemTwoObject.ProblemThreeProblem();
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        ProblemFour problemFourObject = new ProblemFour();
                        problemFourObject.ProblemFourProblem();
                        Console.ReadKey();
                        break;
                    }
                default:
                    Console.WriteLine("Input has to be 1, 2, 3, or 4");
                    break;
            }  
        }
    }
}
