using MediatR;
using Mediatrbilan_ishlash_WebCore.ServiceforNotification;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Mediatrbilan_ishlash_WebCore.HandlerForTelegram
{
    public class UpdateNotificationHandlerFortelegram : INotificationHandler<StudentUpdateNotification>
    {
        private readonly ITelegramBotClient _botclient;

        public UpdateNotificationHandlerFortelegram(ITelegramBotClient botclient)
        {
            _botclient = botclient;
        }

        public async Task Handle(StudentUpdateNotification notification, CancellationToken cancellationToken)
        {
            string imagePath = "C:\\Users\\User\\Desktop\\update.png";
            using (FileStream fs = System.IO.File.OpenRead(imagePath))
            {
                InputFileStream inputFileStream = new InputFileStream(fs);
                await _botclient.SendPhotoAsync(chatId: 781025549, photo: inputFileStream, cancellationToken: cancellationToken);

            }
        }
    }
}
