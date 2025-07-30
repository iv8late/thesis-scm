using DTO.scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.scm.LessonRepository
{
    public interface ILessonRepository
    {
        Task<LessonDTO> GetItemsbyId(int id);

    }
}
