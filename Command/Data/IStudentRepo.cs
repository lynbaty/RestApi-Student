using Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command.Data
{
    public interface IStudentRepo 
    {
        IEnumerable<Student> GetAllStudent();

        Student GetStudentbyId(int id);


        void CreateStudent(Student newStudent);

        bool SaveChanges();
        void UpdateStudent(Student updateStudent);

        void DeleteStudent(Student stu);



    }
}
