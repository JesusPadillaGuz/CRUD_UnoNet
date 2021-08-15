using BlazorLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPractice.UI.Interfaces
{
   public interface ICategoryService
    {
        Task<IEnumerable<Categories>> GetAllCategories();
        Task<Categories> GetCategory(int id);
        Task SaveCategory(Categories category);
        
        Task DeleteCategory(int id);

    }
}
