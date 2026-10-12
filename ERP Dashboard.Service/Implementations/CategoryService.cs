using ERP_Dashboard.Data.Entities;
using ERP_Dashboard.Infrastructure.Abstracts;
using ERP_Dashboard.Service.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace ERP_Dashboard.Service.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _categoryRepository.GetTableNoTracking().ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _categoryRepository.GetByIdAsync(id);
        }

        public async Task<string> AddAsync(Category category)
        {
            var added = await _categoryRepository.AddAsync(category);
            return added != null ? "Category created successfully" : "Failed to create category";
        }

        public async Task<string> EditAsync(Category category)
        {
            await _categoryRepository.UpdateAsync(category);
            return "Category updated successfully";
        }

        public async Task<string> DeleteAsync(Category category)
        {
            await _categoryRepository.DeleteAsync(category);
            return "Category deleted successfully";
        }
    }
}
