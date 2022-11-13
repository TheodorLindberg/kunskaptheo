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
        public List<int> problemOrder;

        public Problems()
        {
            CreateProblem();
        }

        private void CreateProblem()
        {
            if (File.ReadAllLines(problemsFileName).Length != File.ReadAllLines(solutionFileName).Length)
                return;

            problemOrder = Enumerable.Range(0,File.ReadAllLines(problemsFileName).Length).ToList();

            int line = problemOrder[0];

            problemOrder.RemoveAt(0);

            problem = File.ReadLines(problemsFileName).Skip(line).Take(1).First();

            string[] diviadedLine = File.ReadLines(solutionFileName).Skip(line).Take(1).First().Split(';');

            answerFormat = diviadedLine[0];
            solution = diviadedLine[1];
        }
        
        private static readonly Random rng = new Random();

        public static void Shuffle(List<int> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                (list[n], list[k]) = (list[k], list[n]);
            }
        }
    }
}
