using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using webCore.services;

namespace webCoreTests.services
{
    /// <summary>
    /// Color 的摘要说明
    /// </summary>
    [TestClass]
    public class Color
    {
        private readonly Mock<IcolorServices> colormock = new Mock<IcolorServices>();
        private readonly Mock<models.color> color = new Mock<models.color>();

        [TestMethod]
        public void Add()
        {
            colormock.Setup(r => r.Add(color.Object)).Returns(true).Verifiable();
            var IsAdd = colormock.Object.Add(color.Object);
            Assert.IsTrue(IsAdd);
        }
        [TestMethod]
        public void Delete()
        {
            colormock.Setup(r => r.Delete(color.Object)).Returns(true).Verifiable();
            var IsDelete = colormock.Object.Delete(color.Object);
            Assert.IsTrue(IsDelete);
        }
        [TestMethod]
        public void Update()
        {
            colormock.Setup(r => r.Update(color.Object)).Returns(true).Verifiable();
            var IsUpdate = colormock.Object.Update(color.Object);
            Assert.IsTrue(IsUpdate);
        }


    }
}
