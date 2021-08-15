using BlazorLib.Model;
using BlazorPractice.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorPractice.UI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService( HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task DeleteCategory(int id)
        {
            await _httpClient.DeleteAsync($"api/category/{id}");
        }

        public async Task<IEnumerable<Categories>> GetAllCategories()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Categories>>( // devuelve un numerable de categories
             await _httpClient.GetStreamAsync($"api/category"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true}); // devuelve la list de todos con el GetStreamAsync, se encarga de crear el request por nosotros
        }

        public async Task<Categories> GetCategory(int id)
        {
            return await JsonSerializer.DeserializeAsync<Categories>( // solo devuelve un tipo categories
           await _httpClient.GetStreamAsync($"api/category/{id}"), new JsonSerializerOptions() {PropertyNameCaseInsensitive = true });
        }

        public async Task SaveCategory(Categories category)
        {
            var categoryJson = new StringContent(JsonSerializer.Serialize(category), Encoding.UTF8, "application/json"); // deserializar el category para decidir entre update e insert
            if (category.Id == 0)
                await _httpClient.PostAsync("api/category", categoryJson);
            else
                await _httpClient.PutAsync("api/category", categoryJson);

        }
    }
}
