using Entidades.Modelos;
using Datos.Nucleo;

namespace Logica.BL
{
    public class AlmacenBL:Context<Almacen>
    {
        public async Task<Almacen?> BuscarAlmacen(int Id)
        {
            return await GET_BYID(Id);
        }
        public async Task<IEnumerable<Almacen>> ListaAlmacen()
        {
            return await GET_ALL();
        }
        public async Task<Almacen?> GuardarAlmacen(Almacen almacen)
        {
            return await INSERT(almacen);
        }
        public async Task<Almacen?> ModificarAlmacen(Almacen almacen)
        {
            await UPDATE(almacen);
            return await GET_BYID(almacen.Id);
        }
    }
}
