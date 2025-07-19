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

        public int? LevelId { get; set; }

        public int? TypeId { get; set; }

        public string? Description { get; set; }

    }
}
