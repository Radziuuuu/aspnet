using Microsoft.AspNetCore.Mvc;
using aspnet.Controllers.Form;
using aspnet.Database;
using aspnet.Database.Models;

namespace aspnet.Controllers;

    [Route("api/[controller]")]
    [ApiController]

public class GradeController : ControllerBase
{
    [HttpPost("create")]
    public ActionResult<Grades> CreateGrade([FromBody] Grade_Create grade)
    {
        using (var context = new Context())
        {
            var newGrade = new Grades
            {
                Title = grade.Title,
                Grade = grade.Grade,
                StudentId = grade.StudentId
            };
            context.Grade.Add(newGrade);
            context.SaveChanges();
            return CreatedAtAction(nameof(CreateGrade), newGrade);
        }
    }
}