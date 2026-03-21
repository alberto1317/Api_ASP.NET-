using System.ComponentModel.DataAnnotations;

namespace Api_Peliculas.Modelos.Dtos
{
    public class CategoriaDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [MaxLength(100, ErrorMessage ="El numero de caracteres es de 100")]
        public String Nombre { get; set; }
       
        public DateTime FechaCreacion { get; set; }
    }
}
