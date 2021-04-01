using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace northwinddb
{
    public class product
    {
        public int productID{get; set;}

        [Required]
        [StringLength(40)]
        public string ProductName{get; set;}

        [Column("UnitPrice", TypeName = "money")]
        public decimal? Cost{get; set;}

        [Column("UnitsInStock")]
        public short? stock{get; set;}

        public bool discontinued{get; set;}
        // these two define the foreign key relationship
        // to the categories table
        public int CategoryID{get; set;}

        public virtual category category{get; set;}
        
    }
}