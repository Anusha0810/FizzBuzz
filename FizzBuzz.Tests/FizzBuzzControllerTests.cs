using NUnit.Framework;
using System.Collections.Generic;
using WebApplication1.Controllers;
using WebApplication1.Services;

namespace FizzBuzz.Tests
{
    public class FizzBuzzControllerTests
    {
        private FizzBuzzController _controller;
        [SetUp]
        public void Setup()
        {
            var service = new FizzBuzzService();
            _controller = new FizzBuzzController(service);
        }

        [Test]
        public void CheckForFizzBuzz_Test()
        {
            List<object> nos = new List<object>() { 1, 2, 3, 4, null, 5, 6, 7, 8, 9 };
            Assert.NotNull(_controller);
            var result = _controller.CheckForFizzBuzz(nos);
            Assert.AreEqual(15, result.Count);
            Assert.AreEqual("Invalid Item", result[7]);
        }


        [Test]
        public void CheckForFizzBuzz_Null_Input()
        {
            var result = _controller.CheckForFizzBuzz(null);
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void CheckForFizzBuzz_ValidNo()
        {
            List<object> nos = new List<object>() { 15 };
            var result = _controller.CheckForFizzBuzz(nos);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("FizzBuzz", result[0]);
        }
    }
}