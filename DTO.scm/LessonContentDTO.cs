using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.scm
{
    public class LessonContentDTO
    {
        public int Id { get; set; }

        public int? TypeId { get; set; }

        public int? Order { get; set; }

        public int? LessonId { get; set; }

        public string? Content { get; set; }

        
    }
}
