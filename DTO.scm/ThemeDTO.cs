using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.scm
{

    public class ThemeDTO
    {
        public int Id { get; set; }

        public int? StageId { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<CourseDTO> Courses { get; set; } = [];


        


    }
}
