using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotDogLover.Models;
using HotDogLover.Services;
using System.Collections.Generic;

namespace HotDogLover.Tests.Services
{
    [TestClass]
    public class HotDogServiceTests
    {
        [TestMethod]
        public void GetAllDogsTest()
        {
            HotDogServiceMock service = new HotDogServiceMock();
            List<HotDog> dogs = service.listAll();
            Assert.IsNotNull(dogs);
            Assert.AreEqual(3, dogs.Count);
        }
        [TestMethod]
        public void GetDogTest()
        {
            HotDogServiceMock service = new HotDogServiceMock();
            HotDog dog = service.Get(1);
            Assert.IsNotNull(dog);
            Assert.AreEqual("Frank's All Beef Chillidawg", dog.HotDogName);
        }
    }
}
