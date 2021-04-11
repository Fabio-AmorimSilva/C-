using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using NorthwindContextLib;
using System.Linq;
using Packt.CS7;
using Microsoft.AspNetCore.Mvc;

namespace NorthwindWeb.Pages{

    public class SuppliersModel : PageModel
    {
        public IEnumerable<string> Suppliers{get; set;}
        public IEnumerable<string> Phones{get; set;}
        public IEnumerable<string> Countries{get; set;}

        [BindProperty]
        public Supplier Supplier{get; set;}
        private Northwind db;

        public SuppliersModel(Northwind injectedContext){

            db = injectedContext;
            
        }


        public void OnGet(){

            ViewData["Title"] = "Northwind Web Site - Suppliers";

            Suppliers = db.Suppliers.Select(s => s.CompanyName);
            Phones = db.Suppliers.Select(p => p.Phone);
            Countries = db.Suppliers.Select(c => c.Country);
            
        }

        
        public IActionResult OnPost(){
            if(ModelState.IsValid){
                db.Suppliers.Add(Supplier);
                db.SaveChanges();
                return RedirectToPage("/Suppliers");
                
            }

            return Page();
        }
        


        
    }
}