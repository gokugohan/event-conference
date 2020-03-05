using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EventConference.Contracts;
using EventConference.Web.Models;
using EventConference.Web.Models.Event;
using AutoMapper;

namespace EventConference.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper,IMapper mapper) 
            : base(loggerManager, repositoryWrapper,mapper)
        {
        }

        public IActionResult Index()
        {
            try
            {
                var ev = this.repositoryWrapper.Event.GetActiveEventsWithAssociates();

                this.homeViewModel.Event = this.mapper.Map<EventViewModel>(ev);
                //this.homeViewModel.Speakers = this.mapper.Map<IEnumerable<SpeakerViewModel>>(this.repositoryWrapper.Speaker.GetSpeakersByEventId(ev.Id));
                this.homeViewModel.SessionDays = this.repositoryWrapper.Session.GetAllSessionOfEventByIdAndGroupByDay(ev.Id);
                //this.homeViewModel.Venues = this.repositoryWrapper.Venue.GetAllVenues();
                this.homeViewModel.Faqs = this.mapper.Map<IEnumerable<FaqViewModel>>(this.repositoryWrapper.Faq.GetAllFaqs());
            }
            catch (Exception ex)
            {
                this.loggerManager.LogError($"Something went wrong inside EventConference.Web.Controllers.HomeController.Index action: {ex.Message}");
            }

            return View(this.homeViewModel);
        }


        public IActionResult Privacy()
        {
            return View(this.homeViewModel);
        }

        public IActionResult AboutUs()
        {
            return View(this.homeViewModel);
        }

        public IActionResult Services()
        {
            return View(this.homeViewModel);
        }

        public IActionResult TermOfService()
        {
            return View(this.homeViewModel);
        }


        [Route("Home/Subscribe", Name = "Subscribe")]
        public string Subscribe(SubscribeViewModel model)
        {
            if (ModelState.IsValid)
            {
                return $"{model.Email} - subscribed";
            }
            return "Upss";
        }

        public IActionResult Teste()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
