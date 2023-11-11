using MediatR;

namespace Mediatrbilan_ishlash_WebCore.ServiceforNotification
{
    public class StudentCreatedNotification : INotification
    {
        public StudentCreatedNotification(StudentMediatr studentmediator)
        {
            Studentmediator = studentmediator;
        }

        public StudentMediatr Studentmediator { get; set; }
    }

}
