using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SANTHOSHEFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_CRUD_MVC.Controllers
{
    public class DistrictController : Controller
    {
        private readonly IEFRepot refer;
        public DistrictController(IEFRepot interfaseconnect)
        {
            refer = interfaseconnect;
        }
        // GET: DistrictController
        public ActionResult Showall()
        {
           
            return View("Show",refer.Showall());
        }

        // GET: DistrictController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DistrictController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DistrictController/Create
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

        // GET: DistrictController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DistrictController/Edit/5
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

        // GET: DistrictController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DistrictController/Delete/5
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
