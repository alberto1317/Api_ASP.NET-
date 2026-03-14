using System.ComponentModel.DataAnnotations;

namespace Api_Peliculas.Modelos
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
