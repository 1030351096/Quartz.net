using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using webCore.services;

namespace webCoreTests.services
{
    /// <summary>
    /// Type 的摘要说明
    /// </summary>
    [TestClass]
    public class Type
    {
        private readonly Mock<ItypeServices>typemock = new Mock<ItypeServices>();
        private readonly Mock<models.Type> type = new Mock<models.Type>();

        [TestMethod]
        public void Add()
        {
            typemock.Setup(r => r.Add(type.Object)).Returns(true).Verifiable();
            var IsAdd = typemock.Object.Add(type.Object);
            Assert.IsTrue(IsAdd);
        }
        [TestMethod]
        public void Delete()
        {
            typemock.Setup(r => r.Delete(type.Object)).Returns(true).Verifiable();
            var IsDelete = typemock.Object.Delete(type.Object);
            Assert.IsTrue(IsDelete);
        }
        [TestMethod]
        public void Update()
        {
            typemock.Setup(r => r.Update(type.Object)).Returns(true).Verifiable();
            var IsUpdate = typemock.Object.Update(type.Object);
            Assert.IsTrue(IsUpdate);
        }
    }
}
