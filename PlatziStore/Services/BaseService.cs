using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatziStore.Services
{
    public abstract class BaseService<T> where T : class 
    {

        protected  HttpClient _httpClient;
        protected  string _url;

        public BaseService()
        {
            _url = "https://api.escuelajs.co/api/v1";
        }
            

        abstract public Task<IEnumerable<T>> GetAll();
        abstract public Task<T> GetById(int id);
        abstract public Task<T> Create(T model);
        abstract public Task<T> Update(int id, T model);
        abstract public Task<bool> Delete(int id);
      




    }
}
