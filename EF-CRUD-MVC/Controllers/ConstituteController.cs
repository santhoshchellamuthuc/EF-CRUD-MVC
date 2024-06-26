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
            try
            {
                return View("List", refer.Showall());
            }
            catch(Exception)
            {
                return View("Error");
            }
        }

        // GET: ConstituteController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return View("Search", refer.Search(id));
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        // GET: ConstituteController/Create
        public ActionResult Create()
        {
            try
            {
                var district = refer.Show();
                var newmodel = new ConstituteDetails();
                newmodel.District = district;
                return View("Insert", newmodel);
            }catch(Exception)
            {
                return View("Error");
            }
        }

        // POST: ConstituteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ConstituteDetails create)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    refer.Insert(create);
                    return RedirectToAction(nameof(List));
                }
                else
                {
                    return View("Error");
                }
               
            }
            catch(Exception)
            {
                return View("Error", " Operation does not reached");
            }
        }

        // GET: ConstituteController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                return View("Edit", refer.Search(id));
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        // POST: ConstituteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ConstituteDetails update)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    refer.Edit(update);
                    return RedirectToAction(nameof(List));
                }
                else
                {
                    return View("Edit", "Opration Everything Failed");
                }
        
            }
            catch
            {
                return View("Edit"," Invailed Opration");
            }
        }

        // GET: ConstituteController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                return View("Delete", refer.Search(id));
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        // POST: ConstituteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ConstituteDetails Remove)
        {
            try
            {
                refer.Delete(Remove);
                return RedirectToAction(nameof(List));
            }
            catch(Exception)
            {
                return View("Delete","Invailed Opration");
            }
        }
    }
}
