using Microsoft.AspNetCore.Mvc;
using ApplicationLayer.IServices;
using DAL.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderManagementApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplier;
        public SupplierController(ISupplierService supplier)
        {
            _supplier = supplier;
        }
        Suppliers[] suppliers = new Suppliers[]
        {
            new Suppliers{SupplierId =1, AddressLine1 = "Baghramyan", AddressLine2 = "Mashtoc", SupplierName ="Armen", CityId =1},
            new Suppliers{SupplierId =2, AddressLine1 = "Frik", AddressLine2 = "Mashtoc", SupplierName ="Arev", CityId =2}

        };
        // GET: api/<SupplierController>
        [HttpGet]
        public IEnumerable<Suppliers> Get()
        {
            return _supplier.GetSuppliers();
        }

        // GET api/<SupplierController>/5
        [HttpGet("{id}")]
        public Suppliers Get(int id)
        {
            var supplier = suppliers.FirstOrDefault(p => p.SupplierId == id);
            if (supplier == null)
                return null;
            return _supplier.GetSupplierID(id);
        }

        // POST api/<SupplierController>
        [HttpPost]
        public void Post([FromBody] Suppliers value)
        {
            _supplier.UpdateSupplier(value);
        }

        // PUT api/<SupplierController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Suppliers value)
        {
            var supplier = suppliers.FirstOrDefault(p => p.SupplierId == id);
            _supplier.AddSupplier(value );
        }

        // DELETE api/<SupplierController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _supplier.DeleteSupplier(id);
        }
    }
}
