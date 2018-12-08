using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1
{
    [TestFixture]
    public class Assignment4Tests
    {
        private Assignment4 CCOMANNNDER;

        [SetUp]
        public void SetUp()
        {
            CCOMANNNDER = new Assignment4();
        }

        [Test]
        [TestCase("Stop")]
        public void LUCKYNUMBERS_WhenCalled_SetTheLuckyNumberProperty(string MyCommand)
        {
            //Arrange


            //Act
            CCOMANNNDER.WarisEnd(MyCommand);

            //Assert
            Assert.That(CCOMANNNDER.CommandCommander, Is.EqualTo(MyCommand));
        }

        
    }
}
