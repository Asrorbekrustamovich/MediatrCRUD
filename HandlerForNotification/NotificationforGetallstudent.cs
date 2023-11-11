using MediatR;
using Mediatrbilan_ishlash_WebCore.ServiceforNotification;

namespace Mediatrbilan_ishlash_WebCore.HandlerForNotification
{
    public class NotificationforGetallstudent : INotificationHandler<StudentGetallNotification>
    {
        public async Task Handle(StudentGetallNotification notification, CancellationToken cancellationToken)
        {
            if(notification!=null)
            {
                await Console.Out.WriteLineAsync("success");
            }
            else
            {
                await Console.Out.WriteLineAsync("not anything found");
            }
        }
    }
}
