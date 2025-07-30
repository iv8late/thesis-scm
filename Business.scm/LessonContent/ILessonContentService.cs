using DTO.scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.scm.GenericResponse;

namespace Business.scm.LessonContent
{
    public interface ILessonContentService
    {
        Task<ApiRsp<IEnumerable<LessonDTO>>> GetListLessonContent(int id);
    }
}
