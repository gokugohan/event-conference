using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventConference.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EventConference.Api.Controllers
{
    public class ApiController : ControllerBase
    {
        protected readonly ILoggerManager loggerManager;
        protected readonly IRepositoryWrapper repositoryWrapper;
        protected readonly IMapper mapper;
        public ApiController(ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            this.loggerManager = loggerManager;
            this.repositoryWrapper = repositoryWrapper;
            this.mapper = mapper;
        }
    }
}