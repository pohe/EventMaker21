using System;
using EventMaker21.Models;
using EventMaker21.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventMakerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestChangeCountryCode()
        {
            //Arrange
            Event e1 = new Event()
            {
                City = "KBH", CountryCode = "DK", DateTime = DateTime.Now, Description = "Test countrycode changed",
                Id = 123, Name = "Testname"
            };

            //Act
            e1.CountryCode = "FR";

            //Assert
            Assert.AreEqual("FR", e1.CountryCode);
        }

        [TestMethod]
        public void TestAddEventToJson()
        {
            //Arrange
            JsonEventRepository eventRepository = new JsonEventRepository();
            int countBefore = eventRepository.GetAllEvents().Count;
            //Act
            Event e1 = new Event()
            {
                City = "KBH",
                CountryCode = "DK",
                DateTime = DateTime.Now,
                Description = "Test countrycode changed",
                Id = 123,
                Name = "Testname"
            };
            eventRepository.AddEvent(e1);
            int countAfter = eventRepository.GetAllEvents().Count;

            //Assert
            Assert.AreEqual(countBefore+1, countAfter);
        }

    }
}
