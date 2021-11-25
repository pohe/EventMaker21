using System;
using System.Collections.Generic;
using EventMaker21.Interfaces;
using EventMaker21.Models;
using EventMaker21.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEventMaker
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAddEvent()
        {
            //Arrange
            JsonEventRepository eventRepository = new JsonEventRepository();
            List<Event> events = eventRepository.GetAllEvents();
            int antalBefore = events.Count; 
            //Act
            Event e1 = new Event()
            {
                City = "KBH", CountryCode = "DK", Description = "Test test", DateTime = DateTime.Now.ToLocalTime(), Name = "Test"
            };
            eventRepository.AddEvent(e1);
            events = eventRepository.GetAllEvents();
            int antalAfter = events.Count;
            //Assert

            Assert.AreEqual(antalBefore+1, antalAfter);

        }

       
    }
}
