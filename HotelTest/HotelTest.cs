using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //arrange

            //act
            var h = new Hotel();
            //assert

            Assert.Pass();
        }
    }
}