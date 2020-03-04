using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes sweepstakes = new Sweepstakes("My Seepstakes");
            for (int i = 0; i < 3; i++)
            {
                sweepstakes.RegisterContestant();
            }
            sweepstakes.AlertAllContestantsOfResults(sweepstakes.PickWinner());
            Console.ReadLine();
        }
    }
}
