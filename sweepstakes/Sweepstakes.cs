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
        int startingRegistrationNumber;
        Random random;
        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            startingRegistrationNumber = 1000;
            nextRegistrationNumberToUse = startingRegistrationNumber;
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
        public void AlertAllContestantsOfResults(Contestant winner)
        {
            for (int i = startingRegistrationNumber; i < nextRegistrationNumberToUse; i++)
            {
                if (contestants[i].Equals(winner))
                {
                    AlertWinner(contestants[i].FirstName);
                }
                else
                {
                    AlertOtherContestant(i, winner.FirstName, contestants[i].FirstName);
                }
            }
        }
        public void AlertWinner(string winnerFirstName)
        {
            Console.WriteLine("Congratualtions, " + winnerFirstName + "! You won!");
        }
        public void AlertOtherContestant(int registrationNumber, string winnerFirstName, string loserFirstName)
        {
            Console.WriteLine(registrationNumber + " " + loserFirstName + ", thank you for participating! You lost. Congratualtions to " + winnerFirstName + " for winning!");
        }
    }
}
