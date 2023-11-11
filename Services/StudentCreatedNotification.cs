using MediatR;

namespace Mediatrbilan_ishlash_WebCore.Services
{
    public class StudentCreatedNotification : INotification
    {
        public StudentMediatr Studentmediator { get; set; }
    }

}
