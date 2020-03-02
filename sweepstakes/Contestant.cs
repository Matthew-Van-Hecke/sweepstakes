using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Contestant
    {
        //Member Variables
        string firstName;
        public string FirstName
        {
            get { return firstName; }
        }
        string lastName;
        string email;
        string address;
        int registrationNumber;
        public int RegistrationNumber
        {
            get { return registrationNumber; }
        }
        //Constructor
        public Contestant(int registrationNumber)
        {
            firstName = "John";
            lastName = "Doe";
            email = "john@gmail.com";
            address = "123 Expample Blvd.";
            this.registrationNumber = registrationNumber;
        }
        //Member Methods
        public void PrintContestantInfo()
        {
            Console.WriteLine("\n" + firstName + " " + lastName + "\n" + email + "\n" + address + "\n" + registrationNumber);
        }
        public void EnterContestantInfo()
        {
            firstName = UserInterface.GetUserInputFor("first name");
            lastName = UserInterface.GetUserInputFor("last name");
            email = UserInterface.GetUserInputFor("email");
            address = UserInterface.GetUserInputFor("street address");
        }
    }
}
