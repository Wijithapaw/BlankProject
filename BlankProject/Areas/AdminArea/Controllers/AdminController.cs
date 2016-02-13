using BlankProject.Areas.AdminArea.Models;
using BlankProject.Data;
using BlankProject.Domain;
using BlankProject.Domain.Entities;
using BlankProject.Domain.Services;
using BlankProject.Services;
using BlankProject.Utills;
using Microsoft.AspNet.Identity.Owin;
using MvcSiteMapProvider;
using MvcSiteMapProvider.Web.Mvc.Filters;
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

        /* Test method test site map nodes with url parameters
        [SiteMapTitle("FirstName", Target = AttributeTarget.ParentNode)]
        public ActionResult MoreDetails(string adminId)
        {
            SiteMapHelper.SetParentRouteValues("id", adminId);

            var admin = AdminService.Get(adminId);
            return View(admin);
        }*/
    }
}
