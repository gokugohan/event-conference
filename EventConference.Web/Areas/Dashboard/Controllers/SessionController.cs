using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventConference.Contracts;
using EventConference.Entities.Models;
using EventConference.Web.Models;
using EventConference.Web.Models.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventConference.Web.Areas.Dashboard.Controllers
{
    public class SessionController : DashboardBaseController
    {
        public SessionController(ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper, IMapper mapper) : base(loggerManager, repositoryWrapper, mapper)
        {
        }

        // GET: Session
        public ActionResult Index()
        {
            var sessions = this.repositoryWrapper.Session.GetAllSessionAndGroupByDay();
            var model = this.mapper.Map<IEnumerable<SessionByDayViewModel>>(sessions);
            this.loggerManager.LogInfo($"{User.Identity.Name}  access Index page (Dashboard.SesionController.Index)");
            return View(model);
        }

        // GET: Session/Details/5
        public ActionResult Details(Guid id)
        {
            var session = this.repositoryWrapper.Session.GetSessionById(id);
            if (session == null)
            {
                this.loggerManager.LogError($"{User.Identity.Name} trying to find session {id} but could not find it (Dashboard.SesionController.Details)");
            }
            var model = this.mapper.Map<SessionViewModel>(session);
            this.loggerManager.LogError($"{User.Identity.Name} trying to find session {id} on page (Dashboard.SesionController.Details)");
            return View(model);
        }

        // GET: Session/Create
        public ActionResult Create()
        {
            var speakers = this.mapper.Map<IList<SpeakerViewModel>>(this.repositoryWrapper.Speaker.GetAllSpeakers());
            ViewBag.Speakers = speakers;
            var model = new CreateSessionViewModel();
            this.loggerManager.LogInfo($"{User.Identity.Name}  access Create(Get) page  (Dashboard.SesionController.Create)");
            return View(model);
        }

        // POST: Session/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateSessionViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var session = this.mapper.Map<Session>(model);
                    this.repositoryWrapper.Session.Create(session);
                    this.repositoryWrapper.Save();
                    this.loggerManager.LogInfo($"{User.Identity.Name}  access Create(Post) page (Dashboard.SesionController.Create)");
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                var speakers = this.mapper.Map<IList<SpeakerViewModel>>(this.repositoryWrapper.Speaker.GetAllSpeakers());
                ViewBag.Speakers = speakers;
                ModelState.AddModelError("", ex.Message);
                this.loggerManager.LogInfo($"{User.Identity.Name}  access Create(Post) page (Dashboard.SesionController.Create). Error: {ex.Message}");
                return View(model);
            }
        }

        // GET: Session/Edit/5
        public IActionResult Edit(Guid id)
        {
            var session = this.repositoryWrapper.Session.GetSessionById(id);
            if (session == null)
            {
                this.loggerManager.LogInfo($"{User.Identity.Name}  access Edit(Get) {id} (not found) page (Dashboard.SesionController.Edit)");
                return NotFound();
            }
            var model = this.mapper.Map<EditSessionViewModel>(session);

            var speakers = this.mapper.Map <IList<SpeakerViewModel>>(this.repositoryWrapper.Speaker.GetAllSpeakers());
            ViewBag.Speakers = speakers;
            this.loggerManager.LogInfo($"{User.Identity.Name}  access Edit(Get) page (Dashboard.SesionController.Edit)");
            return View(model);
        }

        // POST: Session/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, EditSessionViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var session = this.mapper.Map<Session>(model);
                    this.repositoryWrapper.Session.Update(session);
                    this.repositoryWrapper.Save();
                    this.loggerManager.LogInfo($"{User.Identity.Name}  access Edit(Post) page (Dashboard.SesionController.Edit)");
                }
                return RedirectToAction(nameof(Index));
                
            }
            catch(Exception ex)
            {
                var speakers = this.mapper.Map<IList<SpeakerViewModel>>(this.repositoryWrapper.Speaker.GetAllSpeakers());
                ViewBag.Speakers = speakers;
                ModelState.AddModelError("", ex.Message);
                this.loggerManager.LogInfo($"{User.Identity.Name}  access Create(Post) page (Dashboard.SesionController.Edit). Error: {ex.Message}");
                return View(model);
            }
        }

        // GET: Session/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Session/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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