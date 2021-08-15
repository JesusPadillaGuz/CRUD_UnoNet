using BlazorLib.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLib.Data.Repositories
{
    public interface ICategoryRepository
    {

        Task< IEnumerable<Categories>> GetAllCategories();
        Task<Categories> GetCategory(int id);
        Task<bool> InsertCategory(Categories category);
        Task<bool> UpdateCategory(Categories category);
        Task<bool> DeleteCategory(int id);

    }
}
