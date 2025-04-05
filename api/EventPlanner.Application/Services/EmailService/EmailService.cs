using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventPlanner.Application.Interfaces;
using EventPlanner.Domain.Entity;

namespace EventPlanner.Application.Services.EmailService
{
    public class EmailService: IEmailService
    {
        private IRepository<Email> _emailRepository;
        public EmailService(IRepository<Email> emailRepository) 
        {
            this._emailRepository = emailRepository;
        }

        public async Task<bool> sendInvitaionEmail(string To, Event eventDetails)
        {
            var message = $"You have been invited to {eventDetails.Name} event.";
            var status = await _emailRepository.Add(
                new Email 
                {
                    To = To,
                    Content = message,
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now,
                }
            );
            return status;
        }
    }
}
