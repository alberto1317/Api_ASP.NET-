using Api_Peliculas.Modelos;

namespace Api_Peliculas.Repositorio.iRepositorio
{
    public interface ICategoriaRepositorio
    {
        ICollection<Categoria> GetCategorias();
        Categoria GetCategoria(int CategoriaId);
        bool ExisteCategoria(int id);
        bool ExisteCategoria(string nombre);

        bool CrearCategoria(Categoria Categoria);
        bool ActualizarCategoria(Categoria Categoria);
        bool BorrarCategoria(Categoria categoria);
        bool Guardar();



    }
}
