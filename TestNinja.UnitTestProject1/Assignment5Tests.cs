using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1
{
    [TestFixture]
    public class Assignment5Tests
    {
        private Assignment5 TakeNameUser;

        [SetUp]
        public void SetUp()
        {
            TakeNameUser = new Assignment5();
        }
        [Test]
        [TestCase("Ammer Abbash")]
        public void Log_WhenCalled_SetTheLastErrorProperty(string Name)
        {
            //Arrange

            //Act
            TakeNameUser.RealName(Name);

            //Assert
            Assert.That(TakeNameUser.UserName, Is.EqualTo(Name));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullExeption(string WordForOutSystem)
        {
            //Arrange
            
            //Act
            //loger.log(error)

            //Assert
            Assert.That(() => TakeNameUser.RealName(WordForOutSystem), Throws.ArgumentNullException);
            //Assert.That(() => logger.Log(error), Throws.ArgumentNullException);

        }
    }
}
