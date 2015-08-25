using PPGConsulting.Controllers;

namespace PPGConsulting.Migrations
{
    using PPGConsulting.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PPGConsulting.DAL.ConsultingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PPGConsulting.DAL.ConsultingContext context)
        {
            //var clients = new List<Client>
            //{
            //    new Client()
            //    {
            //        ID = 4,
            //        Projects = projects,

            //    }
            //}
            var employees = new List<Employee>
            {
                new Employee { FirstMidName = "Carson",   LastName = "Alexander", Title = "System Developer II",
                    HireDate = DateTime.Parse("2010-09-01") },
                new Employee { FirstMidName = "Meredith", LastName = "Alonso", Title = "System Developer I",    
                    HireDate = DateTime.Parse("2012-09-01") },
                new Employee { FirstMidName = "Arturo",   LastName = "Anand", Title = "System Developer III",     
                    HireDate = DateTime.Parse("2013-09-01") },
                new Employee { FirstMidName = "Gytis",    LastName = "Barzdukas", Title = "Group Lead", 
                    HireDate = DateTime.Parse("2012-09-01") },
                new Employee { FirstMidName = "Yan",      LastName = "Li", Title = "System Developer II",        
                    HireDate = DateTime.Parse("2012-09-01") },
                new Employee { FirstMidName = "Peggy",    LastName = "Justice", Title = "System Developer I",   
                    HireDate = DateTime.Parse("2011-09-01") },
                new Employee { FirstMidName = "Laura",    LastName = "Norman", Title = "System Developer III",    
                    HireDate = DateTime.Parse("2013-09-01") },
                new Employee { FirstMidName = "Nino",     LastName = "Olivetto", Title = "System Developer II",  
                    HireDate = DateTime.Parse("2005-08-11") }
            };
            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var studies = new List<Study>
            {
                new Study {ProjectCode = "MERCK1245",      ClientName = "MERCK", },
                new Study {ProjectCode = "ASTRA1234",      ClientName = "ASTRAZENECA", },
                new Study {ProjectCode = "QUINT1245",      ClientName = "QUINTILE", },
                new Study {ProjectCode = "SANOF1245",      ClientName = "SANOFI", },
                new Study {ProjectCode = "PFIZ1245",      ClientName = "PFIZER", },
                new Study {ProjectCode = "TEST1245",      ClientName = "TEST", },
                new Study {ProjectCode = "TEVA1245",      ClientName = "TEVA", }
            };
            studies.ForEach(s => context.Studies.AddOrUpdate(p => p.ProjectCode, s));
            context.SaveChanges();

            var projects = new List<Project>
            {
                new Project { 
                    EmployeeID = employees.Single(s => s.LastName == "Alexander").ID, 
                    StudyID = studies.Single(c => c.ProjectCode == "TEVA1245" ).StudyID, 
                    StartDate =  DateTime.Parse("2014-09-01") , EndDate =  DateTime.Parse("2014-09-15")
                },
                 new Project { 
                    EmployeeID = employees.Single(s => s.LastName == "Alexander").ID,
                    StudyID = studies.Single(c => c.ProjectCode == "PFIZ1245" ).StudyID, 
                    StartDate =  DateTime.Parse("2014-09-01") , EndDate =  DateTime.Parse("2014-09-15")
                 },                            
                 new Project { 
                    EmployeeID = employees.Single(s => s.LastName == "Alexander").ID,
                    StudyID = studies.Single(c => c.ProjectCode == "TEVA1245" ).StudyID, 
                    StartDate =  DateTime.Parse("2014-09-01") , EndDate =  DateTime.Parse("2014-09-15")
                 },
                 new Project { 
                     EmployeeID = employees.Single(s => s.LastName == "Alonso").ID,
                    StudyID = studies.Single(c => c.ProjectCode == "SANOF1245" ).StudyID, 
                    StartDate =  DateTime.Parse("2014-09-01") , EndDate =  DateTime.Parse("2014-09-15")
                 },
                 new Project { 
                     EmployeeID = employees.Single(s => s.LastName == "Alonso").ID,
                    StudyID = studies.Single(c => c.ProjectCode == "MERCK1245" ).StudyID, 
                    StartDate =  DateTime.Parse("2014-09-01") , EndDate =  DateTime.Parse("2014-09-15")
                 },
                 new Project {
                    EmployeeID = employees.Single(s => s.LastName == "Alonso").ID,
                    StudyID = studies.Single(c => c.ProjectCode == "QUINT1245" ).StudyID, 
                    StartDate =  DateTime.Parse("2014-09-01") , EndDate =  DateTime.Parse("2014-09-15") 
                 },
                 new Project { 
                    EmployeeID = employees.Single(s => s.LastName == "Anand").ID,
                    StudyID = studies.Single(c => c.ProjectCode == "TEVA1245" ).StudyID,
                    StartDate =  DateTime.Parse("2014-09-01") , EndDate =  DateTime.Parse("2014-09-15")
                 },
                 new Project { 
                    EmployeeID = employees.Single(s => s.LastName == "Anand").ID,
                    StudyID = studies.Single(c => c.ProjectCode == "MERCK1245").StudyID,
                    StartDate =  DateTime.Parse("2014-09-01") , EndDate =  DateTime.Parse("2014-09-15")         
                 },
                new Project { 
                    EmployeeID = employees.Single(s => s.LastName == "Barzdukas").ID,
                    StudyID = studies.Single(c => c.ProjectCode == "QUINT1245").StudyID,
                    StartDate =  DateTime.Parse("2014-09-01") , EndDate =  DateTime.Parse("2014-09-15")         
                 },
                 new Project { 
                    EmployeeID = employees.Single(s => s.LastName == "Li").ID,
                    StudyID = studies.Single(c => c.ProjectCode == "ASTRA1234").StudyID,
                    StartDate =  DateTime.Parse("2014-09-01") , EndDate =  DateTime.Parse("2014-09-15")         
                 },
                 new Project { 
                    EmployeeID = employees.Single(s => s.LastName == "Justice").ID,
                    StudyID = studies.Single(c => c.ProjectCode == "QUINT1245").StudyID,
                    StartDate =  DateTime.Parse("2014-09-01") , EndDate =  DateTime.Parse("2014-09-15")         
                 }
            };

            //int i = 1;

            //foreach (Project e in projects)
            //{

            //    var ProjectInDataBase = context.Projects.Where(
            //        s =>
            //             s.Employee.ID == e.EmployeeID &&
            //             s.Study.StudyID == e.StudyID).SingleOrDefault();
            //    if (ProjectInDataBase == null)
            //    {
            //        e.ProjectCode = "MERK" + (100 * i).ToString();
            //        context.Projects.Add(e);
            //    }
            //}
//            context.SaveChanges();
        }
    }
}