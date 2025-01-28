using Entidades.Modelos;
using Datos.Nucleo;

namespace Logica.BL
{
    public class ModeloBL:Context<Cat_Modelos>
    {
        public async Task<Cat_Modelos?> BuscarModelo(int Id)
        {
            return await GET_BYID(Id);
        }
        public async Task<IEnumerable<Cat_Modelos>> ListaModelo()
        {
            return await GET_ALL();
        }
        public async Task<Cat_Modelos?> GuardarModelo(Cat_Modelos cat_Modelos)
        {
            return await INSERT(cat_Modelos);
        }
        public async Task<Cat_Modelos?> ModificarModelo(Cat_Modelos cat_Modelos)
        {
            await UPDATE(cat_Modelos);
            return await GET_BYID(cat_Modelos.Id);
        }
    }
}
