using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Simulation
    {
        public ISweepstakesManager PickManagerType()
        {
            string sweepstakesType = UserInterface.GetUserInputFor("sweepstakes manager type (stack or queue)");
            switch (sweepstakesType)
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    throw new Exception();
            }
        }
    }
}
