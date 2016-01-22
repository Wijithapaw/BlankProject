using BlankProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankProject.Domain
{
    public interface IDataContext
    {
        DbSet<User> Users { get; set; }

        DbSet<Admin> Admins { get; set; }

        int SaveChanges();
    }
}
