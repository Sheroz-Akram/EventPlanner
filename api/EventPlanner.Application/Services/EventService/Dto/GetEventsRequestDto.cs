using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Application.Services.EventService.Dto
{
    public class GetEventsRequestDto
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
