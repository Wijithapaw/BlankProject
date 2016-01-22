using BlankProject.Data;
using BlankProject.Domain;
using BlankProject.Domain.Services;
using BlankProject.Domain.Entities;
using BlankProject.Models;
using BlankProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlankProject.Areas.AdminArea.Controllers
{
    [AllowAnonymous]
    public class AdminController : _BaseController
    {
        private readonly IAdminService AdminService;

        public AdminController()
        {
            //TODO implement this usng dependency injection
            IDataContext dbContext = new DataContext();
            //AdminService = adminService;
            AdminService = new AdminService(dbContext);
        }

        // GET: Admin/Admin
        public ActionResult Index()
        {
            var admins = AdminService.GetAll();
            return View(admins);
        }

        // GET: Admin/Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Admin/Create
        [HttpPost]
        public ActionResult Create(RegisterViewModel model)
        {
            //try
            //{
            // TODO: Add insert logic here

            if (ModelState.IsValid)
            {
                var admin = new Admin() { FirstName = model.FirstName, LastName = model.LastName, Username = model.Username, Email = model.Email };

                AdminService.Create(admin);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            //}
            //catch
            //{
               // return View();
            //}
        }

        // GET: Admin/Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
