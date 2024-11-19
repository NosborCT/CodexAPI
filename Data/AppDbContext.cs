using Microsoft.EntityFrameworkCore;

namespace CodexAPI.Data
{
    public class AppDbContext : DbContext

    {
        /* para que o entityframework reconheça as classes que serão usadas no
         * banco de dados temos que criar um construtor que recebe um AppDbContextOptions como parâmetro */ 
        public AppDbContext(AppDbContextOptions <AppDbContext> options) : base(options)
        {
            
        }
        // mapeando os modelos para as tabelas
        public Dbset <AutorModel> Autores { get; set; }
        public Dbset <LiuvroModel> Livros { get; set; }

    }
}
