using MediatR;

namespace Mediatrbilan_ishlash_WebCore.Services
{
    public class CreateStudentMediatrService : IRequest<StudentMediatr>
    {
        public StudentMediatr StudentMediatr { get; set; }
    }
}
