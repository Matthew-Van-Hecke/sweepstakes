using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

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
                    AlertWinner(contestants[i]);
                }
                else
                {
                    AlertOtherContestant(i, winner.FirstName, contestants[i].FirstName);
                }
            }
        }
        public MimeMessage CreateWinnerMessage(string name, string email)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Me", "sweepstakes@example.com"));
            message.To.Add(new MailboxAddress(name, email));
            message.Subject = "You won!";
            message.Body = new TextPart("plain")
            {
                Text = @"Congratulations, " + name + "! You won the sweepstakes!"
            };
            return message;
        }
        public void SendEmail(MimeMessage message)
        {
            using (SmtpClient client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("smtp.gmail.com", 587, false);

                client.Authenticate("vhmatt245@gmail.com", "HotDog89");

                client.Send(message);
                client.Disconnect(true);
            }
        }
        public void AlertWinner(Contestant winner)
        {
            MimeMessage message = CreateWinnerMessage(winner.FirstName + winner.LastName, winner.Email);
            SendEmail(message);
        }
        public void AlertOtherContestant(int registrationNumber, string winnerFirstName, string loserFirstName)
        {
            Console.WriteLine(registrationNumber + " " + loserFirstName + ", thank you for participating! You lost. Congratualtions to " + winnerFirstName + " for winning!");
        }
    }
}
