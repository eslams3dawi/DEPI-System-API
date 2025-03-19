using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.DAL.Models
{
    public class Field
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}
