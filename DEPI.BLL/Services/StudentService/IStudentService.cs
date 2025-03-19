using DEPI.BLL.DTOs.StudentDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.BLL.Services.StudentService
{
    public interface IStudentService
    {
        public void Add(StudentAddDTO student);
        public IEnumerable<StudentReadDTO> GetAll();
        public StudentReadDTO GetById(int id);
        public void Update(int id, StudentUpdateDTO student);
        public void Delete(int id);
    }
}
