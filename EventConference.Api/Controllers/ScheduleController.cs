using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventConference.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventConference.Api.Controllers
{
    [Route("api/schedule")]
    [ApiController]
    public class ScheduleController : ApiController
    {
        public ScheduleController(ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper, IMapper mapper) : base(loggerManager, repositoryWrapper, mapper)
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            //try
            //{
            //    var owners = this.repositoryWrapper.Schedule.GetAllSchedules();
            //    this.loggerManager.LogInfo($"(API) Returned all schedules from database.");

            //    return Ok(owners);
            //}
            //catch (Exception ex)
            //{
            //    this.loggerManager.LogError($"(API) Something went wrong inside GetAllSchedules action: {ex.Message}");
            //    return StatusCode(500, $"Internal Server Error: {ex.Message}");
            //}
            return Ok();
        }

        [HttpGet("{id}", Name = "GetScheduleById")]
        public IActionResult GetScheduleById(Guid id)
        {
            //try
            //{
            //    var owner = this.repositoryWrapper.Schedule.GetScheduleById(id);
            //    if (owner == null)
            //    {
            //        this.loggerManager.LogError($"(API) schedule with id: {id}, hasn't been found in db");
            //        return NotFound();
            //    }
            //    else
            //    {
            //        this.loggerManager.LogInfo($"(API) Return schedule with id: {id}");
            //        return Ok(owner);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.loggerManager.LogError($"(API) Something went wrong inside GetScheduleById action: {ex.Message}");
            //    return StatusCode(500, "(API) Internal server error");
            //}
            return Ok();
        }

        [HttpGet("{id}/speaker", Name = "GetScheduleBySpeaker")]
        public IActionResult GetScheduleBySpeaker(Guid id)
        {
            //try
            //{
            //    var owner = this.repositoryWrapper.Schedule.GetAllSchedulesBySpeakerId(id);
            //    if (owner == null)
            //    {
            //        this.loggerManager.LogError($"(API) Schedules with speaker id: {id}, hasn't been found in db");
            //        return NotFound();
            //    }
            //    else
            //    {
            //        this.loggerManager.LogInfo($"(API) Return schedules of speaker with id: {id}");
            //        return Ok(owner);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.loggerManager.LogError($"(API) Something went wrong inside GetAllSchedulesBySpeakerId action: {ex.Message}");
            //    return StatusCode(500, "(API) Internal server error");
            //}
            return Ok();
        }
    }
}