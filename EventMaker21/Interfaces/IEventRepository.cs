using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMaker21.Models;

namespace EventMaker21.Interfaces
{
    public interface IEventRepository
    {
        List<Event> GetAllEvents();
        Event GetEvent(int id);
        void AddEvent(Event ev);
        void UpdateEvent(Event evt);
        List<Event> FilterEvents(string filterCriteria);
        List<Event> SearchEventByCode(string code);
    }
}
