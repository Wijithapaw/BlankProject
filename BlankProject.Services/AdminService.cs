using BlankProject.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlankProject.Domain.Entities;
using BlankProject.Domain;

namespace BlankProject.Services
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

        public Admin Get(int id)
        {
            return Context.Admins.Find(id);
        }

        public IEnumerable<Admin> GetAll()
        {
            return Context.Admins;
        }

        public Admin Update(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}
