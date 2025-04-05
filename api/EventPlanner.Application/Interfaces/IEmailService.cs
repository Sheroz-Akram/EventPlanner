using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventPlanner.Domain.Entity;

namespace EventPlanner.Application.Interfaces
{
    public interface IEmailService
    {
        public Task<bool> sendInvitaionEmail(string To, Event eventDetails);
    }
}
