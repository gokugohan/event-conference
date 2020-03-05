using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventConference.Contracts;
using EventConference.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventConference.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ApiController
    {
        public EventController(ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper, IMapper mapper) : base(loggerManager, repositoryWrapper, mapper)
        {
        }


        // GET: api/Faq
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var events = this.repositoryWrapper.Event.GetAllEvents();
                this.loggerManager.LogInfo($"(API) Returned all events from database.");

                return Ok(new { data = events });
            }
            catch (Exception ex)
            {
                this.loggerManager.LogError($"(API) Something went wrong inside GetAllEvents action: {ex.Message}");
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        //// GET: api/Faq/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Faq
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Faq/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
