using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Repository.Interface
{
    public interface IStudentRepo
    {
        void AddStudent(Student student);
        List<Student> GetAllStudents();
    }
}
