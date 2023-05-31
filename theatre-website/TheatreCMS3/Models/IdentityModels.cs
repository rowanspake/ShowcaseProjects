using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TheatreCMS3.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public ApplicationDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }



        /* ▼ Put DbSet's for your models below ▼ */
        public System.Data.Entity.DbSet<TheatreCMS3.Areas.Blog.Models.Comment> Comments { get; set; }

        public System.Data.Entity.DbSet<TheatreCMS3.Areas.Blog.Models.BlogPost> BlogPosts { get; set; }

        public System.Data.Entity.DbSet<TheatreCMS3.Areas.Blog.Models.BlogAuthor> BlogAuthors { get; set; }

        public System.Data.Entity.DbSet<TheatreCMS3.Areas.Prod.Models.CalendarEvent> CalendarEvent { get; set; }
        public System.Data.Entity.DbSet<TheatreCMS3.Areas.Prod.Models.Production> Production { get; set; }

        public System.Data.Entity.DbSet<TheatreCMS3.Areas.Prod.Models.CastMember> CastMembers { get; set; }

        public System.Data.Entity.DbSet<TheatreCMS3.Areas.Rent.Models.RentalHistory> RentalHistories { get; set; }
        
    }


}