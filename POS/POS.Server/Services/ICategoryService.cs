using POS.Shared.DTOs;

namespace POS.Server.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllAsync();

        Task<CategoryDto> GetByIdAsync(int id);

        Task<CategoryDto> CreateAsync(CreateCategory request);

        Task<CategoryDto> UpdateAsync(int id, EditCatgory request);
    }
}