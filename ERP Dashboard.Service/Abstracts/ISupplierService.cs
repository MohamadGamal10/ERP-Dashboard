using ERP_Dashboard.Data.Entities;

namespace ERP_Dashboard.Service.Abstracts
{
    public interface ISupplierService
    {
        Task<List<Supplier>> GetSuppliersAsync();
        Task<Supplier> GetByIdAsync(int id);
        Task<string> AddAsync(Supplier supplier);
        Task<string> EditAsync(Supplier supplier);
        Task<string> DeleteAsync(Supplier supplier);
    }
}
