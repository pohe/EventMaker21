using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMaker21.Helpers;
using EventMaker21.Interfaces;
using EventMaker21.Models;

namespace EventMaker21.Services
{
    public class JsonEventRepository: IEventRepository
    {
        //string JsonFileName = @"C:\Users\EASJ\OneDrive - Zealand Sjællands Erhvervsakademi(1)\Dokumenter\UV\SWC2021E\myapps\EventMaker21\EventMaker21\Data\JsonEvents.json";
        string JsonFileName = @"Data\JsonEvents.json";
        public List<Event> GetAllEvents()
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }

        public Event GetEvent(int id)
        {
            throw new NotImplementedException();
        }

        public void AddEvent(Event ev)
        {
            List<Event> events = GetAllEvents();

            List<int> eventsIds = new List<int>();

            foreach (var evt in events)
            {
                eventsIds.Add(evt.Id);
            }

            if (eventsIds.Count != 0)
            {
                int start = eventsIds.Max();
                ev.Id = start + 1;
            }
            else
            {
                ev.Id = 1;
            }
            events.Add(ev);
            JsonFileWritter.WriteToJson(events, JsonFileName);
        }

        public void UpdateEvent(Event evt)
        {
            throw new NotImplementedException();
        }

        public List<Event> FilterEvents(string filterCriteria)
        {
            throw new NotImplementedException();
        }

        public List<Event> SearchEventByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}
