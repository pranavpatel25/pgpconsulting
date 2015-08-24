using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPGConsulting.Models;
namespace PPGConsulting.ViewModels
{
    public class ClientIndexData
    {
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Study> Studies { get; set; }
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<Employee> Employees { get; set; } 
    }
}