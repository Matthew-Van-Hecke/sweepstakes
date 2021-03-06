﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    public class Contestant
    {
        //Member Variables
        string firstName;
        public string FirstName
        {
            get { return firstName; }
        }
        string lastName;
        public string LastName
        {
            get { return lastName; }
        }
        string email;
        public string Email
        {
            get { return email; }
        }
        string address;
        public string Address
        {
            get { return address; }
        }
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
        public void EnterContestantInfo()
        {
            firstName = UserInterface.GetUserInputFor("first name");
            lastName = UserInterface.GetUserInputFor("last name");
            email = UserInterface.GetUserInputFor("email");
            address = UserInterface.GetUserInputFor("street address");
        }
    }
}
