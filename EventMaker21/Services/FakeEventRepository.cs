using System;
using System.Collections.Generic;
using System.Linq;
using EventMaker21.Interfaces;
using EventMaker21.Models;

namespace EventMaker21.Services
{
    public class FakeEventRepository: IEventRepository
    {
        private List<Event> events;

        //private static FakeEventRepository _instance;

        //public static FakeEventRepository Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new FakeEventRepository();
        //        }
        //        return _instance;
        //    }
        //}

        public FakeEventRepository()
        {
            events = new List<Event>();
            events.Add(new Event()
            {
                Id = 1,
                Name = "Roskilde Festival",
                Description = " A lot of music",
                City = "Roskilde",
                DateTime = new DateTime(2020, 6, 9, 10, 0, 0)
            });
            events.Add(new Event()
            {
                Id = 2,
                Name = "CPH Marathon",
                Description = " Many Marathon runners",
                City = "Copenhagen",
                DateTime = new DateTime(2020, 3, 6, 9, 30, 0)
            });
            events.Add(new Event()
            {
                Id = 3,
                Name = "CPH Distorsion",
                Description = " A lot of beers",
                City = "Copenhagen",
                DateTime = new DateTime(2019, 6, 4, 14, 0, 0)
            });
            events.Add(new Event()
            {
                Id = 4,
                Name = "Demo Day",
                Description = "Project Presentation",
                City = "Roskilde",
                DateTime = new DateTime(2020, 6, 9, 9, 0, 0)
            });
            events.Add(new Event()
            {
                Id = 5,
                Name = "VM Badminton",
                Description = "Badminton",
                City = "Århus",
                DateTime = new DateTime(2020, 10, 3, 16, 0, 0)
            });
        }
        

        public void UpdateEvent(Event @event)
        {
            if (@event != null)
            {
                foreach (Event v in GetAllEvents())
                {
                    if (v.Id == @event.Id)
                    {
                        v.Name = @event.Name;
                        v.Description = @event.Description;
                        v.City = @event.City;
                        v.DateTime = @event.DateTime;
                    }
                }
            }
        }

        public Event GetEvent(int id)
        {
            foreach (Event v in events)
            {
                if (v.Id == id)
                    return v;
            }
            return new Event();
        }

        public void AddEvent(Event ev)
        {
            ev.Id = events.Count == 0 ? 1 : events.Max(x => x.Id) + 1;
            //List<int> eventIds = new List<int>();
            //foreach (var evt in events)
            //{
            //    eventIds.Add(evt.Id);
            //}
            //if (eventIds.Count != 0)
            //{
            //    int start = eventIds.Max();
            //    ev.Id = start + 1;
            //}
            //else
            //{
            //    ev.Id = 1;
            //}
            events.Add(ev);
        }

        //Her kan der være metoder til Add, Delete, Update m.m.

        public List<Event> GetAllEvents()
        {
            return events.ToList();
        }

        public List<Event> FilterEvents(string filterCriteria)
        {
            List<Event> filteredList = new List<Event>();
            foreach (Event ev in events)
            {
                if (ev.City.Contains(filterCriteria) || ev.Name.Contains(filterCriteria) || ev.Description.Contains(filterCriteria))
                {
                    filteredList.Add(ev);
                }
            }

            return filteredList;
        }
    }
}
