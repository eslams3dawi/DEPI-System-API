using DEPI.BLL.DTOs.StudentDTO;
using DEPI.DAL.Repository.GenericRepository;
using DEPI.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEPI.DAL.Repository.StudentRepo;

namespace DEPI.BLL.Services.StudentService
{
    public class StudentService : IStudentService
    {
        public readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Add(StudentAddDTO student)
        {
            var studentModel = new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                DateOfBirth = student.DateOfBirth,
                Email = student.Email,
                Phone = student.Phone
            };
            _studentRepository.Add(studentModel);
        }

        /*get the objects
        /*mapping
        /*return the objects*/
        public IEnumerable<StudentReadDTO> GetAll()
        {
            var studentModels = _studentRepository.GetAll();
            var studentDTOs = studentModels.Select(s => new StudentReadDTO
            {
                Id = s.Id,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Age = s.Age,
                Email = s.Email,
                Phone = s.Phone
            }).ToList();
            return studentDTOs;
        }

        public StudentReadDTO GetById(int id)
        {
            var studentModel = _studentRepository.GetById(id);

            var studentDTO = new StudentReadDTO
            {
                Id = studentModel.Id,
                FirstName = studentModel.FirstName,
                LastName = studentModel.LastName,
                Age = studentModel.Age,
                Email = studentModel.Email,
                Phone = studentModel.Phone
            };

            return studentDTO;
        }
        public void Update(int id, StudentUpdateDTO student)
        {
            var studentModel = _studentRepository.GetById(id);

            studentModel.FirstName = student.FirstName;
            studentModel.LastName = student.LastName;
            studentModel.Age = student.Age;
            studentModel.Email = student.Email;
            studentModel.Phone = student.Phone;

            _studentRepository.Update(studentModel);
        }
        public void Delete(int id)
        {
            var studentModel = _studentRepository.GetById(id);
            _studentRepository.Delete(studentModel);
        }
    }
}
