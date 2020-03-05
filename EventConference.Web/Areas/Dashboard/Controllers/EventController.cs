using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventConference.Contracts;
using EventConference.Entities.Models;
using EventConference.Web.Models.Event;
using Microsoft.AspNetCore.Mvc;

namespace EventConference.Web.Areas.Dashboard.Controllers
{
    public class EventController : DashboardBaseController
    {
        public EventController(ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper, IMapper mapper) : base(loggerManager, repositoryWrapper, mapper)
        {
        }

        // GET: Event
        public ActionResult Index()
        {
            var events = this.repositoryWrapper.Event.GetAllEvents();
            var model = this.mapper.Map<IEnumerable<EventViewModel>>(events);
            this.loggerManager.LogInfo($"{User.Identity.Name}  access Index page (Dashboard.EventController.Index)");
            return View(model);
        }

        // GET: Event/Details/5
        public ActionResult Details(Guid id)
        {
            var ev = this.repositoryWrapper.Event.GetEventById(id);
            if (ev == null)
            {
                this.loggerManager.LogError($"{User.Identity.Name} trying to find session {id} but could not find it (Dashboard.EventController.Details)");
            }
            var model = this.mapper.Map<EventViewModel>(ev);
            this.loggerManager.LogError($"{User.Identity.Name} trying to find session {id} on page (Dashboard.EventController.Details)");
            return View(model);
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            var model = new CreateEventViewModel();
            this.loggerManager.LogInfo($"{User.Identity.Name}  access Create(Get) page  (Dashboard.EventController.Create)");
            return View(model);
        }

        // POST: Event/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateEventViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var e = this.mapper.Map<Event>(model);
                    this.repositoryWrapper.Event.Create(e);
                    this.repositoryWrapper.Save();
                    this.loggerManager.LogInfo($"{User.Identity.Name}  access Create(Post) page (Dashboard.EventController.Create)");
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                this.loggerManager.LogInfo($"{User.Identity.Name}  access Create(Post) page (Dashboard.EventController.Create). Error: {ex.Message}");
                return View(model);
            }
        }

        // GET: Event/Edit/5
        public IActionResult Edit(Guid id)
        {

            var ev = this.repositoryWrapper.Event.GetEventById(id);
            if (ev == null)
            {
                this.loggerManager.LogInfo($"{User.Identity.Name}  access Edit(Get) {id} (not found) page (Dashboard.EventController.Edit)");
                return NotFound();
            }
            var model = this.mapper.Map<EditEventViewModel>(ev);

            this.loggerManager.LogInfo($"{User.Identity.Name}  access Edit(Get) page (Dashboard.SesionController.Edit)");
            return View(model);
        }

        // POST: Event/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, EditEventViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var e = this.mapper.Map<Event>(model);
                    this.repositoryWrapper.Event.Update(e);
                    this.repositoryWrapper.Save();
                    this.loggerManager.LogInfo($"{User.Identity.Name}  access Edit(Post) page (Dashboard.SesionController.Edit)");
                }
                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                this.loggerManager.LogInfo($"{User.Identity.Name}  access Create(Post) page (Dashboard.SesionController.Edit). Error: {ex.Message}");
                return View(model);
            }
        }

        // GET: Event/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View();
        }

        // POST: Event/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EventViewModel model)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}