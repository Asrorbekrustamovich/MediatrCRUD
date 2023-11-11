using MediatR;
using Mediatrbilan_ishlash_WebCore.Services;
using Telegram.Bot;

namespace Mediatrbilan_ishlash_WebCore.Handlers
{
    public class StudentCreatedNotificationHandler : INotificationHandler<StudentCreatedNotification>
    {
       

        public async Task Handle(StudentCreatedNotification notification, CancellationToken cancellationToken)
        {
            string message = $"New student created!\nName: {notification.Studentmediator.Name}, ID: {notification.Studentmediator.Id}";
            await Console.Out.WriteLineAsync("Telegramga jo`natildi");
        }
    }

}
