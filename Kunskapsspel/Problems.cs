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
        public string answerFormat;
        public string solution;
        private const string problemsFileName = "./Resources/Problems.txt";
        private const string solutionFileName = "./Resources/Solution.txt";
        
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

            problem = File.ReadLines(problemsFileName).Skip(line).Take(1).First();

            string[] diviadedLine = File.ReadLines(solutionFileName).Skip(line).Take(1).First().Split(';');

            answerFormat = diviadedLine[0];
            solution = diviadedLine[1];
        }
    }
}
