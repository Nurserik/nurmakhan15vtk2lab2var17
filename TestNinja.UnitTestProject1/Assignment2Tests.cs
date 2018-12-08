using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1
{
    [TestFixture]
    public class Assignment2Tests
    {
        private Assignment2 BinaryalCoder;

        [SetUp]
        public void SetUp()
        {
            BinaryalCoder = new Assignment2();
        }
        [Test]
        [TestCase("Еркын")]
        public void LoveDuo_BoyFriendGreaterThanGirlfriend_ReturnLoveDuoUpToLOVEDUOS(string WORD)
        {
            //Arrange

            //Act
            var result = BinaryalCoder.Binary(WORD);

            //Assert
            Assert.That(result, Is.Not.Empty);
            
            Assert.That(result.Count(), Is.EqualTo(WORD.Length));
           
                Assert.That(result, Does.Contain(1));
                Assert.That(result, Does.Contain(0));
          
            //Assert.That(result, Is.Unique);
        }
    }
}
