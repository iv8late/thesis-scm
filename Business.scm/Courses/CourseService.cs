using DTO.scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.scm.GenericResponse;
using Utility.scm.Interfaces;

namespace Business.scm.Courses
{
    public class CourseService (IGenericRepository<ThemeDTO> genericRepository): ICourseService
    {

        private readonly IGenericRepository<ThemeDTO> _genericRepository;
        public Task<ApiRsp<List<ThemeDTO>>> GetListThemes()
        {
            var rsp= ApiRsp<List<ThemeDTO>>.SuccessResponse();

        }
    }
}
