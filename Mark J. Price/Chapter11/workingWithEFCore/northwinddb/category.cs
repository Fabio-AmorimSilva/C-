using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace northwinddb
{
    public class category
    {
        // these properties map to columns in the database
        public int categoryID {get; set;}
        public string categoryName{get; set;}
        [Column(TypeName = "ntext")]
        public string description{get; set;}

        //defines a navigation property for related rows
        public virtual ICollection<product> products{get; set;}

        public category(){
            // to enable developers to add products to a category we must
            // initialize the navigation property to an empty list
            this.products = new List<product>();
            
        }
        
    }
}