using DTO.scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.scm.GenericResponse;

namespace Business.scm.Courses
{
    public interface ICourseService
    {

        Task<ApiRsp<IEnumerable<ThemeDTO>>> GetListThemes();
    }
}
