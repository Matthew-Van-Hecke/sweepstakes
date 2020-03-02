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
            Random random = new Random();
            Sweepstakes sweepstakes = new Sweepstakes("My New Sweepstakes");
            for (int i = 0; i < 50; i++)
            {
                sweepstakes.RegisterContestant();
            }
            for (int i = 1000; i < 1050; i++)
            {
                sweepstakes.Contestants[i].PrintContestantInfo();
            }
            sweepstakes.PickWinner().PrintContestantInfo();
            Console.ReadLine();
        }
    }
}
