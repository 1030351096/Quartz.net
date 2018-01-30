using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using webCore.repository;
using models;
using PetaPoco;
using webCore.input;
using Moq;
using webCore.services;

namespace webCoreTests.services
{
    [TestClass]
    public class Iphone
    {
        private readonly Mock<IphoneServices> phonemock = new Mock<IphoneServices>();
        private readonly Mock<PhoneListParmaeter> pagimock = new Mock<PhoneListParmaeter>();
        [TestMethod]
        public void GetListPhone()
        {
            phonemock.Setup(r => r.GetListPhone(pagimock.Object)).Returns(new Page<Phone>()).Verifiable();
            var page = phonemock.Object.GetListPhone(pagimock.Object);
            Assert.IsNotNull(page);
        }
    }
}
