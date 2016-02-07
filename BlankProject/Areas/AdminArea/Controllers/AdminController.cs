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
        
        public ActionResult Index()
        {
            var admins = AdminService.GetAll();
            return View(admins);
        }
    }
}
