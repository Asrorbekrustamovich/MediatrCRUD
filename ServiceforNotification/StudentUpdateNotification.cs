using MediatR;

namespace Mediatrbilan_ishlash_WebCore.ServiceforNotification
{
    public class StudentUpdateNotification:INotification
    {
        public StudentUpdateNotification(StudentMediatr studentMediatr)
        {
            StudentMediatr = studentMediatr;
        }

        public StudentMediatr StudentMediatr { get; set; }
    }
}
