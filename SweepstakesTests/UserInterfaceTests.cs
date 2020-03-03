using System;
using sweepstakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SweepstakesTests
{
    [TestClass]
    public class UserInterfaceTests
    {
        [TestMethod]
        public void ValidateEmail_NoAtsOrDots_ReturnFalse()
        {
            //Arrange
            string userInput = "ThisIsNotAnEmailAddress.";
            bool expected = false;
            bool actual;
            //Act
            actual = UserInterface.ValidateEmail(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateEmail_TextAtDot_ReturnFalse()
        {
            //Arrange
            string userInput = "ThisIsNotAnEmailAddress@.";
            bool expected = false;
            bool actual;
            //Act
            actual = UserInterface.ValidateEmail(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateEmail_TwoAtsAndADot_ReturnFalse()
        {
            //Arrange
            string userInput = "pat@e@axmple.com";
            bool expected = false;
            bool actual;
            //Act
            actual = UserInterface.ValidateEmail(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateEmail_OneAtNoDots_ReturnFalse()
        {
            //Arrange
            string userInput = "pat@example";
            bool expected = false;
            bool actual;
            //Act
            actual = UserInterface.ValidateEmail(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateEmail_OneDotNoAt_ReturnFalse()
        {
            //Arrange
            string userInput = "example.com";
            bool expected = false;
            bool actual;
            //Act
            actual = UserInterface.ValidateEmail(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateEmail_AtInMiddleAndDotAtEnd_ReturnFalse()
        {
            //Arrange
            string userInput = "pat@examplecom.";
            bool expected = false;
            bool actual;
            //Act
            actual = UserInterface.ValidateEmail(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateEmail_AtAtBeginningAndDotInMiddle_ReturnFalse()
        {
            //Arrange
            string userInput = "@patexample.com";
            bool expected = false;
            bool actual;
            //Act
            actual = UserInterface.ValidateEmail(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateEmail_DotBeforeAt_ReturnFalse()
        {
            //Arrange
            string userInput = "pat.example@com";
            bool expected = false;
            bool actual;
            //Act
            actual = UserInterface.ValidateEmail(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateEmail_TextAtTextDotText_ReturnTrue()
        {
            //Arrange
            string userInput = "pat@example.com";
            bool expected = true;
            bool actual;
            //Act
            actual = UserInterface.ValidateEmail(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateInt_CompletelyNonIntString_ReturnFalse()
        {
            //Arrange
            string userInput = "pat@example.com";
            bool expected = false;
            bool actual;
            //Act
            actual = UserInterface.ValidateInt(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateInt_StringThatContainsIntsAndOtherCharacters_ReturnFalse()
        {
            //Arrange
            string userInput = "Happy50";
            bool expected = false;
            bool actual;
            //Act
            actual = UserInterface.ValidateInt(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateInt_SpaceSeparatedInts_ReturnFalse()
        {
            //Arrange
            string userInput = "25 90 65";
            bool expected = false;
            bool actual;
            //Act
            actual = UserInterface.ValidateInt(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateInt_IntOnlyInStringFormat_ReturnTrue()
        {
            //Arrange
            string userInput = "30098435809";
            bool expected = false;
            bool actual;
            //Act
            actual = UserInterface.ValidateInt(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateManagerType_PassInStringEqualToStack_ReturnTrue()
        {
            //Arrange
            string userInput = "stack";
            bool expected = true;
            bool actual;
            //Act
            actual = UserInterface.ValidateManagerType(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateManagerType_PassInStringEqualToQueue_ReturnTrue()
        {
            //Arrange
            string userInput = "queue";
            bool expected = true;
            bool actual;
            //Act
            actual = UserInterface.ValidateManagerType(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateManagerType_PassInStringNotEqualToStackOrQueue_ReturnFalse()
        {
            //Arrange
            string userInput = "this";
            bool expected = false;
            bool actual;
            //Act
            actual = UserInterface.ValidateManagerType(userInput);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
