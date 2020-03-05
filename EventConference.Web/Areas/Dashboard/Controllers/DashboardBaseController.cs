using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventConference.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EventConference.Web.Areas.Dashboard.Controllers
{
    [Area(areaName: "dashboard")]
    [Authorize]
    public class DashboardBaseController : Controller
    {
        protected readonly ILoggerManager loggerManager;
        protected readonly IRepositoryWrapper repositoryWrapper;
        protected readonly IMapper mapper;
        public DashboardBaseController(ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            this.loggerManager = loggerManager;
            this.repositoryWrapper = repositoryWrapper;
            this.mapper = mapper;
        }
    }
}