using MediatR;
using Mediatrbilan_ishlash_WebCore.ServiceforNotification;

namespace Mediatrbilan_ishlash_WebCore.HandlerForNotification
{
    public class NotificationHandlerforDelete : INotificationHandler<StudentDeleteNotification>
    {
        public  async Task Handle(StudentDeleteNotification notification, CancellationToken cancellationToken)
        {
           if (notification!=  null) 
            {
                await Console.Out.WriteLineAsync("succesfully deleted");
            }
           else
            {
                await Console.Out.WriteLineAsync("not found");
            }
        }
    }
}
