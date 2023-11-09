using MediatR;

namespace Mediatrbilan_ishlash_WebCore.Services
{
    public class DeleteMediatrService:IRequest<bool>
    {
        public int Id { get; set; }
    }
}
