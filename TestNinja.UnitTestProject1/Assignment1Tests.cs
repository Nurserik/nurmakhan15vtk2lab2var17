using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1
{
    
    [TestFixture]
    public class Assignment1Tests
    {
        private Assignment1 UserW;

        [SetUp]
        public void SetUp()
        {
            UserW = new Assignment1();
        }

        [Test]
       //[TestCase("","")]
        [TestCase("Ualihan","Macbook")]
        public void TestTheWordsjOfLengfth_WhenCalled_ShowLengthofWordUserheStringWithEmptyElement(string UName,string UDev)
        {
            var result = UserW.UserAndHimDevice(UName, UDev);

            if (UName.Length > 0)
            {
                //Specific
                Assert.That(result, Is.EqualTo($"{UName} use him device {UDev}").IgnoreCase);

                //More General
                Assert.That(result, Does.StartWith(UName).IgnoreCase);
                Assert.That(result, Does.Contain("use him device").IgnoreCase);
                Assert.That(result, Does.EndWith(UDev).IgnoreCase);
            }
            else
            {
                //Specific
                Assert.That(result, Is.EqualTo("<>Enter the magic word</>").IgnoreCase);

            }
        }


    }
}
