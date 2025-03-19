using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.DAL.Models
{
    public class Group
    {
        public string Id { get; set; }
        public string CroupName { get; set; }

        public ICollection<Student> Students { get; set; }
        public Instructor Instructor { get; set; }
    }
}
