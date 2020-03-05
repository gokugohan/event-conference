using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventConference.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EventConference.Api.Controllers
{
    [ApiController]
    [Route("api/speaker")]
    public class SpeakerController : ApiController
    {
        public SpeakerController(ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper, IMapper mapper) : base(loggerManager, repositoryWrapper, mapper)
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var owners = this.repositoryWrapper.Speaker.GetAllSpeakers();
                this.loggerManager.LogInfo($"(API) Returned all speakers from database.");

                return Ok(owners);
            }
            catch (Exception ex)
            {
                this.loggerManager.LogError($"(API) Something went wrong inside GetAllSpeakers action: {ex.Message}");
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet("{id}", Name = "SpeakerById")]
        public IActionResult SpeakerById(Guid id)
        {
            try
            {
                var owner = this.repositoryWrapper.Speaker.GetSpeakerById(id);
                if (owner == null)
                {
                    this.loggerManager.LogError($"(API) Speaker with id: {id}, hasn't been found in db");
                    return NotFound();
                }
                else
                {
                    this.loggerManager.LogInfo($"(API) Return speaker with id: {id}");
                    return Ok(owner);
                }
            }
            catch (Exception ex)
            {
                this.loggerManager.LogError($"(API) Something went wrong inside GetSpeakerById action: {ex.Message}");
                return StatusCode(500, "(API) Internal server error");
            }
        }


       
    }
}