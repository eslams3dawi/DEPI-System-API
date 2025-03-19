using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.DAL.Models
{
    public class Track
    {
        public int TrackId { get; set; }
        public string TrackName { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; }

        public int? FieldId { get; set; }
        public Field Field { get; set; }
    }
}
