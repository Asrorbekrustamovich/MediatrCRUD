using MediatR;
using Mediatrbilan_ishlash_WebCore.Services;

namespace Mediatrbilan_ishlash_WebCore.Handlers
{
    public class CreateHandler : IRequestHandler<CreateStudentMediatrService, StudentMediatr>
    {
        private readonly MyDbcontext _dbContext;

        public CreateHandler(MyDbcontext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<StudentMediatr> Handle(CreateStudentMediatrService request, CancellationToken cancellationToken)
        {
           _dbContext.Add(request.StudentMediatr);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return request.StudentMediatr;
        }
    }
}
