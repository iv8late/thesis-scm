using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Models.scm
{
    public class Course
    {
        public int Id { get; set; }

        public int? StageId { get; set; }

        public int? ThemeId { get; set; }

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }
      
        public virtual Theme? Theme { get; set; }
    }
}
