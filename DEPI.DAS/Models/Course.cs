using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.DAL.Models
{
    public class Course
    {
        public string Id { get; set; }
        public string CourseName { get; set; }
        public ICollection<Instructor> Instructors { get; set; }

        public ICollection<Track> Tracks { get; set; }
    }
}
