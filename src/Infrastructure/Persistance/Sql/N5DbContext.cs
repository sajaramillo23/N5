using Microsoft.EntityFrameworkCore;
using N5.Domain.Entities;

namespace N5.Persistance.Sql
{
    public class N5DbContext : DbContext
    {        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }
        public DbSet<EmployeePermission> EmployeePermissions { get; set; }
        
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
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Permission>().ToTable("Permission");
            modelBuilder.Entity<PermissionType>().ToTable("PermissionType");
            modelBuilder.Entity<EmployeePermission>().ToTable("EmployeePermission");            
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
