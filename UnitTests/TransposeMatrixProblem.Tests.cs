using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TwitterProblems;

namespace TwitterProblemsTests
{
    public class TransposeMatrixProblemTests
    {
        [Test]
        public void TransposeMatrix_Test1()
        {
            var instance = new TransposeMatrixProblem();
            var input = new List<List<int>>()
            {
                new List<int>() {1, 2, 3},
                new List<int>() {4, 5, 6},
                new List<int>() {7, 8, 9}
            };
            var expected = new List<List<int>>()
            {
                new List<int>() {1, 4, 7},
                new List<int>() {2, 5, 8},
                new List<int>() {3, 6, 9}
            };


            var actual = instance.Solve(input);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TransposeMatrix_Test2()
        {
            var instance = new TransposeMatrixProblem();
            var input = new List<List<int>>()
            {
                new List<int>() {1, 2, 3, 4, 5, 6},
                new List<int>() {7, 8, 9, 10, 11, 12}
            };
            var expected = new List<List<int>>()
            {
                new List<int>() {1, 7},
                new List<int>() {2, 8},
                new List<int>() {3, 9},
                new List<int>() {4, 10},
                new List<int>() {5, 11},
                new List<int>() {6, 12},
            };


            var actual = instance.Solve(input);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TransposeMatrix_Test3()
        {
            var instance = new TransposeMatrixProblem();
            var input = new List<List<int>>()
            {
                new List<int>() {1, 2, 3}
            };
            var expected = new List<List<int>>()
            {
                new List<int>() {1},
                new List<int>() {2},
                new List<int>() {3},
            };


            var actual = instance.Solve(input);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TransposeMatrix_Test4()
        {
            var instance = new TransposeMatrixProblem();
            var input = new List<List<int>>();
            var expected = new List<List<int>>();

            var actual = instance.Solve(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
