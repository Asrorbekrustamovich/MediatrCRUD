using MediatR;

namespace Mediatrbilan_ishlash_WebCore.ServiceforNotification
{
    public class StudentDeleteNotification:INotification
    {
        public int id;

        public StudentDeleteNotification(int id)
        {
            this.id = id;
        }
    }
}
