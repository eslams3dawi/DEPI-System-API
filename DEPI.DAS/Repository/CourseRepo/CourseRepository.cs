using DEPI.DAL.Database;
using DEPI.DAL.Models;
using DEPI.DAL.Repository.CourseRepository.CourseRepository;
using DEPI.DAL.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.DAL.Repository.CourseRepo;

public class CourseRepository : GenericRepository<Course>, ICourseRepository
{
    public CourseRepository(DEPIContext context) : base(context)
    {

    }
}
