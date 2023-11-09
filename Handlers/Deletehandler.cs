using MediatR;
using Mediatrbilan_ishlash_WebCore.Services;
using Microsoft.EntityFrameworkCore;

namespace Mediatrbilan_ishlash_WebCore.Handlers
{
    public class Deletehandler : IRequestHandler<DeleteMediatrService, bool>
    {
        private readonly MyDbcontext _dbcontext;

        public Deletehandler(MyDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<bool> Handle(DeleteMediatrService request, CancellationToken cancellationToken)
        {
            var student = await _dbcontext.Studentsmediatr.FindAsync(request.Id);
            if (student != null)
            {
                _dbcontext.Studentsmediatr.Remove(student);
                await _dbcontext.SaveChangesAsync(cancellationToken);
                return true;
            }
            return false;
        }
    }
}
