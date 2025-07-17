using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.scm
{
    public class LessonContent
    {
        public int Id { get; set; }

        public int? LessonId { get; set; }

        public string? Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        public virtual Lesson? Lesson { get; set; }
    }
}
