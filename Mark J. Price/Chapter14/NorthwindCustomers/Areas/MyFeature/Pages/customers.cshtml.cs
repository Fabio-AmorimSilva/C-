using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindContextLib;
using Packt.CS7;

namespace NorthwindCustomers.MyFeature.Pages
{
    public class CustomersPageModel : PageModel
    {

        private Northwind db;

        public CustomersPageModel(Northwind injectedContext){

            db = injectedContext;

        }
        public IEnumerable<string> name{get; set;}
        public IEnumerable<string> country{get; set;}

        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Site - Customers";
            
            name = db.Customers.Select(cn => cn.ContactName);
            country = db.Customers.Select(c => c.Country);
            
        }
    }
}
