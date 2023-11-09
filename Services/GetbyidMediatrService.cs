using MediatR;

namespace Mediatrbilan_ishlash_WebCore.Services
{
    public class GetbyidMediatrService:IRequest<StudentMediatr>
    {
        public int id { get; set; }
    }
}
