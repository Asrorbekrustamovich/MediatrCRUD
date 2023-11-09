using MediatR;
using Mediatrbilan_ishlash_WebCore.Services;
using Microsoft.EntityFrameworkCore;

namespace Mediatrbilan_ishlash_WebCore.Handlers
{
    public class UpdateHandler : IRequestHandler<UpdateMediatrService, bool>
    {
        private readonly MyDbcontext _dbcontext;

        public UpdateHandler(MyDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<bool> Handle(UpdateMediatrService request, CancellationToken cancellationToken)
        {
            _dbcontext.Update(request.StudentMediatr);
            await _dbcontext.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
