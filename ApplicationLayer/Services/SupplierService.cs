using ApplicationLayer.IServices;
using DAL.Models;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    public class SupplierService: ISupplierService
    {
        private readonly ISupplierRepository _repository;
        public SupplierService(ISupplierRepository repository)
        {
            _repository = repository;
        }

        public void DeleteSupplier(int supplierId)
        {
            _repository.DeleteSupplier(supplierId);
        }

        public Suppliers GetSupplierID(int supplierId)
        {
            return _repository.GetSupplierID(supplierId);
        }

        public IEnumerable<Suppliers> GetSuppliers()
        {
            return _repository.GetSuppliers();
        }

        public void AddSupplier(Suppliers supllier)
        {
             _repository.InsertSupplier(supllier);
        }

        public void Save()
        {
            _repository.Save();
        }

        public void UpdateSupplier(Suppliers supplier)
        {
            _repository.UpdateSupplier(supplier);
        }
    }
}
