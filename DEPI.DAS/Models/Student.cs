using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.DAL.Models
{
    public class Student : BaseEntity
    {
        public int PerformanceRate { get; set; }

        public int? TrackId {  get; set; }
        public Track Track { get; set; }

        public string? GroupId { get; set; }
        public Group Group { get; set; }
    }
           
}
