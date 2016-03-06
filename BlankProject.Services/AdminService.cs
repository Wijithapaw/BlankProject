﻿using $ext_safeprojectname$.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using $ext_safeprojectname$.Domain.Entities;
using $ext_safeprojectname$.Domain;
using System.Runtime.Remoting.Contexts;

namespace $ext_safeprojectname$.Services
{
    public class AdminService : ServiceBase, IAdminService
    {
        
        public AdminService(IDataContext context) : base(context) { }
        
        public Admin Create(Admin admin)
        {
            Context.Admins.Add(admin);
            Context.SaveChanges();

            return admin;
        }

        public Admin Get(string id)
        {
            return Context.Admins.Find(id);
        }

        public IEnumerable<Admin> GetAll()
        {
            return Context.Admins;
        }

        public void Update(Admin model)
        {
            var admin = Get(model.Id);

            admin.FirstName = model.FirstName;
            admin.LastName = model.LastName;
            admin.Email = model.Email;

            Context.SaveChanges();
        }
    }
}
