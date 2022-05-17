using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IDropdownService
    {
        List<SelectListItem> ListofCities(int cityId);
        List<SelectListItem> ListofSuppliers(int supplierId);
    }
}
