using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL;
using Model;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CRUD.Controllers
{
    [Route("shampy/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            List<StudentModel> students = StudentDAL.ShowStudent();
            return Ok(students);
        }

        [HttpPost]
        public ActionResult Post(StudentModel student)
        {
            if (student == null) {
               return BadRequest("Can't save the data please fill the fields ");
            }
            
            StudentDAL.saveData(student);

            return Ok("Student Has been added in List");
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            bool result = StudentDAL.FindDelete(id);
            if (result)
            {
                return Ok("Student Deleted");
            }

            return BadRequest("No Such Student Found");


        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, StudentModel student)
        {
           bool result= StudentDAL.updateStudent(id, student);
            if (result)
            {
                return Ok("Student Deleted");
            }

            return BadRequest("No Such Student Found");

        }
    }
}
