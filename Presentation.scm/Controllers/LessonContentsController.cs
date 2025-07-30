using Business.scm.Courses;
using Business.scm.LessonContent;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.scm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonContentsController :Controller
    {


        private readonly ILessonContentService _lessonService;

        public LessonContentsController(ILessonContentService lessonService)
        {
            _lessonService = lessonService ?? throw new ArgumentNullException(nameof(lessonService));
        }


        [HttpGet("GetLessonContent")]
        public async Task<IActionResult> GetlessonContent(int lessonID)
        {

            try
            {
                var response = await _lessonService.GetListLessonContent(lessonID);
                return Ok(response);

            }
            catch (Exception)
            {

                return BadRequest();
            }



        }

    }
}
