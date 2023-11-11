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
            var client = await _dbcontext.Studentsmediatr.FindAsync(request.StudentMediatr.Id);

            if (client == null)
            {

            }

            client.Name=request.StudentMediatr.Name;
            client.Description=request.StudentMediatr.Description;
            client.Id=request.StudentMediatr.Id;
            _dbcontext.SaveChanges();
            return true;
           
        }
    }
}
