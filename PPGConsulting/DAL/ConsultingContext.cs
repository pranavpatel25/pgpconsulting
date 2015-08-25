using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PPGConsulting.Models;


namespace PPGConsulting.DAL
{
        public class ConsultingContext : DbContext
    {

            public ConsultingContext()    : base("ConsultingContext")
        {
        }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Study> Studies { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<ProjectEmployees> ProjectEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
 