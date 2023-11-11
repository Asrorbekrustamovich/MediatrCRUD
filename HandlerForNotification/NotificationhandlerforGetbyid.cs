using MediatR;
using Mediatrbilan_ishlash_WebCore.ServiceforNotification;

namespace Mediatrbilan_ishlash_WebCore.HandlerForNotification
{
    public class NotificationhandlerforGetbyid : INotificationHandler<StudentGetbyidNotification>
    {
        public async Task Handle(StudentGetbyidNotification notification, CancellationToken cancellationToken)
        {
          if(notification!=null)
            {
                await Console.Out.WriteLineAsync("succesfully found");
            }
          else
           {
                await Console.Out.WriteLineAsync("not found");
            }
        }
    }
}
