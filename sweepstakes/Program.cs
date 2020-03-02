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
            for (int i = 0; i < 7; i++)
            {
                sweepstakes.RegisterContestant();
            }
            sweepstakes.Contestants[123].PrintContestantInfo();
            sweepstakes.Contestants[456].PrintContestantInfo();
            sweepstakes.Contestants[678].PrintContestantInfo();
            sweepstakes.Contestants[789].PrintContestantInfo();
            sweepstakes.Contestants[890].PrintContestantInfo();
            sweepstakes.Contestants[345].PrintContestantInfo();
            sweepstakes.Contestants[246].PrintContestantInfo();
            Console.ReadLine();
        }
    }
}
