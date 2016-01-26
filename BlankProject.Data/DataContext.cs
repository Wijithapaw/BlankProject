using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using BlankProject.Domain.Entities;
using BlankProject.Domain;

namespace BlankProject.Data
{
   
    public class DataContext : IdentityDbContext<User>, IDataContext
    {
        public IDbSet<Admin> Admins { get; set; }

        public DataContext()
            : base("DataContext", throwIfV1Schema: false)
        {
        }

        public static DataContext Create()
        {
            return new DataContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
        }

        public static void Initialize()
        {
            Database.SetInitializer<DataContext>(
                new MigrateDatabaseToLatestVersion<DataContext, Migrations.Configuration>());

            using (var context = new DataContext())
                context.Database.Initialize(false);
        }
    }
}