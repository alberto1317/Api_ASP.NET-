using Api_Peliculas.Data;
using Api_Peliculas.Modelos;
using Api_Peliculas.Repositorio.iRepositorio;

namespace Api_Peliculas.Repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly ApplicationDbContext _bd;

        public CategoriaRepositorio(ApplicationDbContext bd)
        { 
        _bd = bd;
        }

        public bool ActualizarCategoria(Categoria Categoria)
        {
            Categoria.FechaCreacion = DateTime.Now;
            _bd.Categorias.Update(Categoria);
            return Guardar();
        }

        public bool BorrarCategoria(Categoria categoria)
        {
            _bd.Categorias.Remove(categoria);
            return Guardar();
        }

        public bool CrearCategoria(Categoria Categoria)
        {
            Categoria.FechaCreacion = DateTime.Now;
            _bd.Categorias.Add(Categoria);
            return Guardar();
        }

        public bool ExisteCategoria(int id)
        {
           return _bd.Categorias.Any(c => c.Id == id);
        }

        public bool ExisteCategoria(string nombre)
        {
            Boolean valor = _bd.Categorias.Any(c => c.Nombre.ToLower().Trim() == nombre.ToLower().Trim());
            return valor;
        }

        public Categoria GetCategoria(int CategoriaId)
        {
            return _bd.Categorias.FirstOrDefault(c => c.Id == CategoriaId);
        }

        public ICollection<Categoria> GetCategorias()
        {
            return _bd.Categorias.OrderBy(c => c.Nombre).ToList();
        }

        public bool Guardar()
        {
            return _bd.SaveChanges() >=0 ? true : false;  
        }
    }
}
