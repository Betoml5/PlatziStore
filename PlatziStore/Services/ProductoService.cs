using PlatziStore.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PlatziStore.Services
{
    internal class ProductoService : BaseService<Producto>
    {

        public ProductoService()
        {
           _httpClient = new();
        }
        public override Task<Producto> Create(Producto model)
        {
            throw new NotImplementedException();

        }

        public override Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task<IEnumerable<Producto>?> GetAll()
        {
           var response = await _httpClient.GetAsync($"{_url}/products");
           var content = await response.Content.ReadAsStringAsync();
           var productos = JsonSerializer.Deserialize<IEnumerable<Producto>>(content);
           return productos;
            
        }

        public override Task<Producto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<Producto> Update(int id, Producto model)
        {
            throw new NotImplementedException();
        }
    }
}
