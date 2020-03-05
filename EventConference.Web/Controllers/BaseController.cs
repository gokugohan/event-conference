using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventConference.Contracts;
using EventConference.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventConference.Web.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ILoggerManager loggerManager;
        protected readonly IRepositoryWrapper repositoryWrapper;
        protected readonly IMapper mapper;
        protected HomeViewModel homeViewModel;

        public BaseController(ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            this.loggerManager = loggerManager;
            this.repositoryWrapper = repositoryWrapper;
            this.mapper = mapper;
            if (this.homeViewModel == null)
            {
                this.homeViewModel = new HomeViewModel();
            }
            
            this.homeViewModel.Settings = this.repositoryWrapper.Setting.GetAllSettingsAsDictionary();
        }

    }
}