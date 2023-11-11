using MediatR;
using Mediatrbilan_ishlash_WebCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace Mediatrbilan_ishlash_WebCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("Post")]
        public async Task<IActionResult> Create(StudentMediatr student)
        {
            var request = new CreateStudentMediatrService { StudentMediatr = student };
            var request1 = new StudentCreatedNotification { Studentmediator = student };
            var createdStudent = await _mediator.Send(request);

            return Ok(createdStudent);
        }
        [HttpGet("Getall")]
        public async Task<IActionResult> Getall()
        {
            var request = new GetallMediatrService();
            var Getallstudent = await _mediator.Send(request);
            return Ok(Getallstudent);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var request = new DeleteMediatrService { Id = id };
            var deleteid = await _mediator.Send(request);
            return Ok(deleteid);
        }
        [HttpGet("Getbyid")]
        public async Task<IActionResult> Getbyid(int id)
        {
            var request = new GetbyidMediatrService { id = id };
            var getbyid = await _mediator.Send(request);
            return Ok(getbyid);
        }
        [HttpPatch("Update")]
        public async Task<IActionResult> Update(StudentMediatr studentMediatr)
        {
            var request = new UpdateMediatrService { StudentMediatr = studentMediatr };
            var updatestudent = await _mediator.Send(request);
            return Ok(updatestudent);
        }
    }
}