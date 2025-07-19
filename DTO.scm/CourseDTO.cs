using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DTO.scm
{
    public class CourseDTO
    {
        public int Id { get; set; }

        public int? StageId { get; set; }

        public int? ThemeId { get; set; }

        public string? Description { get; set; }



    }
}
