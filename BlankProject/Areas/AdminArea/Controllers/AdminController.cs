using BlankProject.Areas.AdminArea.Models;
using BlankProject.Data;
using BlankProject.Domain;
using BlankProject.Domain.Entities;
using BlankProject.Domain.Services;
using BlankProject.Services;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlankProject.Areas.AdminArea.Controllers
{
    public class AdminController : _BaseController
    {
        private readonly IAdminService AdminService;

        public AdminController(IAdminService adminService)
        {
            this.AdminService = adminService;
        }

        // GET: AdminArea/Admin
        public ActionResult Index()
        {
            var admins = AdminService.GetAll();
            return View(admins);
        }

        // GET: AdminArea/Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }        

        // GET: AdminArea/Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminArea/Admin/Edit/5
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

        // GET: AdminArea/Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminArea/Admin/Delete/5
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
