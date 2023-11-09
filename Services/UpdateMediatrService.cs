using MediatR;

namespace Mediatrbilan_ishlash_WebCore.Services
{
    public class UpdateMediatrService:IRequest<bool>
    {
        public StudentMediatr StudentMediatr { get; set; }
    }
}
