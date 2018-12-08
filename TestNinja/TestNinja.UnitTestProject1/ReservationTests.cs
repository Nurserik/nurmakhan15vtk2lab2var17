using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
                public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeCancelledBy_Prostoi_ReturnsTrue()
        {
            //Arrange
            var user = new User { };
            var reservation = new Reservation{MadeBy=user};
            //Act
            var result = reservation.CanBeCancelledBy( user);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeCancelledBy_NeProstoi_ReturnsTrue()
        {
            var user = new User { };
            //Arrange
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(user);
            //Assert
            Assert.IsFalse(result);
        }



    }
}
