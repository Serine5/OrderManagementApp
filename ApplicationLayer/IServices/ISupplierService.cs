using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.IServices
{
    public interface ISupplierService
    {
        IEnumerable<Suppliers> GetSuppliers();
        Suppliers GetSupplierID(int supplierId);
        void AddSupplier(Suppliers supllier);
        void DeleteSupplier(int supplierId);
        void UpdateSupplier(Suppliers supplier);
        void Save();
    }
}
