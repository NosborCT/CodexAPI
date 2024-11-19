using Microsoft.EntityFrameworkCore;
using CodexAPI.Models;

namespace CodexAPI.Data
{
    public class AppDbContext : DbContext
    {
        /* para que o entityframework reconheça as classes que serão usadas no
         * banco de dados temos que criar um construtor que recebe um AppDbContextOptions como parâmetro */
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Mapeamento dos modelos para as tabelas
        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }
    }
}
