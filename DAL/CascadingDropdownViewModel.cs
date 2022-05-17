using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DAL
{
    public class CascadingDropdownViewModel
    {
        [Required(ErrorMessage = "Suppliers is Required")]
        public string SupplierId { get; set; }
        public List<SelectListItem> ListofSuppliers { get; set; }

        [Required(ErrorMessage = "Cities is Required")]
        public string CitieId { get; set; }
        
        

    }
}
