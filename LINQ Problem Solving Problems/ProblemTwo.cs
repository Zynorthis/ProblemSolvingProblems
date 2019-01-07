using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problem_Solving_Problems
{
    class ProblemTwo
    {
        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };

        public void ProblemTwoProblem()
        {
            var result = names.Distinct();

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
