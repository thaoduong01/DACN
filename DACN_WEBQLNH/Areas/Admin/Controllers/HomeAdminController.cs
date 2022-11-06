﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QLWebNH.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        [Area("Admin")]
        // GET: HomeAdminController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomeAdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeAdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeAdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: HomeAdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeAdminController/Edit/5
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

        // GET: HomeAdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeAdminController/Delete/5
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
