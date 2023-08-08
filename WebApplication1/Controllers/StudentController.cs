using Demo.Data.Repository.Interface;
using Demo.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo repo;

        public StudentController(IStudentRepo repo)
        {
            this.repo = repo;
        }

        [HttpPost("/student")]
        public IActionResult Post(Student student)
        {
            repo.AddStudent(student);
            return Ok();
        }

        [HttpGet("/students")]
        public IActionResult Get()
        {
            return Ok(repo.GetAllStudents());
        }
    }
}
