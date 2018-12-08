using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1
{
    [TestFixture]
    public class Assignment3Tests
    {
        private Assignment3 FindDigital;

        [SetUp]
        public void SetUp()
        {
            FindDigital = new Assignment3();
        }

        [Test]
        [TestCase(6)]
        [TestCase(34)]
        public void SORTINGHAT_WizardNameIsInList_ReturnGryffindorOrPufindoyOrKogtevranOrSlyzerin(int Dig)
        {
            //Arrange
            
            //Act
            var result = FindDigital.FindDIGITAL(Dig);

            //Asset
           
            if (Dig > 0 && Dig < 10)
            {
                Assert.That(result, Is.TypeOf<One>());
                Assert.That(result, Is.InstanceOf<One>());
            }
            if (Dig > 9 && Dig < 99)
            {
                Assert.That(result, Is.TypeOf<Ten> ());
                Assert.That(result, Is.InstanceOf< Ten > ());
            }

            if (Dig > 99 && Dig < 999)
            {
                Assert.That(result, Is.TypeOf<Hundred>());
                Assert.That(result, Is.InstanceOf<Hundred>());
            }

           
            
        }

        [Test]
        public void SORTINGHAT_WizardNameIsInList_ReturnGryffindorOrPufindoyOrKogtevranOrSlyzerin()
        {

        }
    }
}

