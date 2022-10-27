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
        private string problemsFileName = "./Resources/Problems.txt";
        private string solutionFileName = "./Resources/Solution.txt";
        
        public Problems()
        {
            CreateProblem();
        }

        private void CreateProblem()
        {
            if (File.ReadAllLines(problemsFileName).Length != File.ReadAllLines(solutionFileName).Length)
                return;

            Random random = new Random();
            int line = random.Next(File.ReadAllLines(problemsFileName).Length);

            problem = File.ReadLines("./Resources/Problems.txt").Skip(line).Take(1).First();
            solution = File.ReadLines("./Resources/Solution.txt").Skip(line).Take(1).First();
        }
    }
}
