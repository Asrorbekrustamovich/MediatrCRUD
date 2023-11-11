using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Mediatrbilan_ishlash_WebCore.ServiceforNotification;
using Microsoft.Extensions.Configuration;
using Telegram.Bot;
using Telegram.Bot.Types;
namespace Mediatrbilan_ishlash_WebCore.HandlerForTelegram
{
    public class GetbyidNotificationforTelegram : INotificationHandler<StudentGetbyidNotification>
    {
        private readonly ITelegramBotClient _botClient;
        private readonly IConfiguration _configuration;

        public GetbyidNotificationforTelegram(ITelegramBotClient botClient, IConfiguration configuration)
        {
            _botClient = botClient;
            _configuration = configuration;
        }

        public async Task Handle(StudentGetbyidNotification notification, CancellationToken cancellationToken)
        {
            string imagePath = "C:\\Users\\User\\Desktop\\img.jpg";
            using (FileStream fs = System.IO.File.OpenRead(imagePath))
            {
                InputFileStream inputFileStream = new InputFileStream(fs);
                await _botClient.SendPhotoAsync(chatId: 781025549, photo: inputFileStream, cancellationToken: cancellationToken);
               
            }
           
        }
    }
}
