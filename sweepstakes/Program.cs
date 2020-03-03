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
            Simulation simulation = new Simulation();
            ISweepstakesManager manager = simulation.PickManagerType();
            Console.WriteLine(manager.GetType());
            Console.ReadLine();
        }
    }
}
