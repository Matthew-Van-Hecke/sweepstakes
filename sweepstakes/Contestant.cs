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
        string lastName;
        string email;
        string address;
        int registrationNumber;
        //Constructor
        public Contestant()
        {
            firstName = UserInterface.GetUserInputFor("first name");
            lastName = UserInterface.GetUserInputFor("last name");
            email = UserInterface.GetUserInputFor("email");
            address = UserInterface.GetUserInputFor("street address");
            registrationNumber = UserInterface.GetUserInputFor("registration number");
        }
        //Member Methods
    }
}
