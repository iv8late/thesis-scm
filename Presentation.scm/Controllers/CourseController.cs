using Business.scm.Courses;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Presentation.scm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService ?? throw new ArgumentNullException(nameof(courseService));
        }

        [HttpGet("GetThemes")]
        public async Task<IActionResult> GetThemes()
        {

            try
            {
                var response = await _courseService.GetListThemes();
                return Ok(response);
              
            }
            catch (Exception)
            {

                return BadRequest();
            }
                
           
            
        }

        
      
    }
}
