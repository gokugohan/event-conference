using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventConference.Api.ViewModels;
using EventConference.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventConference.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ApiController
    {
        public SessionController(ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper, IMapper mapper) : base(loggerManager, repositoryWrapper, mapper)
        {
        }


        // GET: api/Faq
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //var sessions = this.repositoryWrapper.Session.GetAllSessionWithConferenceAndSpeakers();

                var sessions = this.repositoryWrapper.Session.GetAllSessionAndGroupByDay();
                var results = this.mapper.Map<IList<SessionByDayViewModel>>(sessions);

                this.loggerManager.LogInfo($"(API) Returned all session from database.");

                return Ok(new { data = results });
            }
            catch (Exception ex)
            {
                this.loggerManager.LogError($"(API) Something went wrong inside Session - FindAll action: {ex.Message}");
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }


        [HttpGet("{id}", Name = "SessionById")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var session = this.repositoryWrapper.Session.GetSessionById(id);
                this.loggerManager.LogInfo($"(API) Returned all session from database.");
                var model = this.mapper.Map<SessionViewModel>(session);
                return Ok(new { data = model });
            }
            catch (Exception ex)
            {
                this.loggerManager.LogError($"(API) Something went wrong inside Session - GetSessionById action: {ex.Message}");
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }


        [HttpGet("{id}/speaker", Name = "GetSessionBySpeaker")]
        public IActionResult GetSessionBySpeaker(Guid id)
        {
            try
            {
                var owner = this.repositoryWrapper.Session.GetAllSessionsBySpeakerId(id);
                if (owner == null)
                {
                    this.loggerManager.LogError($"(API) Sessions with speaker id: {id}, hasn't been found in db");
                    return NotFound();
                }
                else
                {
                    this.loggerManager.LogInfo($"(API) Return Sessions of speaker with id: {id}");
                    return Ok(owner);
                }
            }
            catch (Exception ex)
            {
                this.loggerManager.LogError($"(API) Something went wrong inside GetAllSessionsBySpeakerId action: {ex.Message}");
                return StatusCode(500, "(API) Internal server error");
            }
        }
    }
}