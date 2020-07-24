using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;
using System.Data.Entity;
using codixU.Models.Entities;

namespace codixU.Models
{
    public class AuthorizeContext : DbContext
    {
        public AuthorizeContext()
        {
            Database.Connection.ConnectionString = "Data Source=DESKTOP-O9AANFT;Initial Catalog=CodixU;Persist Security Info=True;User ID=codixu;Password=7654321"; 
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Users>()
                .HasMany<Roles>(s => s.Roles)
                .WithMany(c => c.Users)
                .Map(cs =>
                {
                    cs.MapLeftKey("UserRefID");
                    cs.MapRightKey("RoleRefID");
                    cs.ToTable("UsersRoles");
                });

            modelBuilder.Entity<Courses>()
                .HasMany<Users>(s => s._users)
                .WithMany(c => c._courses)
                .Map(cs =>
                {
                    cs.MapLeftKey("User_ID");
                    cs.MapRightKey("Courses_ID");
                    cs.ToTable("UsersCourses");

                });

            modelBuilder.Entity<Interactive>()
                .HasMany<Users>(s => s._users)
                .WithMany(c => c._interactive)
                .Map(cs =>
                {
                    cs.MapLeftKey("User_ID");
                    cs.MapRightKey("Interactive_ID");
                    cs.ToTable("UsersInteractive");
                });

            modelBuilder.Entity<Interactive>()
                .HasMany(q => q._quizzes)
                .WithRequired(i => i.Interactive);


            modelBuilder.Entity<Interactive>()
                .HasMany(c =>c._courses)
                .WithRequired(i => i.Interactive);



            modelBuilder.Entity<Quizzes>()
                .HasMany(q => q._questions)
                .WithRequired(t => t.Quizzes);
                

        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Roles> Roles { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Interactive> Interactives { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Quizzes> Quizzes { get; set; }
        
    }
}