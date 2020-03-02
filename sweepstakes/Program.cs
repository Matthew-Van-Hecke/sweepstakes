using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = UserInterface.GetUserInputFor("email");
            Console.WriteLine(email);
            Console.ReadLine();
        }
    }
}
