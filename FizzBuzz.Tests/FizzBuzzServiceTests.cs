using NUnit.Framework;
using System.Collections.Generic;
using WebApplication1.Services;

namespace FizzBuzz.Tests
{
    public class FizzBuzzServiceTests
    {
        private IFizzBuzzService _service;
        [SetUp]
        public void Setup()
        {
            _service = new FizzBuzzService();    
        }

        [Test]
        public void CheckForFizzBuzz_Test()
        {
            List<object> nos = new List<object>() {1,2,3,4,null,5,6,7,8,9 };
            Assert.NotNull(_service);
            var result = _service.CheckForFizzBuzz(nos);
            Assert.AreEqual(15,result.Count);
            Assert.AreEqual("Invalid Item", result[7]);
        }


        [Test]
        public void CheckForFizzBuzz_Null_Input()
        {
            var result = _service.CheckForFizzBuzz(null);
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void CheckForFizzBuzz_ValidNo()
        {
            List<object> nos = new List<object>() { 15 };
            var result = _service.CheckForFizzBuzz(nos);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("FizzBuzz", result[0]);
        }
    }
}