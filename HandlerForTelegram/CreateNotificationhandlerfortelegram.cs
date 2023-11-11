using MediatR;
using Mediatrbilan_ishlash_WebCore.ServiceforNotification;
using Telegram.Bot;

namespace Mediatrbilan_ishlash_WebCore.HandlerForTelegram
{
    public class CreateNotificationhandlerfortelegram : INotificationHandler<StudentCreatedNotification>
    {
        private readonly ITelegramBotClient _telegramBotClient;

        public CreateNotificationhandlerfortelegram(ITelegramBotClient telegramBotClient)
        {
            _telegramBotClient = telegramBotClient;
        }

        public async Task Handle(StudentCreatedNotification notification, CancellationToken cancellationToken)
        {
            _telegramBotClient.SendTextMessageAsync(chatId: 781025549, text: "Yaratildi");
        }
    }
}
