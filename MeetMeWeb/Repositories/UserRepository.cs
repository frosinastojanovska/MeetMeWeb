﻿using MeetMeWeb.Repositories.Interfaces;
using System;
using MeetMeWeb.Models;
using System.Linq;

namespace MeetMeWeb.Repositories
{
    public class UserRepository : IUserRepository
    {
        private MeetMeDbContext _context;

        public UserRepository()
        {
            _context = new MeetMeDbContext();
        }

        public User getUserById(Guid id)
        {
            User user = _context.Users.Find(id);
            return user;
        }

        public User getUserByUsername(string username)
        {
            var user = _context.Users.Local.Where(x => x.UserName == username).SingleOrDefault();

            if (user == null)
            {
                user = _context.Users.Where(x => x.UserName == username).SingleOrDefault();
            }
            return user;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}