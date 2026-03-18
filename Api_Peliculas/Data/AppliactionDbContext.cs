using Microsoft.EntityFrameworkCore;
using Api_Peliculas.Modelos;

namespace Api_Peliculas.Data
{
    public class ApplicationDbContext :DbContext
        
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            //: base(options)
        { 
        }
        //Aquí pasan todas las entidades (MOdelos)
        public DbSet<Categoria> Categorias { get; set; }
    }

}
