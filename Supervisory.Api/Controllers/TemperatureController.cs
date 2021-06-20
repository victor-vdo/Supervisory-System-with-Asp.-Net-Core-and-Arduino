using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Supervisory.Domain.Interfaces.Services;
using Supervisory.Domain.ViewModels;
using System;

namespace Supervisory.Api.Controllers
{
    public class TemperatureController : Controller
    {
        public readonly ITemperatureService _service;

        public TemperatureController(ITemperatureService service)
        {
            _service = service;
        }

        // GET: TemperatureController
        public ActionResult List()
        {
            var model = _service.ReadAll();
            return View(model);
        }

        // GET: TemperatureController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TemperatureController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TemperatureController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TemperatureViewModel model)
        {
            try
            {
                return RedirectToAction(nameof(model));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: TemperatureController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TemperatureController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TemperatureController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TemperatureController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
