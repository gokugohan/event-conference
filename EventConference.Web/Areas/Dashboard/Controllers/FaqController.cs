using AutoMapper;
using EventConference.Contracts;
using EventConference.Entities.Models;
using EventConference.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EventConference.Web.Areas.Dashboard.Controllers
{
    public class FaqController : DashboardBaseController
    {
        public FaqController(
            ILoggerManager loggerManager, IRepositoryWrapper repositoryWrapper, IMapper mapper) : base(loggerManager, repositoryWrapper, mapper)
        {
        }


        // GET: Faq
        public ActionResult Index()
        {
            var faqs = this.repositoryWrapper.Faq.GetAllFaqs();

            return View(faqs);
        }


       

        // GET: Faq/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Faq/Create
        public ActionResult Add()
        {
            return View();
        }

        // POST: Faq/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(FaqViewModel model)
        {
            try
            {
                // apply mapping 

                var faq = this.mapper.Map<Faq>(model);
                this.repositoryWrapper.Faq.Create(faq);
                this.repositoryWrapper.Save();
                this.loggerManager.LogInfo($"(Dashboard - FAQ) add new faq to database.");
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                this.loggerManager.LogError($"(Dashboard - FAQ) Something went wrong when try to add new faq: {ex.Message}");
                return View();
            }
        }


        // POST: Faq/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FaqViewModel model)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Faq/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Faq/Delete/5
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