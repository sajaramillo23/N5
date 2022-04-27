using Microsoft.EntityFrameworkCore;
using N5.Domain.Entities;

namespace N5.Persistance.Sql
{
    public class N5DbContext : DbContext
    {
        //new tables
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }
        public DbSet<EmployeePermission> EmployeePermissions { get; set; }
        //end new tables

        //public DbSet<Item> Comments { get; set; }

        public N5DbContext()
        {

        }

        public N5DbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(N5DbContext).Assembly);
            
            base.OnModelCreating(modelBuilder);
            
            RenameTables(modelBuilder);
        }

        private static void RenameTables(ModelBuilder modelBuilder)
        {
            //new tables
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Permission>().ToTable("Permission");
            modelBuilder.Entity<PermissionType>().ToTable("PermissionType");
            modelBuilder.Entity<EmployeePermission>().ToTable("EmployeePermission");
            //end new tables
            /*
            modelBuilder.Entity<User>(b =>
            {
                b.ToTable("Users");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(b =>
            {
                b.ToTable("UserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.ToTable("UserLogins");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(b =>
            {
                b.ToTable("UserTokens");
            });

            modelBuilder.Entity<IdentityRole>(b =>
            {
                b.ToTable("Roles");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(b =>
            {
                b.ToTable("RoleClaims");
            });

            modelBuilder.Entity<IdentityUserRole<string>>(b =>
            {
                b.ToTable("UserRoles");
            });
            */
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionBuilder)
        {
            if (!dbContextOptionBuilder.IsConfigured)
            {
                dbContextOptionBuilder.UseSqlServer("SqlConnection");
            }
        }
    }
}
