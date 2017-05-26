﻿using MeetMeWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMeWeb.Repositories.Interfaces
{
    public interface IMeetingRepository: IDisposable
    {
        Task<Meeting> CreateMeeting(Meeting meetingModel);
        Meeting getByTitle(string title);
    }
}
