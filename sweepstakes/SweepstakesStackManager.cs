using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        //Member Variables
        Stack<Sweepstakes> stack;
        public Stack<Sweepstakes> Stack
        {
            get { return stack; }
        }
        //Constructor
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }
        //Member Methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
        }
    }
}
