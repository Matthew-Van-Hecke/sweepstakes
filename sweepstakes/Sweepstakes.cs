using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Sweepstakes
    {
        //Member Variables
        private Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        public Dictionary<int, Contestant> Contestants
        {
            get { return contestants; }
        }
        private string name;
        public string Name
        {
            get { return name; }
        }
        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        //Member Methods
        public void RegisterContestant()
        {
            Contestant contestant = new Contestant();
            contestants[contestant.RegistrationNumber] = contestant;
        }
    }
}
