using General;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralTests
{
    public class ParseIntTests
    {
        [Test]
        public void Should_Parse_String()
        {
            var result = ParseInt.Parse("123");
            var expected = 123;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Should_Parse_String_As_Positive()
        {
            var result = ParseInt.Parse("+123");
            var expected = 123;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Should_Parse_String_As_Negative()
        {
            var result = ParseInt.Parse("-123");
            var expected = -123;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Should_Throw_On_Invalid_Input()
        {
            var invalidArgument = "ABC123";
            Assert.Throws<ArgumentException>(() => ParseInt.Parse(invalidArgument));
        }

        [Test]
        public void Should_Skip_Last_Invalid_Chars()
        {
            var result = ParseInt.Parse("123ABC");
            var expected = 123;

            Assert.AreEqual(expected, result);
        }
    }
}
