using DEPI.DAL.Models;
using DEPI.DAL.Repository.GenericRepository;
using DEPI.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.DAL.Repository.StudentRepo
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(DEPIContext context) : base(context)
        {

        }
    }
}
