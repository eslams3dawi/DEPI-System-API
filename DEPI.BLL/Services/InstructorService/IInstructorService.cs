using DEPI.BLL.DTOs.InstructorDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.BLL.Services.InstructorService
{
    public interface IInstructorService
    {
        public void Add(InstructorAddDTO instructor);
        public IEnumerable<InstructorReadDTO> GetAll();
        public InstructorReadDTO GetById(int id);
        public void Update(int id, InstructorUpdateDTO instructor);
        public void Delete(int id);
    }
}
