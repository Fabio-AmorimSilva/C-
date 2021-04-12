using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindContextLib;
using Packt.CS7;

namespace NorthwindEmployees.PacktFeatures.Pages
{
    public class EmployeesPageModel : PageModel
    {

        private Northwind db;
        public EmployeesPageModel(Northwind injectedContext){

            db = injectedContext;

        }

        public IEnumerable<string> Employees{get; set;}
        public void OnGet()
        {

            Employees = db.Employees.Select(e => e.FirstName);

        }
    }
}
