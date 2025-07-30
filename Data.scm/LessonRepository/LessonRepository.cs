using DTO.scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.scm.Repositories;

namespace Data.scm.LessonRepository
{
    public class LessonRepository : ILessonRepository
    {

        private readonly Cache<LessonDTO> _cache;


        public LessonRepository(Cache<LessonDTO> cache)
        {
            _cache = cache;
        }

        public async Task<LessonDTO> GetItemsbyId( int id)
        {

            var item = _cache.Queryable().FirstOrDefault(x => x.Id == id) ;
            return item;
            
        }


    }
}
