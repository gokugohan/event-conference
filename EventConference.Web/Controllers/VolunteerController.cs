using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventConference.Contracts;
using EventConference.Web.Models;
using EventConference.Web.Models.Event;
using Microsoft.AspNetCore.Mvc;

namespace EventConference.Web.Controllers
{
    public class VolunteerController : BaseController
    {
        public VolunteerController(ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper, IMapper mapper) 
            : base(loggerManager, repositoryWrapper,mapper)
        {
        }

        public IActionResult Index()
        {

            var ev = this.repositoryWrapper.Event.GetActiveEventsWithAssociates();
            this.homeViewModel.Event = this.mapper.Map<EventViewModel>(ev);
            this.homeViewModel.Volunteers = this.mapper.Map<IEnumerable<VolunteerModelView>>(this.repositoryWrapper.Volunteer.GetAllVolunteersByEventId(ev.Id));
            return View(this.homeViewModel);
        }

        public IActionResult Register(VolunteerModelView model)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}