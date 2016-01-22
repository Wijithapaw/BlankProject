using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlankProject.Areas.AdminArea.Controllers
{

    [RouteArea("AdminArea", AreaPrefix = "admin")]
    [Authorize(Roles = "Administrator")]
    public abstract class _BaseController : Controller
    {

    }
}