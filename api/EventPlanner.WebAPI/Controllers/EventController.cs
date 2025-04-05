using EventPlanner.Application.Interfaces;
using EventPlanner.Application.Responses;
using EventPlanner.Application.Services.EventService.Dto;
using Microsoft.AspNetCore.Mvc;

namespace EventPlanner.WebAPI.Controllers
{
    [ApiController]
    [Route("event")]
    public class EventController : ControllerBase
    {
        private IEventService _eventService;

        public EventController(IEventService eventService)
        {
            this._eventService = eventService;
        }

        [HttpGet]
        [Route("")]
        public async Task<Response<GetEventsResponseDto>> Index([FromQuery] GetEventsRequestDto request)
        {
            try
            {
                Guid tenantId;
                if (Request.Headers.TryGetValue("X-Tenant-ID", out var tenantIdHeader) && Guid.TryParse(tenantIdHeader.ToString(), out tenantId))
                {
                        return await this._eventService.GetEvents(tenantId, request);
                }
                else
                {
                    throw new ArgumentException("Tenant id not found in  header");
                }
                
            }
            catch (Exception ex)
            {
                return new Response<GetEventsResponseDto>
                {
                    Success = false,
                    Message = $"An error occurred while fetching events: {ex.Message}"
                };
            }
        }

        [HttpPost]
        [Route("createUpdate")]
        public async Task<Response<string>> CreateUpdate([FromBody] CreateUpdateEventRequestDto request)
        {
            try
            {
                Guid tenantId;
                if (Request.Headers.TryGetValue("X-Tenant-ID", out var tenantIdHeader) && Guid.TryParse(tenantIdHeader.ToString(), out tenantId))
                {
                    return await this._eventService.CreateUpdate(tenantId, request);
                }
                else
                {
                    throw new ArgumentException("Tenant id not found in  header");
                }

            }
            catch (Exception ex)
            {
                return new Response<string>
                {
                    Success = false,
                    Message = $"An error occurred while creating or updating the event: {ex.Message}"
                };
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<Response<string>> DeleteEvent([FromBody] DeleteEventRequestDto request)
        {
            try
            {
                return await this._eventService.Delete(request);
            }
            catch (Exception ex)
            {
                return new Response<string>
                {
                    Success = false,
                    Message = $"An error occurred while creating or updating the event: {ex.Message}"
                };
            }
        }
    }
}
