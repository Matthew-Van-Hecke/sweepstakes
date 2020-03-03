using System;
using sweepstakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SweepstakesTests
{
    [TestClass]
    public class SweepstakesQueueManagerTests
    {
        [TestMethod]
        public void InsertSweepstakes_InsertThreeSweepstakes_CountIsThree()
        {
            //Arrange
            SweepstakesQueueManager sweepstakesQueue = new SweepstakesQueueManager();
            Sweepstakes sweepstakes1 = new Sweepstakes("this");
            Sweepstakes sweepstakes2 = new Sweepstakes("that");
            Sweepstakes sweepstakes3 = new Sweepstakes("the other thing");
            int expected = 3;
            //Act
            sweepstakesQueue.InsertSweepstakes(sweepstakes1);
            sweepstakesQueue.InsertSweepstakes(sweepstakes2);
            sweepstakesQueue.InsertSweepstakes(sweepstakes3);
            //Assert
            Assert.AreEqual(expected, sweepstakesQueue.Queue.Count);
        }
        [TestMethod]
        public void InsertSweepstakes_InsertThreeSweepstakes_FirstSweepstakesAddedIsNowAtFrontOfQueue()
        {
            //Arrange
            SweepstakesQueueManager sweepstakesQueue = new SweepstakesQueueManager();
            Sweepstakes sweepstakes1 = new Sweepstakes("this");
            Sweepstakes sweepstakes2 = new Sweepstakes("that");
            Sweepstakes sweepstakes3 = new Sweepstakes("the other thing");
            string expected = "this";
            //Act
            sweepstakesQueue.InsertSweepstakes(sweepstakes1);
            sweepstakesQueue.InsertSweepstakes(sweepstakes2);
            sweepstakesQueue.InsertSweepstakes(sweepstakes3);
            //Assert
            Assert.AreEqual(expected, sweepstakesQueue.Queue.Dequeue());
        }
    }
}
