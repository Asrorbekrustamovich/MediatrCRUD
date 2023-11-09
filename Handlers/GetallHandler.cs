using MediatR;
using Mediatrbilan_ishlash_WebCore.Services;
using System.Runtime.CompilerServices;

namespace Mediatrbilan_ishlash_WebCore.Handlers
{
    public class GetallHandler : IRequestHandler<GetallMediatrService, IEnumerable<StudentMediatr>>
    {
        private readonly MyDbcontext _dbcontext;

        public GetallHandler(MyDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public  async Task<IEnumerable<StudentMediatr>> Handle(GetallMediatrService request, CancellationToken cancellationToken)
        {
            var getall =  _dbcontext.Studentsmediatr;
            return getall;
        }
    }
}
