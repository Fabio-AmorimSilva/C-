using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using NorthwindEntitesLib;

namespace Packt.CS7
    {
        public class Customer
        {
            public string CustomerID { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public string Phone { get; set; }
            public string Fax { get; set; }

            [InverseProperty(nameof(Order.Customer))]
            [XmlIgnore]
            public ICollection<Order> Orders { get; set; }
        }
    }