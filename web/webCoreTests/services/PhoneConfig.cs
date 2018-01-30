using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using webCore.services;

namespace webCoreTests.services
{
    /// <summary>
    /// PhoneConfig 的摘要说明
    /// </summary>
    [TestClass]
    public class PhoneConfig
    {
        private readonly Mock<IphoneconfigServices> phoneconfigmock = new Mock<IphoneconfigServices>();
        //private readonly Mock<models.Type> type = new Mock<models.Type>();

        [TestMethod]
        public void GetPhoneConfigByid()
        {
            phoneconfigmock.Setup(r => r.GetPhoneConfigByid(It.IsAny<int>())).Returns(new models.PhoneConfig() { }).Verifiable();
            var phoneconfig = phoneconfigmock.Object.GetPhoneConfigByid(It.IsAny<int>());
            Assert.IsNotNull(phoneconfig);
        }

    }
}
