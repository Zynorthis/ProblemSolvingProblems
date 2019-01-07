using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problem_Solving_Problems
{
    class ProblemFour
    {

        public void ProblemFourProblem()
        {
            Console.Write("Enter in your un-organized ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("HOT ");
            Console.ResetColor();
            Console.Write("mess of a word: ");
            string userInput = Console.ReadLine();

            var result = userInput.OrderBy(r => r);
            var frequency = result.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            foreach (var item in frequency)
            {
                Console.Write(item.Key);
                Console.Write(item.Value);
            }
        }
    }
}
