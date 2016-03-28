using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReportUnit;
using System;

namespace UnitTests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void CreatingPersonHasNameSean()
        {
            // arrange
            var name = "Sean";
            var age = 30;
            var eyeColour = "Blue";
            var hairColour = "Blonde";

            // act - creating a person testing the constructor
            Person person = new Person(name, age, eyeColour, hairColour);

            // assert
            var actual = person.GetName();
            Assert.AreEqual(name, actual, string.Format("Name: {0} does not equal {1}", name, actual));
        }

        [TestMethod]
        public void CreatingPersonHasAge30()
        {
            // arrange
            var name = "Sean";
            var age = 30;
            var eyeColour = "Blue";
            var hairColour = "Blonde";

            // act - creating a person testing the constructor
            Person person = new Person(name, age, eyeColour, hairColour);

            // assert
            var actual = person.GetAge();
            Assert.AreEqual(age, actual, string.Format("Age: {0} does not equal {1}", age, actual));
        }

        [TestMethod]
        public void CreatingPersonHasBlondeHair()
        {
            // arrange
            var name = "Sean";
            var age = 30;
            var eyeColour = "Blue";
            var hairColour = "Blonde";

            // act - creating a person testing the constructor
            Person person = new Person(name, age, eyeColour, hairColour);

            // assert
            var actual = person.GetHairColour();
            Assert.AreEqual(hairColour, actual, string.Format("Hair Colour: {0} does not equal {1}", hairColour, actual));
        }

        [TestMethod]
        public void CreatingPersonHasBlueEyes()
        {
            // arrange
            var name = "Sean";
            var age = 30;
            var eyeColour = "Blue";
            var hairColour = "Blonde";

            // act - creating a person testing the constructor
            Person person = new Person(name, age, eyeColour, hairColour);

            // assert
            var actual = person.GetEyeColour();
            Assert.AreEqual(eyeColour, actual, string.Format("Eye: {0} does not equal {1}", eyeColour, actual));
        }

        [TestMethod]
        public void Failure_AgeDoesntMatch()
        {
            // arrange
            var name = "Sean";
            var age = 30;
            var eyeColour = "Blue";
            var hairColour = "Blonde";

            // act - creating a person testing the constructor
            Person person = new Person(name, age, eyeColour, hairColour);

            // assert
            var actual = person.GetAge();
            Assert.AreEqual(35, actual, string.Format("Age: {0} does not equal {1}", 35, actual));
        }

        [Ignore]
        [TestMethod]
        public void Ignored_NotYetImplemented()
        {
        }

        [TestMethod]
        public void Failure_HairColourDoesntMatch()
        {
            // arrange
            var name = "Sean";
            var age = 30;
            var eyeColour = "Blue";
            var hairColour = "Blonde";

            // act - creating a person testing the constructor
            Person person = new Person(name, age, eyeColour, hairColour);

            // assert
            var actual = person.GetHairColour();
            Assert.AreEqual("Black", actual, string.Format("Hair Colour: {0} does not equal {1}", "Black", actual));
        }

        [TestMethod]
        public void Failure_EyeColourDoesntMatch()
        {
            // arrange
            var name = "Sean";
            var age = 30;
            var eyeColour = "Blue";
            var hairColour = "Blonde";

            // act - creating a person testing the constructor
            Person person = new Person(name, age, eyeColour, hairColour);

            // assert
            var actual = person.GetEyeColour();
            Assert.AreEqual("Green", actual, string.Format("Eye: {0} does not equal {1}", "Green", actual));
        }

        [TestMethod]
        public void Failure_NameDoesntMatch()
        {
            // arrange
            var name = "Sean";
            var age = 30;
            var eyeColour = "Blue";
            var hairColour = "Blonde";

            // act - creating a person testing the constructor
            Person person = new Person(name, age, eyeColour, hairColour);

            // assert
            var actual = person.GetName();
            Assert.AreEqual("Bob", actual, string.Format("Name: {0} does not equal {1}", "Bob", actual));
        }
    }
}
