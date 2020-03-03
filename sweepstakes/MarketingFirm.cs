using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class MarketingFirm
    {
        //Member Variables
        ISweepstakesManager manager;
        //Constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
        //Member Methods
        public void CreateSweepstake()
        {
            string sweepstakesName = UserInterface.GetUserInputFor("sweepstakes name");
            manager.InsertSweepstakes(new Sweepstakes(sweepstakesName));
        }        
    }
}
