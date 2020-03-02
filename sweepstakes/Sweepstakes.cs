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
        int nextRegistrationNumberToUse;
        Random random;
        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            nextRegistrationNumberToUse = 1000;
            random = new Random();
        }
        //Member Methods
        public void RegisterContestant()
        {
            Contestant contestant = new Contestant(nextRegistrationNumberToUse);
            contestants[contestant.RegistrationNumber] = contestant;
            nextRegistrationNumberToUse++;
        }
        public Contestant PickWinner()
        {
            int randomNumber = random.Next(1000, nextRegistrationNumberToUse);
            return contestants[randomNumber];
        }
    }
}
