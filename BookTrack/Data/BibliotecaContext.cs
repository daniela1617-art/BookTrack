using BookTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace BookTrack.Data
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
            : base(options)
        {
        }

        public DbSet<Libro> Libros { get; set; }
    }
}
