using MailContainerTest.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailContainerTest.Tests
{
    [TestClass]
    internal class MailContainerTests
    {
        [TestMethod]
        public void Should_Decrease_Capacity_When_MailTransfer()
        {
            //Arrange
            MailContainer mailContainer = new MailContainer("1", 100, MailContainerStatus.Operational, AllowedMailType.SmallParcel);

            //Act
            mailContainer.UpdateCapacity(50);

            //Assert
            Assert.AreEqual(50, mailContainer.Capacity);
        }
    }
}
