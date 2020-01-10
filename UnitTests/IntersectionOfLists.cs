using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TwitterProblems;

namespace TwitterProblemsTests
{
    public class IntersectionOfListsProblemTests
    {
        [Test]
        public void IntersectionOfLists_Test1()
        {
            var instance = new IntersectionOfListsProblem();

            var expected = new int[] { 4 };
            var actual = instance.Solve(
                new int[] { 1, 2, 3, 4 },
                new int[] { 2, 4, 6, 8 },
                new int[] { 3, 4, 5 }
              );

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IntersectionOfLists_Test2()
        {
            var instance = new IntersectionOfListsProblem();

            var expected = new int[] { 4 };
            var actual = instance.Solve(
                new int[] { 1, 1, 2, 2, 4, 4 },
                new int[] { 2, 4, 4, 6, 6, 8, 8 },
                new int[] { 3, 3, 4, 4, 5, 5 }
              );

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IntersectionOfLists_Test3()
        {
            var instance = new IntersectionOfListsProblem();

            var expected = new string[] { "Hello" };
            var actual = instance.Solve(
                new string[] { "Hello", "i", "am", "here" },
                new string[] { "Hello", "there" },
                new string[] { "Hello", "nope" }
              );

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IntersectionOfLists_Test4()
        {
            var instance = new IntersectionOfListsProblem();

            var expected = new string[] { "Hello", "i" };
            var actual = instance.Solve(
                new string[] { "Hello", "i", "am", "here" },
                new string[] { "Hello", "there", "i" },
                new string[] { "Hello", "nope", "i" }
              );

            Assert.AreEqual(expected, actual);
        }
    }
}
