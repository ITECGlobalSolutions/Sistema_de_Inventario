using Entidades.Modelos;
using Datos.Nucleo;

namespace Logica.BL
{
    public class CategoriaBL:Context<Cat_Categoria>
    {
        public async Task<Cat_Categoria?> BuscarCategoria(int Id)
        {
            return await GET_BYID(Id);
        }
        public async Task<IEnumerable<Cat_Categoria>> ListaCategoria()
        {
            return await GET_ALL();
        }
        public async Task<Cat_Categoria?> GuardarCategoria(Cat_Categoria cat_Categoria)
        {
            return await INSERT(cat_Categoria);
        }
        public async Task<Cat_Categoria?> ModificarCategoria(Cat_Categoria cat_Categoria)
        {
            await UPDATE(cat_Categoria);
            return await GET_BYID(cat_Categoria.Id);
        }
    }
}
