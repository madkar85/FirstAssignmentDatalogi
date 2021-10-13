using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstAssignmentDatalogi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FirstAssignmentDatalogi.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void StartTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CheckIfCorrectInputTest()
        {

        }

        [TestMethod()]
        public void CheckIfPrimeNumberTest()
        {
            Assert.AreEqual(false, Program.CheckIfPrimeNumber(1));
            Assert.AreEqual(true, Program.CheckIfPrimeNumber(2));
            Assert.AreEqual(true, Program.CheckIfPrimeNumber(3));
            Assert.AreEqual(false, Program.CheckIfPrimeNumber(4));
            Assert.AreEqual(true, Program.CheckIfPrimeNumber(5));
            Assert.AreEqual(false, Program.CheckIfPrimeNumber(6));
            Assert.AreEqual(true, Program.CheckIfPrimeNumber(11));
        }

        [TestMethod()]
        public void SortListTest()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(4);
            numbers.Add(7);
            numbers.Add(2);

            var expected = new List<int> { 1, 2, 4, 7 };
            var actual = Program.SortList(numbers);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetNextPrimeTest()
        {
            Assert.AreEqual(5, Program.GetNextPrime(3));
            Assert.AreEqual(7, Program.GetNextPrime(5));
            Assert.AreEqual(11, Program.GetNextPrime(7));
        }

        [TestMethod()]
        public void AddNextPrimeTest()
        {
            var primeNumbers = new List<int> { 2, 3, 5, 7 };

            var expected = new List<int> { 2, 3, 5, 7, 11 };
            Program.AddNextPrime(primeNumbers);

            CollectionAssert.AreEqual(expected, primeNumbers);
        }

        [TestMethod()]
        public void AddNextPrimeTest2()
        {
            var primeNumbers = new List<int> { 2, 5, 11, 7 };

            var expected = new List<int> { 2, 5, 11, 7, 13 };
            Program.AddNextPrime(primeNumbers);

            CollectionAssert.AreEqual(expected, primeNumbers);
        }
    }
}