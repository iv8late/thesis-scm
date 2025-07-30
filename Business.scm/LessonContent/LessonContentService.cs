using DTO.scm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.scm.Exceptions;
using Utility.scm.GenericResponse;
using Utility.scm.Interfaces;

namespace Business.scm.LessonContent
{
    public class LessonContentService: ILessonContentService
    {


        private readonly IGenericRepository<LessonDTO> _genericRepository;

        public LessonContentService(IGenericRepository<LessonDTO> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<ApiRsp<IEnumerable<LessonDTO>>> GetListLessonContent(int lessonID)
        {
            var rsp = ApiRsp<IEnumerable<LessonDTO>>.SuccessResponse();

            try
            {
                rsp.Data = await _genericRepository.Find(l => l.Id == lessonID);

                return rsp;
            }
            catch (BusinessException)
            {

                return rsp;
            }

        }
    }
}
