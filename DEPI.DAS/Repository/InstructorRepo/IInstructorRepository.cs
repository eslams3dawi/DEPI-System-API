using DEPI.DAL.Models;
using DEPI.DAL.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.DAL.Repository.InstructorRepo
{
    public interface IInstructorRepository : IGenericRepository<Instructor>
    {
    }
}
