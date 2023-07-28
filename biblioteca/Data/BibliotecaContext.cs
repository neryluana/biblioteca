using Microsoft.EntityFrameworkCore;

namespace biblioteca.Data
{
    public class BibliotecaContext: DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) 
        { 
        
        }

    }
}
