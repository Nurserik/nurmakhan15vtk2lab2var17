using System;
using TestNinja.Fundamentals;
using NUnit.Framework;


namespace TestNinja.UnitTestProject1
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_PolzovatelIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void CanBeCancelledBy_Obyshnyi_ReturnsTrue()
        {
            //Arrange
            var Polzovatel = new User { };
            var reservation = new Reservation { MadeBy = Polzovatel };
            //Act
            var result = reservation.CanBeCancelledBy(Polzovatel);
            //Assert
            Assert.That(result, Is.True);
        }
        [Test]
        public void CanBeCancelledBy_Obyshyi2_ReturnsTrue()
        {
            var Polzovatel = new User { };
            //Arrange
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(Polzovatel);
            //Assert
            Assert.That(result== false);
        }



    }
}

