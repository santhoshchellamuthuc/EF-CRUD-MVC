using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SANTHOSHEFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_CRUD_MVC.Controllers
{
    public class ConstituteController : Controller
    {
        private readonly IEFRepot refer;

        public ConstituteController(IEFRepot connect)
        {
            refer = connect;
        }
        // GET: ConstituteController
        public ActionResult List()
        {
            return View("List",refer.Showall());
        }

        // GET: ConstituteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConstituteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConstituteController/Create
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

        // GET: ConstituteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConstituteController/Edit/5
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

        // GET: ConstituteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConstituteController/Delete/5
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
