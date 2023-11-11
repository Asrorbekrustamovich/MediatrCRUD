using MediatR;
using Mediatrbilan_ishlash_WebCore.ServiceforNotification;
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
            var request1 = new StudentCreatedNotification(student);
            await _mediator.Publish(request1);
            var createdStudent = await _mediator.Send(request);

            return Ok(request);
        }
        [HttpGet("Getall")]
        public async Task<IActionResult> Getall()
        {
            var request = new GetallMediatrService();
            var request1 = new StudentGetallNotification();
            await _mediator.Publish(request1);
            var Getallstudent = await _mediator.Send(request);
            return Ok(Getallstudent);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var request = new DeleteMediatrService { Id = id };
            var request1 = new StudentDeleteNotification(id);
            await _mediator.Publish(request1);
            var deleteid = await _mediator.Send(request);
            return Ok(deleteid);
        }
        [HttpGet("Getbyid")]
        public async Task<IActionResult> Getbyid(int id)
        {
            var request = new GetbyidMediatrService { id = id };
            var request1 = new StudentGetbyidNotification(id);
            var getbyid = await _mediator.Send(request);
            await _mediator.Publish(request1);
            return Ok(getbyid);
        }
        [HttpPatch("Update")]
        public async Task<IActionResult> Update(StudentMediatr studentMediatr)
        {
            var request = new UpdateMediatrService { StudentMediatr = studentMediatr };
            var updatestudent = await _mediator.Send(request);
            var request1=new  StudentUpdateNotification(studentMediatr);
           await _mediator.Publish(request1);
            return Ok(updatestudent);
        }
    }
}