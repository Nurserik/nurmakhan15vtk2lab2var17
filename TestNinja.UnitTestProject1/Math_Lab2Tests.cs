using System;
using TestNinja.Fundamentals;
using NUnit.Framework;
using System.Linq;

namespace TestNinja.UnitTestProject1
{
    [TestFixture]
    public class Math_Lab2Tests
    {
        private Math_Lab2 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math_Lab2();
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Add_WhenCalled_ReturnTheSunArgument(int a, int b, int expectedResult)
        {
            var result = _math.Add(a, b);

            Assert.That(result== expectedResult);
        }
        [Test]
        [TestCase(2, 1, 3)]
        [TestCase(1, 2, 3)]
        [TestCase(1, 1, 2)]
        public void Add_WhenCalled_ReturnTheSunOfArgument(int a, int b, int expectedResult)
        {
            var result = _math.Add(a, b);

            Assert.That(result == expectedResult);
        }
        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_returnOddNimbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //Проверка что массив не пустой
            Assert.That(result, Is.Not.Empty);

            //Количество элементов в массив = 3 (Alt + Enter)
            Assert.That(result.Count(), Is.EqualTo(3));

            //Проверка что массив содержит число 1
            Assert.That(result, Does.Contain(1));

            //Проверка что массив содержит число 2 
            Assert.That(result, Does.Contain(3));

            //Проверка что массив содержит число 5
            Assert.That(result, Does.Contain(5));

            //Проверка на совпадение Всего массива целиком
            Assert.That(result,Is.EquivalentTo(new[] { 1, 3, 5}));

            //Проверка что массив отсартирован
            Assert.That(result, Is.Ordered);

            //Проверка что массив содержит только уникальные, не повторяющиеся значения
            Assert.That(result, Is.Unique);
        }
    }
}
