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
    
    public class HomeController : DashboardBaseController
    {
        public HomeController(ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper, IMapper mapper) : base(loggerManager, repositoryWrapper, mapper)
        {
        }

        public IActionResult Index()
        {

            ViewBag.TotalParticipant = this.repositoryWrapper.Participant.Total();
            ViewBag.TotalSpeaker = this.repositoryWrapper.Speaker.Total();
            ViewBag.TotalSponsor = this.repositoryWrapper.Sponsor.Total();
            ViewBag.TotalSession = this.repositoryWrapper.Session.Total();
            return View();
        }

        public IActionResult Select()
        {
            
            var events = this.repositoryWrapper.Event.GetAllEvents();
            return View(events);
        }
    }
}