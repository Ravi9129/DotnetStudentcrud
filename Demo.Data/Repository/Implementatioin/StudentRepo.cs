using Demo.Data.DataAccess;
using Demo.Data.Repository.Interface;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Repository.Implementatioin
{
    public class StudentRepo : IStudentRepo
    {
        private readonly ApplicationDbContext dbContext;

        public StudentRepo(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddStudent(Student student)
        {
            dbContext.Students.Add(student);    
            dbContext.SaveChanges();    
        }

        public List<Student> GetAllStudents()
        {
            return dbContext.Students.ToList();
        }
    }
}
