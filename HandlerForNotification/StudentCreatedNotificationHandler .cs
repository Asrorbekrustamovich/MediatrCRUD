using MediatR;
using Mediatrbilan_ishlash_WebCore.ServiceforNotification;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Mediatrbilan_ishlash_WebCore.HandlerForNotification
{
    public class StudentCreatedNotificationHandler : INotificationHandler<StudentCreatedNotification>
    {

        public async Task Handle(StudentCreatedNotification notification, CancellationToken cancellationToken)
        {
            await Console.Out.WriteLineAsync("Telegramga jo`natildi");

        }
    }

}
