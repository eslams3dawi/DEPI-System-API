using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.DAL.Models
{
    public class Instructor : BaseEntity
    {
        public int Salary { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
