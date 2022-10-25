using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Kunskapsspel
{
    internal class Problems
    {
        public string problem;
        public string solution;
        StreamReader problemReader = new StreamReader("./Resources/Problems.txt");
        StreamReader solutionReader = new StreamReader("./Resources/Solution.txt");

        public Problems()
        {
            CreateProblem();
        }

        private void CreateProblem()
        {
            if (problemReader.ReadToEnd().Length != solutionReader.ReadToEnd().Length)
                return;

            Random random = new Random();
            int line = random.Next(problemReader.ReadToEnd().Length);

            problem = File.ReadLines("./Resources/Problems.txt").Skip(line).Take(1).First();
            solution = File.ReadLines("./Resources/Solution.txt").Skip(line).Take(1).First();

        }
    }
}
