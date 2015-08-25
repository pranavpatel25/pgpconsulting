using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPGConsulting.Models;

namespace PPGConsulting.DAL
{
    public class ConsultingInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ConsultingContext>
    {
        protected override void Seed(ConsultingContext context)
        {
            //var employees = new List<Employee>
            //{
            //new Employee{FirstMidName="Carson",LastName="Alexander",Title="Developer I",HireDate=DateTime.Parse("2005-09-01")},
            //new Employee{FirstMidName="Meredith",LastName="Alonso",Title="Developer II",HireDate=DateTime.Parse("2002-09-01")},
            //new Employee{FirstMidName="Arturo",LastName="Anand",Title="Developer III",HireDate=DateTime.Parse("2003-09-01")},
            //new Employee{FirstMidName="Gytis",LastName="Barzdukas",Title="Developer I",HireDate=DateTime.Parse("2002-09-01")},
            //new Employee{FirstMidName="Yan",LastName="Li",Title="Developer II",HireDate=DateTime.Parse("2002-09-01")},
            //new Employee{FirstMidName="Peggy",LastName="Justice",Title="Developer III",HireDate=DateTime.Parse("2001-09-01")},
            //new Employee{FirstMidName="Laura",LastName="Norman",Title="Developer I",HireDate=DateTime.Parse("2003-09-01")},
            //new Employee{FirstMidName="Nino",LastName="Olivetto",Title="Developer II",HireDate=DateTime.Parse("2005-09-01")}
            //};

            //employees.ForEach(s => context.Employees.Add(s));
            //context.SaveChanges();
            //var study = new List<Study>
            //{
            //new Study{ProjectCode="MERCK1234",ClientName="Merck",},
            //new Study{ProjectCode="ASTRA1234",ClientName="AstraZeneca",},
            //new Study{ProjectCode="BIO1234",ClientName="Biogen",},
            //new Study{ProjectCode="SANO1234",ClientName="Sanofi",},
            //new Study{ProjectCode="QUINT1234",ClientName="Quintile",},
            //new Study{ProjectCode="ASTEL1234",ClientName="Astellas",},
            //new Study{ProjectCode="BAYE1234",ClientName="Bayer",},

            //};
            //study.ForEach(s => context.Studies.Add(s));
            //context.SaveChanges();
            //var projects = new List<Project>
            //{
            //new Project{StudyID=1,EmployeeID=1,StartDate=DateTime.Parse("2005-06-01"),EndDate=DateTime.Parse("2005-07-01"),ProjectCode="MERK347"},
            //new Project{StudyID=2,EmployeeID=2,StartDate=DateTime.Parse("2005-06-15"),EndDate=DateTime.Parse("2005-07-15"),ProjectCode="TEVA347"},
            //new Project{StudyID=3,EmployeeID=1,StartDate=DateTime.Parse("2005-06-15"),EndDate=DateTime.Parse("2005-07-15"),ProjectCode="PFIZER347"},
            //new Project{StudyID=4,EmployeeID=3,StartDate=DateTime.Parse("2005-06-01"),EndDate=DateTime.Parse("2005-07-01"),ProjectCode="MERK547"},
            //new Project{StudyID=5,EmployeeID=4,StartDate=DateTime.Parse("2005-06-01"),EndDate=DateTime.Parse("2005-07-01"),ProjectCode="ATZ347"},
            //new Project{StudyID=6,EmployeeID=5,StartDate=DateTime.Parse("2005-06-01"),EndDate=DateTime.Parse("2005-07-01"),ProjectCode="MERK947"},
            //new Project{StudyID=7,EmployeeID=6,StartDate=DateTime.Parse("2005-06-01"),EndDate=DateTime.Parse("2005-07-01"),ProjectCode="MERK147"},
            //};
            //projects.ForEach(s => context.Projects.Add(s));
            //context.SaveChanges();
        }
    }
}
