using DEPI.BLL.DTOs.InstructorDTO;
using DEPI.DAL.Models;
using DEPI.DAL.Repository.InstructorRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI.BLL.Services.InstructorService
{
    public class InstructorService : IInstructorService
    {
        public readonly IInstructorRepository _instructorRepository;
        public InstructorService(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }
        public void Add(InstructorAddDTO instructor)
        {
            var instructorModel = new Instructor
            {
                FirstName = instructor.FirstName,
                LastName = instructor.LastName,
                DateOfBirth = instructor.DateOfBirth,
                Email = instructor.Email,
                Phone = instructor.Phone,
                Salary = instructor.Salary
            };
            _instructorRepository.Add(instructorModel);
        }
        public IEnumerable<InstructorReadDTO> GetAll()
        {
            var instructorModels = _instructorRepository.GetAll();
            var instructorDTOs = instructorModels.Select(i => new InstructorReadDTO
            {
                Id = i.Id,
                FirstName = i.FirstName,
                LastName = i.LastName,
                Age = i.Age,
                Email = i.Email,
                Phone = i.Phone,
                Salary = i.Salary
            }).ToList();

            return instructorDTOs;
        }
        public InstructorReadDTO GetById(int id)
        {
            var instructorModel = _instructorRepository.GetById(id);
            var instructorDTO = new InstructorReadDTO
            {
                Id = instructorModel.Id,
                FirstName = instructorModel.FirstName,
                LastName = instructorModel.LastName,
                Age = instructorModel.Age,
                Email = instructorModel.Email,
                Phone = instructorModel.Phone,
                Salary = instructorModel.Salary
            };
            return instructorDTO;
        }
        public void Update(int id, InstructorUpdateDTO instructor)
        {
            var instructorModel = _instructorRepository.GetById(id);
            instructorModel.FirstName = instructor.FirstName;
            instructorModel.LastName = instructor.LastName;
            instructorModel.Email = instructor.Email;
            instructorModel.Phone = instructor.Phone;
            _instructorRepository.Update(instructorModel);
        }
        public void Delete(int id)
        {
            var InstructorModel = _instructorRepository.GetById(id);
            _instructorRepository.Delete(InstructorModel);
        }
    }
}
