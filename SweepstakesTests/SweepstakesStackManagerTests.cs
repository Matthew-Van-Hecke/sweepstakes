using System;
using sweepstakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SweepstakesTests
{
    [TestClass]
    public class SweepstakesStackManagerTests
    {
        [TestMethod]
        public void InsertSweepstakes_InsertTwoSweepstakes_CountOfStackIsTwo()
        {
            //Arrange
            SweepstakesStackManager stackManager = new SweepstakesStackManager();
            int expected = 2;
            //Act
            stackManager.InsertSweepstakes(new Sweepstakes("this"));
            stackManager.InsertSweepstakes(new Sweepstakes("that"));
            //Assert
            Assert.AreEqual(expected, stackManager.Stack.Count);
        }
    }
}
