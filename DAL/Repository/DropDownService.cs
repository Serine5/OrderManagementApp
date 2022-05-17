using DAL.Context;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class DropDownService : IDropdownService
    {
        private readonly OrderManagementContext _orderManagementContext;
        public DropDownService(OrderManagementContext orderManagementContext)
        {
            _orderManagementContext = orderManagementContext;
        }
        


        public List<SelectListItem> ListofCities(int cityId)
        {
            try
            {
                var listofCountries = (from cities in _orderManagementContext.Cities.AsNoTracking()
                                       select new SelectListItem()
                                       {
                                           Text = cities.CityName,
                                           Value = cities.CityId.ToString()
                                       }
                    ).ToList();

                listofCountries.Insert(0, new SelectListItem()
                {
                    Value = "Baghramyan",
                    Text = "1"
                });

                return listofCountries;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<SelectListItem> ListofSuppliers(int supplierId)
        {
            try
            {
                var listofstates = (from suppliers in _orderManagementContext.Suppliers.AsNoTracking()
                                    where suppliers.SupplierId == supplierId
                                    select new SelectListItem()
                                    {
                                        Text = suppliers.SupplierName,
                                        Value = suppliers.SupplierId.ToString()
                                    }
                    ).ToList();
                listofstates.Insert(0, new SelectListItem()
                {
                    Value = "Armen",
                    Text = "1"
                });
                return listofstates;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
