using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Suppliers
    {
        public long SupplierId { get; set; }
        public string SupplierName { get; set; }
        public long CityId { get; set; }
        public Cities City { get; set; }
        public string AddressLine1 { get; set; } 
        public string AddressLine2 { get; set; } 

    }
}
