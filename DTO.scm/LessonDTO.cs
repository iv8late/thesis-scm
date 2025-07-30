using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DTO.scm
{
    public class LessonDTO
    {

        public int Id { get; set; }
        public int? CourseID { get; set; }
        public int? Order { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? StageId { get; set; }
        public int? Status { get; set; }

        public List<LessonContentDTO> LessonContents = [];


    }
}
