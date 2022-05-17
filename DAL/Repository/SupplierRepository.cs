using DAL.Context;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    public class SupplierRepository : ISupplierRepository,IDisposable
    {
        private readonly OrderManagementContext _orderManagementContext;
        public SupplierRepository(OrderManagementContext orderManagementContext)
        {
            _orderManagementContext = orderManagementContext;
        }
        public void DeleteSupplier(int supplierId)
        {
            Suppliers suplier = _orderManagementContext.Suppliers.Find(supplierId);
            _orderManagementContext.Suppliers.Remove(suplier);
            _orderManagementContext.SaveChanges();
        }

        public Suppliers GetSupplierID(int supplierId)
        {
            return _orderManagementContext.Suppliers.FirstOrDefault(p => p.SupplierId==supplierId);
        }

        public IEnumerable<Suppliers> GetSuppliers()
        {
            return _orderManagementContext.Suppliers.ToList();
        }

        public void InsertSupplier(Suppliers supllier)
        {
             _orderManagementContext.Suppliers.Add(supllier);

        }

        public void Save()
        {
            _orderManagementContext.SaveChanges();
        }

        public void UpdateSupplier(Suppliers supplier)
        {
            _orderManagementContext.Entry(supplier).State = EntityState.Modified;
            _orderManagementContext.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _orderManagementContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
