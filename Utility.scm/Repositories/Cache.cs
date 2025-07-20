using System;
using System.Collections.Generic;
using System.Linq;

namespace Utility.scm.Repositories
{
    public class Cache<T> where T : class
    {
        private readonly List<T> _items = new List<T>();

        
        public T Add(T item)
        {
            try
            {
                _items.Add(item);
                return item;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        
        public T Find(int id)
        {
            try
            {
                
                var item = _items.FirstOrDefault(e => GetId(e) == id);
                return item;
            }
            catch (Exception )
            {
                throw;
            }
        }

      
        public IQueryable<T> Queryable()
        {
            try
            {
                return _items.AsQueryable();
            }
            catch (Exception )
            {
                throw;
            }
        }

       
        public bool Remove(int id)
        {
            try
            {
                var item = Find(id); 
                if (item != null)
                {
                    _items.Remove(item); 
                    return true;
                }
                return false; 
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el item de la caché.", ex);
            }
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

        public void SetData(IEnumerable<T> items)
        {
            if (items == null) return;

            _items.Clear();
            _items.AddRange(items);
        }

    }


}
