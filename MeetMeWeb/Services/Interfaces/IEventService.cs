﻿using MeetMeWeb.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeetMeWeb.Services.Interfaces
{
    public interface IEventService : IDisposable
    {
        Task<Event> createEvent(Event eventModel);
        Task<Event> deleteEvent(string title,Guid id);
        List<Event> getEvents(string username);
    }
}
