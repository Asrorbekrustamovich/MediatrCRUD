using MediatR;

namespace Mediatrbilan_ishlash_WebCore.ServiceforNotification
{
    public class StudentGetbyidNotification:INotification
    {
        public int id;

        public StudentGetbyidNotification(int id)
        {
            this.id = id;
        }
    }
}
