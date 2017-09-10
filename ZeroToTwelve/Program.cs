using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace ZeroToTwelve
{
    class Program
    {
        static void Main(string[] args)
        {
            var ps = new ProblemSolver();

            var timer = System.Diagnostics.Stopwatch.StartNew();
            ps.DoIt(0, ProblemSolver.Level.ONE);
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);
            FileWriter.CSV("results.csv", ps.Answers, ps.AnswersHeader);
            Console.Read();
        }
    }
}
