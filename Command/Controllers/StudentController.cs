using AutoMapper;
using Command.Data;
using Command.Dtos.StudentDtos;
using Command.Models;
using Command.Utilities.Exceptions;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Command.Controllers
{
    
    [Route("/api/student")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepo _studentrepo;
        private readonly IMapper _mapper;

        public StudentController(IStudentRepo studentrepo,IMapper mapper)
        {
            _studentrepo = studentrepo;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<StudentReadDto>> GetAllStudent()
        {
            var stus =_studentrepo.GetAllStudent();
            return Ok(_mapper.Map<IEnumerable<StudentReadDto>>(stus));
        }

       
        [HttpGet("{id}",Name="GetStudentbyId")]
        public ActionResult<StudentReadDto> GetStudentbyId(int id)
        {
            var stu = _studentrepo.GetStudentbyId(id);
            if(stu != null)
            {
                return Ok(_mapper.Map<StudentReadDto>(stu));
            }
            return NotFound();

        }
        [HttpPost]
        public ActionResult<StudentReadDto> CreateStudent(StudentCreateDto stucreate)
        {
            var stu = _mapper.Map<Student>(stucreate);
            _studentrepo.CreateStudent(stu);
            _studentrepo.SaveChanges();
            var sturead = _mapper.Map<StudentReadDto>(stu);
          
            return CreatedAtRoute(nameof(GetStudentbyId), new { id = sturead.Id }, sturead);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateStudent(int id,StudentUpdateDto stuud)
        {
            var stu = _studentrepo.GetStudentbyId(id);
            if (stu == null)
            {
                return NotFound();
            }
            _mapper.Map(stuud, stu);
            _studentrepo.UpdateStudent(stu);
            _studentrepo.SaveChanges();
            return NoContent();
        }
        [HttpPatch("{id}")]
        public ActionResult PatchUpdateStudent(int id,JsonPatchDocument<StudentUpdateDto> patchDoc)
        {
            var stufromrepo = _studentrepo.GetStudentbyId(id);
            if (stufromrepo == null)
            {
                return NotFound();
            }
            var stuud = _mapper.Map<StudentUpdateDto>(stufromrepo);
            patchDoc.ApplyTo(stuud,ModelState);
            if (!TryValidateModel(stuud))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(stuud, stufromrepo);
            _studentrepo.UpdateStudent(stufromrepo);
            _studentrepo.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            var stu = _studentrepo.GetStudentbyId(id);
            if (stu == null)
            {
                return NotFound();
            }
            _studentrepo.DeleteStudent(stu);
            _studentrepo.SaveChanges();
            return Ok();
        }

    }
}
