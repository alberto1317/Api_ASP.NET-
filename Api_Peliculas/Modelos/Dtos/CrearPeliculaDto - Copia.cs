namespace Api_Peliculas.Modelos.Dtos
{
    public class CreaerPeliculaDto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Duracion { get; set; }
        public int RutaImagen { get; set; }

        public enum TipoClasificacion { Siete, Trece, Dieciseis, Dieciocho }
        public TipoClasificacion Clasificacion { get; set; }
        
        //Relacion con categoria
        public int categoriaId { get; set; }

    }
}
