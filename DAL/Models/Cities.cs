using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Cities
    {
        public long CityId { get; set; }
        public string CityName { get; set; }    
        public string PostalCode { get; set; }
        public string State { get; set; }
        public ICollection<Suppliers> Supplier{ get; set; }
    }
}
