using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface ISupplierRepository: IDisposable
    {
        IEnumerable<Suppliers> GetSuppliers();
        Suppliers GetSupplierID(int supplierId);
        void InsertSupplier(Suppliers supllier);
        void DeleteSupplier(int supplierId);
        void UpdateSupplier(Suppliers supplier);
        void Save();
    }
}
