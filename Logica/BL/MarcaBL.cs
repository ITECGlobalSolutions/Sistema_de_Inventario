using Entidades.Modelos;
using Datos.Nucleo;

namespace Logica.BL
{
    public class MarcaBL : Context<Cat_Marca>
    {
        public async Task<Cat_Marca?> BuscarMarca(int Id)
        {
            return await GET_BYID(Id);
        }
        public async Task<IEnumerable<Cat_Marca>> ListaMarca()
        {
            return await GET_ALL();
        }
        public async Task<Cat_Marca?> GuardarMarca(Cat_Marca cat_Marca)
        {
            return await INSERT(cat_Marca);
        }
        public async Task<Cat_Marca?> ModificarMarca(Cat_Marca cat_Marca)
        {
            await UPDATE(cat_Marca);
            return await GET_BYID(cat_Marca.Id);
        }
    }
}
