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
            _bd.Categoria.Update(Categoria);
            return Guardar();
        }

        public bool BorrarCategoria(Categoria categoria)
        {
            _bd.Categoria.Remove(categoria);
            return Guardar();
        }

        public bool CrearCategoria(Categoria Categoria)
        {
            Categoria.FechaCreacion = DateTime.Now;
            _bd.Categoria.Add(Categoria);
            return Guardar();
        }

        public bool ExisteCategoria(int id)
        {
           return _bd.Categoria.Any(c => c.Id == id);
        }

        public bool ExisteCategoria(string nombre)
        {
            Boolean valor = _bd.Categoria.Any(c => c.Nombre.ToLower().Trim() == nombre.ToLower().Trim());
            return valor;
        }

        public Categoria GetCategoria(int CategoriaId)
        {
           return _bd.Categoria.FirstOrDefault(c => c.Id == CategoriaId)
        }

        public ICollection<Categoria> GetCategorias()
        {
            return _bd.Categoria.OrderBy(c => c.Nombre).ToList();
        }

        public bool Guardar()
        {
            return _bd.SaveChanges() >=0 ? true : false;  
        }
    }
}
