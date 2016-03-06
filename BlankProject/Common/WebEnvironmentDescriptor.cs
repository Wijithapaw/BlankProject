using $ext_safeprojectname$.Domain.Common;
using $ext_safeprojectname$.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace $ext_safeprojectname$.Common
{
    public class WebEnvironmentDescriptor : IEnvironmentDescriptor
    {
        public string UserID { get; set; }

        public WebEnvironmentDescriptor()
        {
            UserID = HttpContext.Current.User.Identity.GetUserId();
        }       
    }
}