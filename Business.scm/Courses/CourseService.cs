using DTO.scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.scm.Exceptions;
using Utility.scm.GenericResponse;
using Utility.scm.Interfaces;

namespace Business.scm.Courses
{
    public class CourseService: ICourseService
    {

        private readonly IGenericRepository<ThemeDTO> _genericRepository;
       

        public CourseService(IGenericRepository<ThemeDTO> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        

        public async Task<ApiRsp<IEnumerable<ThemeDTO>>> GetListThemes()
        {
            var rsp = ApiRsp<IEnumerable<ThemeDTO>>.SuccessResponse();

            try
            {
                rsp.Data = await _genericRepository.GetAll();
              
                return rsp;
            }
            catch (BusinessException )
            {

                return rsp;
            }
           

        }
    }
}
