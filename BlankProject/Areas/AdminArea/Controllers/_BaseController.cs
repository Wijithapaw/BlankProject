using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $ext_safeprojectname$.Areas.AdminArea.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class _BaseController : Controller
    {
        
    }
}