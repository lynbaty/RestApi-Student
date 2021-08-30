using Command.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Command.Data
{
    public class SqlStudentRepo : IStudentRepo
    {
        private readonly StudentContext _context;

        public SqlStudentRepo(StudentContext context)
        {
            _context = context;
        }

        public void CreateStudent(Student newStudent)
        {
            if (newStudent == null)
            {
                throw new ArgumentNullException(nameof(newStudent));
            }
            _context.Students.Add(newStudent);
            
        }

        public void DeleteStudent(Student Stu)
        {
            if (Stu == null)
            {
                throw new ArgumentNullException(nameof(Stu));
            }
            _context.Students.Remove(Stu);

        }

        public IEnumerable<Student> GetAllStudent()
        {
            var stus = _context.Students.ToList();
            return stus;
        }

        public Student GetStudentbyId(int id)
        {
            var stu = _context.Students.Where(s => s.Id == id).FirstOrDefault();
            return stu;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void UpdateStudent(Student UpdateStudent)
        {
            //do nothing
        }
    }
}
