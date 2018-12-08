using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1
{
    [TestClass]
    public class Math_Lab1
    {
        [TestMethod]
        
        
            public void IsSumDivisibleBy11_IsSumDivisibleBy11_ReturnsTrue()
            {
                //Arrange
                var math_Lab1 = new Fundamentals.Math_Lab1();
                //Act
                var result = math_Lab1.IsSumDivisibleBy11( 6,5);
                //Assert
                Assert.IsTrue(result);
            }
        [TestMethod]


        public void IsSumDivisibleBy11_IsSumDivisibleBy11_ReturnsFalse()
        {
            //Arrange
            var math_Lab1 = new Fundamentals.Math_Lab1();
            //Act
            var result = math_Lab1.IsSumDivisibleBy11(5, 2);
            //Assert
            Assert.IsFalse(result);
        }
       
    }
}
