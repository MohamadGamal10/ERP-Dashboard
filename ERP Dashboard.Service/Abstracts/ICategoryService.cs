using ERP_Dashboard.Data.Entities;

namespace ERP_Dashboard.Service.Abstracts
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategoriesAsync();
        Task<Category> GetByIdAsync(int id);
        Task<string> AddAsync(Category category);
        Task<string> EditAsync(Category category);
        Task<string> DeleteAsync(Category category);
    }
}
