﻿using MeetMeWeb.Models;
using MeetMeWeb.Repositories.Interfaces;
using MeetMeWeb.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace MeetMeWeb.Services
{
    public class EventService : IEventService
    {
        private IEventRepository _repo;

        public EventService(IEventRepository repo)
        {
            _repo = repo;
        }

        public async Task<Event> createEvent(Event eventModel)
        {
            return await _repo.CreateEvent(eventModel);
        }

        public async Task<Event> deleteEvent(string title,Guid id)
        {
            return await _repo.DeleteEvent(title,id);
        }

        public List<Event> getEvents(string username)
        {
            return  _repo.getEvents(username);
        }

        public void Dispose()
        {
            _repo.Dispose();
        }

    }
}