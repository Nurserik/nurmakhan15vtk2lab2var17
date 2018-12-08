using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTestProject1
{
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            //Check that the type of the returned function is NotFound.
            Assert.That(result, Is.TypeOf<NotFound>());

            //Проверяем что тип возвращенной функции именно NotFound или пройводный класс от //Проверяем что тип возвращенной функции именно NotFound
            Assert.That(result, Is.InstanceOf<NotFound>());
        }
        [Test]
        public void GrtCustomer_IdIsNotZero_ReturnNotFound()
        {
        }
    }
}
