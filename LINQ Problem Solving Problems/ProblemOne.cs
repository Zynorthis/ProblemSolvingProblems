using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problem_Solving_Problems
{
    class ProblemOne
    {
        List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

        public void ProblemOneProblem()
        {
            var result = words.Where(w => w.Contains("th"));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
