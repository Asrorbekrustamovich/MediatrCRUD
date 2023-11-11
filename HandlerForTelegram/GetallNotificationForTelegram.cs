using MediatR;
using Mediatrbilan_ishlash_WebCore.ServiceforNotification;
using Telegram.Bot;

namespace Mediatrbilan_ishlash_WebCore.HandlerForTelegram
{
    public class GetallNotificationForTelegram : INotificationHandler<StudentGetallNotification>
    {
        private readonly ITelegramBotClient _telegramBotClient;

        public GetallNotificationForTelegram(ITelegramBotClient telegramBotClient)
        {
            _telegramBotClient = telegramBotClient;
        }

        public async Task Handle(StudentGetallNotification notification, CancellationToken cancellationToken)
        {
            _telegramBotClient.SendTextMessageAsync(chatId: 781025549, text: "Olindi");
        }
    }
}
