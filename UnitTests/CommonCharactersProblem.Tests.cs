using NUnit.Framework;
using AppleProblems;
using System.Collections.Generic;

namespace AppleProblemsTests
{
    public class CommonCharactersProblemTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CommonCharacters_Test1()
        {
            var instance = new CommonCharactersProblem();
            var input = new List<string>() { "google", "facebook", "youtube" };
            var expected = new List<char>() { 'e', 'o' };
            
            var actual = instance.Solve(input);
            expected.Sort();
            actual.Sort();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CommonCharacters_Test2()
        {
            var instance = new CommonCharactersProblem();
            var input = new List<string>() { "abc", "def", "ghi" };
            var expected = new List<char>();

            var actual = instance.Solve(input);
            expected.Sort();
            actual.Sort();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CommonCharacters_Test3()
        {
            var instance = new CommonCharactersProblem();
            var input = new List<string>() { "aaa", "bbb", "ccc" };
            var expected = new List<char>();

            var actual = instance.Solve(input);
            expected.Sort();
            actual.Sort();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CommonCharacters_Test4()
        {
            var instance = new CommonCharactersProblem();
            var input = new List<string>() { "", "ababab", "adef", "adedede" };
            var expected = new List<char>();

            var actual = instance.Solve(input);
            expected.Sort();
            actual.Sort();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CommonCharacters_Test5()
        {
            var instance = new CommonCharactersProblem();
            var input = new List<string>() { "a", "ababab", "adef", "adedede" };
            var expected = new List<char>() { 'a' };

            var actual = instance.Solve(input);
            expected.Sort();
            actual.Sort();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CommonCharacters_Test6()
        {
            var instance = new CommonCharactersProblem();
            var input = new List<string>();
            var expected = new List<char>();

            var actual = instance.Solve(input);
            expected.Sort();
            actual.Sort();
            Assert.AreEqual(expected, actual);
        }
    }
}