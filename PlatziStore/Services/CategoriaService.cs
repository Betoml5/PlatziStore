using PlatziStore.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PlatziStore.Services
{
    internal class CategoriaService : BaseService<Categoria>
    {
        public CategoriaService()
        {
            _httpClient = new();
        }
        public override Task<Categoria> Create(Categoria model)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task<IEnumerable<Categoria>?> GetAll()
        {
            var response = await _httpClient.GetAsync($"{_url}/categories");
            var content = await response.Content.ReadAsStringAsync();
            var categorias = JsonSerializer.Deserialize<IEnumerable<Categoria>>(content);
            return categorias;
        }

        public override Task<Categoria> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<Categoria> Update(int id, Categoria model)
        {
            throw new NotImplementedException();
        }
    }       
    
}
