using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    public class Sweepstakes
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
        public int NextRegistrationNumberToUse
        {
            get { return nextRegistrationNumberToUse; }
        }
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
            contestant.EnterContestantInfo();
            contestants[contestant.RegistrationNumber] = contestant;
            nextRegistrationNumberToUse++;
        }
        public Contestant PickWinner()
        {
            int randomNumber = random.Next(1000, nextRegistrationNumberToUse);
            return contestants[randomNumber];
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("\n" + contestant.FirstName + " " + contestant.LastName + "\n" + contestant.Email + "\n" + contestant.Address + "\n" + contestant.RegistrationNumber);
        }
    }
}
