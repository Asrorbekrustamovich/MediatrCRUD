using Microsoft.EntityFrameworkCore;

namespace Mediatrbilan_ishlash_WebCore
{
    public class MyDbcontext:DbContext
    {
        public MyDbcontext()
        {
            
        }
        public MyDbcontext(DbContextOptions<MyDbcontext>options):base(options) 
        {
            
        }
         public DbSet<StudentMediatr>Studentsmediatr{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
