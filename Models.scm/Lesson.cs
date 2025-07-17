using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Models.scm
{
    public class Lesson
    {

        public int Id { get; set; }

        public int? LevelId { get; set; }

        public int? TypeId { get; set; }

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }


        public virtual Type? Type { get; set; }
    }
}
