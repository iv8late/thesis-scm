using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Utility.scm.Interfaces;

namespace Utility.scm.Repositories
{
    
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly Cache<T> _cache;

       
        public GenericRepository(Cache<T> cache)
        {
            _cache = cache;
        }

     
        public async Task<T> Add(T item)
        {
            
            return await Task.FromResult(_cache.Add(item));  
        }

       
        public async Task Remove(int id)
        {
          
            await Task.Run(() => _cache.Remove(id));  
        }

      

        public Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return  Task.FromResult(_cache.Queryable().Where(predicate).AsEnumerable());
        }
        public async Task<T> Get(int id)
        {
           
            var item = _cache.Find(id);
            return await Task.FromResult(item);  
        }

        
        public async Task<IEnumerable<T>> GetAll()
        {
           
            return await Task.FromResult(_cache.Queryable().ToList());
        }

    
        public async Task<T> Update(T item)
        {
           
            var itemExistente = _cache.Queryable().FirstOrDefault(x => GetId(x) == GetId(item));
            if (itemExistente != null)
            {
              
                _cache.Remove(GetId(item));
               
                return await Add(item);
            }
            return null; 
        }

      
        private int GetId(T item)
        {
            var property = item.GetType().GetProperty("Id");
            if (property != null)
            {
                return (int)property.GetValue(item);
            }
            else
            {
                throw new Exception("El item no tiene una propiedad 'Id'.");
            }
        }

       
    }
}
