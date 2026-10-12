using ERP_Dashboard.Data.Entities;
using ERP_Dashboard.Infrastructure.Abstracts;
using ERP_Dashboard.Service.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace ERP_Dashboard.Service.Implementations
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task<List<Supplier>> GetSuppliersAsync()
        {
            return await _supplierRepository.GetTableNoTracking().ToListAsync();
        }

        public async Task<Supplier> GetByIdAsync(int id)
        {
            return await _supplierRepository.GetByIdAsync(id);
        }

        public async Task<string> AddAsync(Supplier supplier)
        {
            var added = await _supplierRepository.AddAsync(supplier);
            return added != null ? "Supplier created successfully" : "Failed to create supplier";
        }

        public async Task<string> EditAsync(Supplier supplier)
        {
            await _supplierRepository.UpdateAsync(supplier);
            return "Supplier updated successfully";
        }

        public async Task<string> DeleteAsync(Supplier supplier)
        {
            await _supplierRepository.DeleteAsync(supplier);
            return "Supplier deleted successfully";
        }
    }
}
