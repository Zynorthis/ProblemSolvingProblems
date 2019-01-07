using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problem_Solving_Problems
{
    class ProblemThree
    {
        List<string> classGrades = new List<string>()
        {
        "80,100,92,89,65",
        "93,81,78,84,69",
        "73,88,83,99,64",
        "98,100,66,74,55"
        };

        public void ProblemThreeProblem()
        {
            int i = 0;
            List<int> listedNumbersParsed = new List<int>();
            while (i < classGrades.Count)
            {
                var tempStringVariable = classGrades[i].Split(',');
                tempStringVariable.OrderByDescending(g => g);
                var tempStringArray = tempStringVariable.ToArray();
                int iterator = 0;
                while (iterator < tempStringArray.Length)
                {
                    listedNumbersParsed.Add(Int32.Parse(tempStringArray[iterator]));
                    iterator++;
                }
                i++;
            }
            var result = listedNumbersParsed.Average(g => g);
            Console.WriteLine(result);
        }
    }
}
