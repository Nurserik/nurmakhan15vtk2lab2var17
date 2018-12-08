using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTestProject1
{
    [TestFixture]
    class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");
            // Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
            // More general
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.StartWith("<abc>"));
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
        }
    }
}
