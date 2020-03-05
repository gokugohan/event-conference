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
    public class FaqController : ApiController
    {
        public FaqController(ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper, IMapper mapper) : base(loggerManager, repositoryWrapper, mapper)
        {
        }


        // GET: api/Faq
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var faqs = this.repositoryWrapper.Faq.GetAllFaqs();
                this.loggerManager.LogInfo($"(API) Returned all faqs from database.");

                return Ok(new { data = faqs });
            }
            catch (Exception ex)
            {
                this.loggerManager.LogError($"(API) Something went wrong inside GetAllFaqs action: {ex.Message}");
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

    }
}
