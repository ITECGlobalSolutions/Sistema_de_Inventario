using Entidades.Modelos;
using Datos.Nucleo;

namespace Logica.BL
{
    public class OpcionesBL : Context<Cat_Opciones>
    {
        public async Task<Cat_Opciones?> BuscarOpcion(int Id)
        {
            return await GET_BYID(Id);
        }
        public async Task<IEnumerable<Cat_Opciones>> ListaOpcion()
        {
            return await GET_ALL();
        }
        public async Task<Cat_Opciones?> GuardarOpcion(Cat_Opciones cat_Opciones)
        {
            return await INSERT(cat_Opciones);
        }
        public async Task<Cat_Opciones?> ModificarOpcion(Cat_Opciones cat_Opciones)
        {
            await UPDATE(cat_Opciones);
            return await GET_BYID(cat_Opciones.Id);
        }
    }
}
