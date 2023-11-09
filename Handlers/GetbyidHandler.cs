using MediatR;
using Mediatrbilan_ishlash_WebCore.Services;
using Microsoft.EntityFrameworkCore;

namespace Mediatrbilan_ishlash_WebCore.Handlers
{
    public class GetbyidHandler : IRequestHandler<GetbyidMediatrService, StudentMediatr>
    { private readonly MyDbcontext _dbcontext;

        public GetbyidHandler(MyDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async  Task<StudentMediatr> Handle(GetbyidMediatrService request, CancellationToken cancellationToken)
        {
            return await _dbcontext.Studentsmediatr.FirstOrDefaultAsync(x => x.Id == request.id, cancellationToken);
        }
    }
}
